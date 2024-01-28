using DataBase.Model;
using Services.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Helper.DataInsertHelpers;
using Services.Helper.DTO;

namespace Services.Service;
public interface IClickUpService
{
  /*  public Task<List<SpecializationModel>> GetAllSpecialization();
    public Task<List<EnglishLevelModel>> GetAllEnglishLevel(); */
    public Task<ApiResponseCreateUserPost> CreateUser(ClickUpRequiredDataModelRequest model);
    public Task<string> UpdateUser(long id,UpdateUserDTO model);
    public Task<List<DropFilesModel>> CreateDropFile(List<IFormFile> files);
    public Task<List<ClickUpRequiredDataModel>> GetAllUsers();
    public Task<List<School>> GetAllSchools();
    public Task<List<FrontendDataMemberDTO>> GetAllMembers();
}