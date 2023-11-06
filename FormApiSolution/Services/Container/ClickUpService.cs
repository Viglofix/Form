using DataBase;
using DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Services.Service;

namespace Services.Container;

public class ClickUpService : IClickUpService
{
    private readonly FormDbContext _formDbContext;
    public ClickUpService(FormDbContext formDbContext)
    {
        _formDbContext = formDbContext;
    }
    public async Task<List<SpecializationModel>> GetAllSpecialization()
    {
        var listToReturn =  await _formDbContext.specializations.ToListAsync();
        return listToReturn;
    }
}
