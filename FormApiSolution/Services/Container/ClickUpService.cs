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

            /* long? seq = null;
            long? seqFile = null;
            using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("FormDb")))
            {
                await connection.OpenAsync();
                using (var command = new NpgsqlCommand(@"SELECT NEXTVAL('""StatusOfRecruiterModel_id_status_of_recruiter_seq""')", connection))
                {
                    seq = (long?)command.ExecuteScalar();
                }
                using(var command = new NpgsqlCommand(@"SELECT NEXTVAL('""drop_files_FileID_seq""')", connection))
                {
                    seqFile = (long?)command.ExecuteScalar();
                }
                await connection.CloseAsync();
            }*/

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

            ClickUpRequiredDataModel obj = new()
            {
                Id = seq,
                FullName = model.FullName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                DateOfBirth = model.DateOfBirth,
                Specialization = model.Specialization,
                NameOfUniversityOrOccupation = model.NameOfUniversityOrOccupation,
                GithubAccount = model.GithubAccount,
                ProgrammingLangugages = model.ProgrammingLangugages,
                GraphicInspitation = model.GraphicInspitation,
                ProficientGraphicTools = model.ProficientGraphicTools,
                Experience = model.Experience,
                FinishedProject = model.FinishedProject,
                English_Level = model.English_Level,
                LearningGoals = model.LearningGoals,
                GoalOfAcademyParticipation = model.GoalOfAcademyParticipation,
                PracticesStart = model.PracticesStart,
                PracticesEnd = model.PracticesEnd,
                AdditionalInformation = model.AdditionalInformation,
                DropFilesModel = service.DownloadSingleFile(model.FormFile!,seq)
            };

            /* ClickUpRequiredDataModel obj = new()
             {
                 FullName = model.FullName,
                 Email = model.Email,
                 PhoneNumeber = model.PhoneNumeber,
                 DateOfBirth = model.DateOfBirth,
                 Specialization_Id = model.Specialization_Id,
                 Status_Id = seq!.Value,// Tutaj front musi wyslac liczbe id jeden czy cos, zeby w UI przeksztalci sie na .net czy tam react
                 Status = new StatusOfRecruiterModel()
                 {
                     Id_StatusOfRecruiter = seq!.Value, // --- Nadpisujemy wartosc z requesta powyzej, wiec sekwencja przy tworzeniu statusu nie jest wykorzystywana
                     NameOfTheUniversity = model.Status.NameOfTheUniversity,
                     StartDateOfPractice = model.Status.StartDateOfPractice,
                     EndDateOfPractice = model.Status.EndDateOfPractice,
                     TypeOfPracticeModel_Id = model.Status.TypeOfPracticeModel_Id
                 },
                 EnglishLevel_Id = model.EnglishLevel_Id,
                     GithubAccount = model.GithubAccount,
                     ProgrammingKnowledge = model.ProgrammingKnowledge,
                     GraphicInspitation = model.GraphicInspitation,
                     GraphicProgram = model.GraphicProgram,
                     Experience = model.Experience,
                     FinishedProject = model.FinishedProject,
                     Expectation = model.Expectation,
                     AdditionalInformation = model.AdditionalInformation
                 }; */

            await _formDbContext.clickup_required_data.AddAsync(obj);
            await _formDbContext.SaveChangesAsync();

            _response.ResultId = obj.Id;
            _response.Specizlization = obj.Specialization;
            _response.ResponseCode = 201;
        }
        catch (Exception ex)
        {
            _response.ResponseCode = 404;
            _response.ErrorMessage = ex.Message;
            return _response;
        }
        return _response;
    }

    public async Task<List<School>> GetAllSchools(){
        var schoolObj = await _formDbContext.schools.ToListAsync();
        return schoolObj;
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
