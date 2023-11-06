using DataBase.Model;

namespace Services.Service;
public interface IClickUpService
{
    public Task<List<SpecializationModel>> GetAllSpecialization(); 
}