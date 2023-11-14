using DataBase;
using DataBase.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.Helper;
using Services.Service;
using Npgsql;
using Microsoft.Extensions.Configuration;
using Services.Container;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

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

    public async Task<ApiResponse> CreateUser(ClickUpRequiredDataModel model)
    {
        ApiResponse _response = new();
        try
        {
            if(model is null)
            {
                throw new Exception("model not found");
            }
            // var sqlQuery = _formDbContext.status_of_recruiter.FromSql(@$"SELECT nextval('StatusOfRecruiterModel_id_status_of_recruiter_seq')");

            long? seq = null;
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
            }

            ClickUpRequiredDataModel obj = new()
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
                    // DropFile_Id = seqFile!.Value,
                    /* DropFiles = new DropFilesModel()
                     {
                         FileID = seqFile!.Value,
                         FileName = model.DropFiles.FileName,
                         FileSize = model.DropFiles.FileSize,
                         FileData = model.DropFiles.FileData
                     }, */
                    GithubAccount = model.GithubAccount,
                    ProgrammingKnowledge = model.ProgrammingKnowledge,
                    GraphicInspitation = model.GraphicInspitation,
                    GraphicProgram = model.GraphicProgram,
                    Experience = model.Experience,
                    FinishedProject = model.FinishedProject,
                    Expectation = model.Expectation,
                    AdditionalInformation = model.AdditionalInformation
                };

            await _formDbContext.clickup_required_data.AddAsync(obj);
            await _formDbContext.SaveChangesAsync();

            _response.Result = obj;
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

    public async Task<List<EnglishLevelModel>> GetAllEnglishLevel()
    {
        var table = await _formDbContext.english_level.ToListAsync();
        return table;
    }

    public async Task<List<SpecializationModel>> GetAllSpecialization()
    {
        var listToReturn =  await _formDbContext.specializations.ToListAsync();
        return listToReturn;
    }
}
