using DataBase.Model;
using Microsoft.EntityFrameworkCore;
namespace DataBase;

public class FormDbContext : DbContext
{
    public FormDbContext(DbContextOptions<FormDbContext> options) : base(options)
    {
         
    }
    public virtual DbSet<ClickUpRequiredDataModel> clickup_required_data { get; set; }
    public virtual DbSet<SpecializationModel> specializations { get; set; }
    /*    public virtual DbSet<DropFilesModel> DropFiles { get; set; }
       public virtual DbSet<EnglishLevelModel> EnglishLevel { get; set; }
       public virtual DbSet<StatusOfRecruiterModel> StatusOfRecruiter { get; set; } */

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Primary Keys
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasKey(x => x.Id);
        modelBuilder.Entity<SpecializationModel>()
            .HasKey(x => x.Id_Specialization);

        // ClickUpRequiredDataModel Properties Configuration
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("BIGINT")
            .UseIdentityAlwaysColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.FullName)
            .HasColumnName("full_name")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.Email)
            .HasColumnName("email")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.PhoneNumeber)
            .HasColumnName("phone_number")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.DateOfBirth)
            .HasColumnName("date_of_birth")
            .HasColumnType("DATE")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.Specialization_Id)
            .HasColumnName("specialization_id")
            .HasColumnType("BIGINT")
            .HasDefaultValue(null)
            .IsRequired(false);

        // SpecializationModel properties configuration
        modelBuilder.Entity<SpecializationModel>()
            .Property(x => x.Id_Specialization)
            .HasColumnName("id_specialization")
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<SpecializationModel>()
            .Property(x => x.Specialization_Name)
            .HasColumnName("specialization_name")
            .HasColumnType("VARCHAR")
            .HasDefaultValue(null)
            .HasMaxLength(128)
            .IsRequired();

        // RelationShips
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<SpecializationModel>(x => x.Specialization)
            .WithMany(x => x.clickUpRequiredDataModel)
            .HasForeignKey(x => x.Specialization_Id);

        base.OnModelCreating(modelBuilder);
    }
}
