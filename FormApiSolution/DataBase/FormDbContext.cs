using DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase;

public class FormDbContext : DbContext
{
    public FormDbContext(DbContextOptions<FormDbContext> options) : base(options)
    {
         
    }
    public virtual DbSet<ClickUpRequiredDataModel> clickup_required_data { get; set; }
    public virtual DbSet<SpecializationModel> specializations { get; set; }
    public virtual DbSet<StatusOfRecruiterModel> status_of_recruiter { get; set; }
    public virtual DbSet<TypeOfPracticeModel> type_of_practice { get; set; }
    public virtual DbSet<EnglishLevelModel> english_level { get; set; }
    public virtual DbSet<DropFilesModel> drop_files { get; set; }
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
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .HasKey(x => x.Id_StatusOfRecruiter);
        modelBuilder.Entity<TypeOfPracticeModel>()
            .HasKey(x => x.Id_TypeOfPractice);
        modelBuilder.Entity<EnglishLevelModel>()
            .HasKey(x => x.Id_EnglishLevel);
        modelBuilder.Entity<DropFilesModel>()
            .HasKey(x => x.FileID);

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
            .HasColumnType("VARCHAR")
            .HasMaxLength(64)
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

        // Foreign Keys
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.Specialization_Id)
            .HasColumnName("specialization_id")
            .HasColumnType("BIGINT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.Status_Id)
            .HasColumnName("status_id")
            .HasColumnType("BIGINT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.EnglishLevel_Id)
            .HasColumnName("english_level_id")
            .HasColumnType("BIGINT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.DropFile_Id)
            .HasColumnName("drop_file_id")
            .HasColumnType("BIGINT")
            .HasDefaultValue(null)
            .IsRequired(false);
        // End of Foreign Keys

        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x=>x.GithubAccount)
            .HasColumnName("github_account")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.ProgrammingKnowledge)
            .HasColumnName("programmin_knowledge")
            .HasColumnType("VARCHAR")
            .HasMaxLength(256)
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.GraphicInspitation)
            .HasColumnName("graphic_inspiration")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.GraphicProgram)
            .HasColumnName("graphic_program")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.Experience)
            .HasColumnName("experience")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.FinishedProject)
            .HasColumnName("finished_project")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired(false);
     modelBuilder.Entity<ClickUpRequiredDataModel>()
           .Property(x => x.Expectation)
           .HasColumnName("expectation")
           .HasColumnType("TEXT")
           .HasDefaultValue(null)
           .IsRequired();
       modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.AdditionalInformation)
            .HasColumnName("additional_information")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired(false); 
      /*  modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x=>x.TypeOfPractice_Id)
            .HasColumnName("type_of_practice_id")
            .HasColumnType("BIGINT")
            .HasDefaultValue(null)
            .IsRequired(false); */

        // SpecializationModel properties configuration
        modelBuilder.Entity<SpecializationModel>()
            .Property(x => x.Id_Specialization)
            .HasColumnName("id_specialization")
            .HasColumnType("BIGINT")
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
        // StatusOfRecruiterModel properties configuration
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .Property(x => x.Id_StatusOfRecruiter)
            .HasColumnName("id_status_of_recruiter")
            .HasColumnType("BIGINT")
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .Property(x => x.NameOfTheUniversity)
            .HasColumnName("name_of_the_university")
            .HasColumnType("VARCHAR")
            .HasMaxLength(128)
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .Property(x => x.StartDateOfPractice)
            .HasColumnName("start_date_of_practice")
            .HasColumnType("DATE")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .Property(x => x.EndDateOfPractice)
            .HasColumnName("end_date_of_practice")
            .HasColumnType("DATE")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .Property(x=>x.TypeOfPracticeModel_Id)
            .HasColumnName("type_of_practice_id")
            .HasColumnType("BIGINT")
            .HasDefaultValue(null)
            .IsRequired(false);

        // TypeOfPracticeModel properties configuration
        modelBuilder.Entity<TypeOfPracticeModel>()
            .Property(x=>x.Id_TypeOfPractice)
            .HasColumnName("id_type_of_practice")
            .HasColumnType("BIGINT")
            .UseIdentityAlwaysColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<TypeOfPracticeModel>()
            .Property(x=>x.TypeOfPracticeName)
            .HasColumnName("id_type_of_practice_name")
            .HasColumnType("VARCHAR")
            .HasDefaultValue(null)
            .HasMaxLength(64)
            .IsRequired();
        // EnglishLevel properties configuration
        modelBuilder.Entity<EnglishLevelModel>()
            .Property(x => x.Id_EnglishLevel)
            .HasColumnName("id_english_level")
            .HasColumnType("BIGINT")
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue:1)
            .IsRequired();
        modelBuilder.Entity<EnglishLevelModel>()
            .Property(x => x.EnglishLevelProperty)
            .HasColumnName("english_level_property")
            .HasColumnType("VARCHAR")
            .HasMaxLength(2)
            .HasDefaultValue("B1")
            .IsRequired();
        // DropFiles properties configuration
        modelBuilder.Entity<DropFilesModel>()
            .Property(x => x.FileID)
            .HasColumnType("file_id")
            .HasColumnType("BIGINT")
            .UseIdentityAlwaysColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<DropFilesModel>()
            .Property(x =>x.FileName)
            .HasColumnName("file_name")
            .HasColumnType("VARCHAR")
            .HasMaxLength(256)
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<DropFilesModel>()
            .Property(x => x.FileData)
            .HasColumnName("file_data")
            .HasColumnType("BYTEA")
            .IsRequired();

        // RelationShips
        // Many-To-One Relationship ClickUpRequiredDataModel >--| SpecializationModel
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<SpecializationModel>(x => x.Specialization)
            .WithMany(x => x.clickUpRequiredDataModel)
            .HasForeignKey(x => x.Specialization_Id);
        // Many-To-One Relationship ClickUpRequiredDataModel > --| StatusOfRecruiterModel
       modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<StatusOfRecruiterModel>(x => x.Status)
            .WithMany(x => x.clickUpRequiredDataModel)
            .HasForeignKey(x => x.Status_Id); 
       /* modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<TypeOfPracticeModel>(x => x.TypeOfPractice)
            .WithMany(x => x.ClickUpRequiredDataModels)
            .HasForeignKey(x => x.TypeOfPractice_Id); */
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .HasOne<TypeOfPracticeModel>(x => x.TypeOfPracticeModel)
            .WithMany(x => x.StatusOfRecruiterModels)
            .HasForeignKey(x => x.TypeOfPracticeModel_Id);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<EnglishLevelModel>(x => x.EnglishLevel)
            .WithMany(x => x.ClickUpRequiredDataModels)
            .HasForeignKey(x => x.EnglishLevel_Id);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<DropFilesModel>(x => x.DropFiles)
            .WithMany(x => x.clickUpRequiredDataModels)
            .HasForeignKey(x => x.DropFile_Id);

        base.OnModelCreating(modelBuilder);
    }
}
