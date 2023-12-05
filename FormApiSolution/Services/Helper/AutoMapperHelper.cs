using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using DataBase;
using DataBase.Model;
using Microsoft.EntityFrameworkCore;

namespace Services.Helper;

public class AutoMapperHelper : Profile {
    private readonly FormDbContext _formDbContext;
    public AutoMapperHelper(FormDbContext formDbContext)
    {
        _formDbContext = formDbContext;
        CreateMap<ClickUpRequiredDataModelRequest,ClickUpRequiredDataModel>()
        .ForMember(x=>x.Specialization_Id,opt=>{
            foreach(var item in _formDbContext.specializations.ToList())
            opt.MapFrom(y=>y.Specialization == item.Role ? item.Id : null); {
            }
        });
    }
}