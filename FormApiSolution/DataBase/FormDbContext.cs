using DataBase.Model;
using Microsoft.EntityFrameworkCore;
namespace DataBase;

public class FormDbContext : DbContext
{
    public FormDbContext(DbContextOptions<FormDbContext> options) : base(options)
    {
         
    }
    public virtual DbSet<ClickUpRequiredDataModel> ClickUpRequiredData { get; set; }
    public virtual DbSet<DropFilesModel> DropFiles { get; set; }
    public virtual DbSet<EnglishLevelModel> EnglishLevel { get; set; }
    public virtual DbSet<StatusOfRecruiterModel> StatusOfRecruiter { get; set; }
}
