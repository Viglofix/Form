using DataBase.Model;
using Services.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Services.Service;
public interface IClickUpService
{
    public Task<List<SpecializationModel>> GetAllSpecialization();
    public Task<ApiResponse> CreateUser(ClickUpRequiredDataModel model);
}