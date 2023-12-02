using DataBase;
using DataBase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Helper;
using Services.Service;
using Npgsql;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Services.Helper.DataInsertHelpers;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Services.Container;
using FluentValidation;
using System.Security.Cryptography.X509Certificates;

namespace Services.Container;

// Trzeba pomyslec na zaimplementowaniem wspolbierznosci i synchronizacji wątków

public class ClickUpService : IClickUpService
{
    private readonly FormDbContext _formDbContext;
    private readonly IConfiguration _configuration;
    public ClickUpService(FormDbContext formDbContext,IConfiguration configuration)
    {
        _formDbContext = formDbContext;
        _configuration = configuration;
    }

    public async Task<List<ClickUpRequiredDataModel>> GetAllUsers()
    {
        var db = await _formDbContext.clickup_required_data.ToListAsync();
        if(db is null || !db.Any()) {
            return null!;
        }
        return db!;
    }

    public async Task<List<DropFilesModel>> CreateDropFile(List<IFormFile> files)
    {
            FileManagementService fileManagementService = new(_formDbContext);
            long? seq_clickUp = null;
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("FormDb")))
            {
                await connection.OpenAsync();
                using (var command = new NpgsqlCommand(@"SELECT last_value FROM ""clickUp_required_data_id_seq""", connection))
                {
                    seq_clickUp = (long?)command.ExecuteScalar();
                }
                await connection.CloseAsync();
            }

            var db = fileManagementService.DownloadFile(files, seq_clickUp);
            await _formDbContext.drop_files.AddRangeAsync(db!);
            await _formDbContext.SaveChangesAsync();
            return db!;
    }
    public async Task<ApiResponseCreateUserPost> CreateUser(ClickUpRequiredDataModelRequest model)
    {
        FileManagementService service = new(_formDbContext);
        ApiResponseCreateUserPost _response = new();
        try
        {
            if(model is null)
            {
                throw new Exception("model not found");
            }

            Validation validation = new();
            var validationResult = await validation.ValidateAsync(model);
            if(!validationResult.IsValid)
            {
                throw new Exception("validation is false");
            }

            long seq = 0;
            using(var connection = new NpgsqlConnection(_configuration.GetConnectionString("FormDb")))
            {
                await connection.OpenAsync();
                using(var command = new NpgsqlCommand(@"SELECT NEXTVAL('""clickup_required_data_id_seq""')",connection))
                {
                    seq = (long)command.ExecuteScalar()!;
                }
                await connection.CloseAsync();
            }

            if(_formDbContext.specializations is null || !_formDbContext.specializations.Any()){
                await _formDbContext!.specializations!.AddRangeAsync(new InsertSpecialization().GetAllSpecializations());
                await _formDbContext.SaveChangesAsync();
            }
            
            ClickUpRequiredDataModel? obj = null;
            foreach(var item in await _formDbContext.specializations.ToListAsync()) {
                if(item.Role == model.Specialization) {
            obj = new()
            {
                Id = seq,
                FullName = model.FullName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                DateOfBirth = model.DateOfBirth,
                Specialization_Id = item.Id,
                NameOfUniversityOrOccupation = model.NameOfUniversityOrOccupation,
                GithubAccount = model.GithubAccount,
                ProgrammingLangugages = model.ProgramingLanguages,
                GraphicInspitation = model.GraphicInspiration,
                ProficientGraphicTools = model.ProficientGraphicTools,
                Experience = model.Experience,
                FinishedProject = model.FinishedProject,
                English_Level = model.English_Level,
                LearningGoals = model.LearningGoals,
                GoalOfAcademyParticipation = model.GoalOfAcademyParticipation,
                PracticesStart = model.PracticesStart,
                PracticesEnd = model.PracticesEnd,
                AdditionalInformation = model.AdditionalInformation,
                DropFilesModel = service.DownloadSingleFile(model.FormFile!,seq),
            };
            }
            }

            await _formDbContext.clickup_required_data.AddAsync(obj!);
            await _formDbContext.SaveChangesAsync();

            _response.ResultId = obj!.Id;
            _response.Specialization = obj?.Specializations!.Role;
            _response.ResponseCode = 201;
        }
        catch (Exception ex)
        {
            _response.ResponseCode = 400;
            _response.ErrorMessage = ex.Message;
            return _response;
        }
        return _response;
    }

    public async Task<List<School>> GetAllSchools(){
        if(_formDbContext is null || !_formDbContext.schools.Any())
        {
            await _formDbContext!.schools.AddRangeAsync(new InsertSchool().GetSchools());
            await _formDbContext!.SaveChangesAsync();
        }
        var schoolObj = await _formDbContext.schools.ToListAsync();
        return schoolObj;
    }

    public async Task<List<FrontendDataMember>> GetAllMembers()
    {
           if(_formDbContext.specializations is null || !_formDbContext.specializations.Any()){
                await _formDbContext!.specializations!.AddRangeAsync(new InsertSpecialization().GetAllSpecializations());
                await _formDbContext.SaveChangesAsync();
            }
            
        try {
        var userObj = await _formDbContext.clickup_required_data
        .Include(x=>x.Specializations)
        .ToListAsync();

        List<FrontendDataMember> dataList = new();
        foreach(var obj in userObj) {
            FrontendDataMember model = new()
            {
                Id = obj.Id,
                FullName = obj.FullName,
                ColumnId = obj.ColumnId,
                Specialization = new FrontendDataSpecialization() {
                    Domain = obj.Specializations!.Domain,
                    Role = obj.Specializations.Role
                },
                Note = obj.Note,
                AssignedToProjectId = obj.AssignedToProjectId,
                Range = obj.Range
            };
            dataList.Add(model);
        }

        var orderedList = dataList.OrderBy(x=>x.Id).ToList();
        return orderedList;
        }
        catch(Exception ex) {
            return new List<FrontendDataMember>() {
                new FrontendDataMember() {
                     Note = ex.Message,
                }
            };
        }
    }

    /* public async Task<List<EnglishLevelModel>> GetAllEnglishLevel()
    {
        var table = await _formDbContext.english_level.ToListAsync();
        return table;
    }

    public async Task<List<SpecializationModel>> GetAllSpecialization()
    {
        var listToReturn =  await _formDbContext.specializations.ToListAsync();
        return listToReturn;
    } */
}
