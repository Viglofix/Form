using DataBase.Model;
using Services.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Helper.DataInsertHelpers;

namespace Services.Service;
public interface IClickUpService
{
  /*  public Task<List<SpecializationModel>> GetAllSpecialization();
    public Task<List<EnglishLevelModel>> GetAllEnglishLevel(); */
    public Task<ApiResponseCreateUserPost> CreateUser(ClickUpRequiredDataModelRequest model);
    public Task<List<DropFilesModel>> CreateDropFile(List<IFormFile> files);
    public Task<FrontendData> GetQuestion(int id);
    public Task<List<School>> GetAllSchools();
}