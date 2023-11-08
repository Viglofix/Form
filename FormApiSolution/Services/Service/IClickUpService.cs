using DataBase.Model;
using Services.Helper;

namespace Services.Service;
public interface IClickUpService
{
    public Task<List<SpecializationModel>> GetAllSpecialization(); 
}