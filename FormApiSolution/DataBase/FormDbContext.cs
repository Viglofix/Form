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
   // public virtual DbSet<SpecializationModel> specializations { get; set; }
   // public virtual DbSet<StatusOfRecruiterModel> status_of_recruiter { get; set; }
   // public virtual DbSet<TypeOfPracticeModel> type_of_practice { get; set; }
   // public virtual DbSet<EnglishLevelModel> english_level { get; set; }
    public virtual DbSet<DropFilesModel> drop_files { get; set; }
    public virtual DbSet<AdminPanel> admin_panel { get; set; }
    public virtual DbSet<School> schools {get;set;}
    public virtual DbSet<Test> tests { get; set; }
    public virtual DbSet<TestAnswer> test_answers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasKey(x => x.Id);
        modelBuilder.Entity<AdminPanel>()
            .HasKey(x => x.Id_Admin);
        modelBuilder.Entity<DropFilesModel>()
            .HasKey(x => x.Id_File);
        modelBuilder.Entity<School>()
            .HasKey(x=>x.Id_School);
        modelBuilder.Entity<Test>()
            .HasKey(x => x.Id_Test);
        modelBuilder.Entity<TestAnswer>()
            .HasKey(x => x.Id_TestAnswer);

        /* Start Primary Keys
        modelBuilder.Entity<SpecializationModel>()
            .HasKey(x => x.Id_Specialization);
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .HasKey(x => x.Id_StatusOfRecruiter);
        modelBuilder.Entity<TypeOfPracticeModel>()
            .HasKey(x => x.Id_TypeOfPractice);
        modelBuilder.Entity<EnglishLevelModel>()
            .HasKey(x => x.Id_EnglishLevel); */

        // ClickUpRequiredDataModel Properties Configuration
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("BIGINT")
            .UseIdentityByDefaultColumn()
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
            .Property(x => x.PhoneNumber)
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
            .Property(x=>x.GithubAccount)
            .HasColumnName("github_account")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.ProgrammingLangugages)
            .HasColumnName("programming_languages")
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
            .Property(x => x.ProficientGraphicTools)
            .HasColumnName("proficient_graphic_tools")
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
            .Property(x => x.English_Level)
            .HasColumnName("english_level")
            .HasColumnType("VARCHAR")
            .HasMaxLength(5)
            .HasDefaultValue(null)
            .IsRequired();
       modelBuilder.Entity<ClickUpRequiredDataModel>()
           .Property(x => x.LearningGoals)
           .HasColumnName("learning_goals")
           .HasColumnType("TEXT")
           .HasDefaultValue(null)
           .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.GoalOfAcademyParticipation)
            .HasColumnName("goal_of_academy_participation")
            .HasColumnType("VARCHAR")
            .HasMaxLength(64)
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.PracticesStart)
            .HasColumnName("practices_start")
            .HasColumnType("DATE")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.PracticesEnd)
            .HasColumnName("practices_end")
            .HasColumnType("DATE")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Property(x => x.AdditionalInformation)
            .HasColumnName("additional_information")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired(false);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .Ignore(x => x.FormFile);

        /* Foreign Keys
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
  End of Foreign Keys */

        /*
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
            .IsRequired(); */

        //DropFiles properties configuration
        modelBuilder.Entity<DropFilesModel>()
            .Property(x => x.Id_File)
            .HasColumnName("id_file")
            .HasColumnType("BIGINT")
            .UseIdentityByDefaultColumn()
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
            .Property(x => x.FileSize)
            .HasColumnName("file_size")
            .HasColumnType("TEXT")
            .HasDefaultValue(null)
            .IsRequired();
        modelBuilder.Entity<DropFilesModel>()
            .Property(x => x.FileData)
            .HasColumnName("file_data")
            .HasColumnType("BYTEA")
            .IsRequired();
        modelBuilder.Entity<DropFilesModel>()
            .Property(x => x.ClickUp_Id)
            .HasColumnName("click_up_id")
            .HasColumnType("BIGINT")
            .IsRequired(false);

        // admin panel
        modelBuilder.Entity<AdminPanel>()
            .Property(x => x.Id_Admin)
            .HasColumnName("id_admin")
            .HasColumnType("BIGINT")
            .UseIdentityColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<AdminPanel>()
            .Property(x => x.Note)
            .HasColumnName("note")
            .HasColumnType("TEXT")
            .HasDefaultValue("Note about this account")
            .IsRequired();
        modelBuilder.Entity<AdminPanel>()
            .Property(x => x.Login)
            .HasColumnName("login")
            .HasColumnType("VARCHAR")
            .HasDefaultValue(null)
            .HasMaxLength(32)
            .IsRequired();
        modelBuilder.Entity<AdminPanel>()
            .Property(x => x.Password)
            .HasColumnName("password")
            .HasColumnType("VARCHAR")
            .HasDefaultValue(null)
            .HasMaxLength(64)
            .IsRequired();

        // School
        modelBuilder.Entity<School>()
            .Property(x=>x.Id_School)
            .HasColumnName("id_school")
            .HasColumnType("BIGINT")
            .UseIdentityAlwaysColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<School>()
            .Property(x=>x.Name)
            .HasColumnName("name")
            .HasColumnType("VARCHAR")
            .HasDefaultValue(null)
            .HasMaxLength(256)
            .IsRequired();
        // Tests
        modelBuilder.Entity<Test>()
            .Property(x => x.Id_Test)
            .HasColumnName("id_test")
            .HasColumnType("BIGINT")
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<Test>()
            .Property(x=>x.Question)
            .HasColumnName("question")
            .HasColumnType("VARCHAR")
            .HasMaxLength(64)
            .IsRequired();
        modelBuilder.Entity<Test>()
            .Property(x => x.CorrectAnswer)
            .HasColumnName("correct_answer")
            .HasColumnType("TEXT")
            .IsRequired();

        // TestQuestion Table
        modelBuilder.Entity<TestAnswer>()
            .Property(x=>x.Id_TestAnswer)
            .HasColumnName("id_test_answer")
            .HasColumnType("BIGINT")
            .UseIdentityByDefaultColumn()
            .HasIdentityOptions(startValue: 1)
            .IsRequired();
        modelBuilder.Entity<TestAnswer>()
            .Property(x=>x.Answer)
            .HasColumnName("answer")
            .HasColumnType("TEXT")
            .IsRequired();
        modelBuilder.Entity<TestAnswer>()
            .Property(x => x.Test_Id)
            .HasColumnName("test_id")
            .HasColumnType("BIGINT");
        // RelationShips
        /*
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<SpecializationModel>(x => x.Specialization)
            .WithMany(x => x.clickUpRequiredDataModel)
            .HasForeignKey(x => x.Specialization_Id);
       modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<StatusOfRecruiterModel>(x => x.Status)
            .WithMany(x => x.clickUpRequiredDataModel)
            .HasForeignKey(x => x.Status_Id); 
        modelBuilder.Entity<StatusOfRecruiterModel>()
            .HasOne<TypeOfPracticeModel>(x => x.TypeOfPracticeModel)
            .WithMany(x => x.StatusOfRecruiterModels)
            .HasForeignKey(x => x.TypeOfPracticeModel_Id);
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne<EnglishLevelModel>(x => x.EnglishLevel)
            .WithMany(x => x.ClickUpRequiredDataModels)
            .HasForeignKey(x => x.EnglishLevel_Id);
        modelBuilder.Entity<DropFilesModel>()
            .HasOne<ClickUpRequiredDataModel>(x => x.clickUpRequiredDataModel)
            .WithMany(x => x.DropFiles)
            .HasForeignKey(x => x.ClickUp_Id); */

        // Files Relationship
        modelBuilder.Entity<ClickUpRequiredDataModel>()
            .HasOne(x => x.DropFilesModel)
            .WithOne(x => x.clickUpRequiredDataModel)
            .HasForeignKey<DropFilesModel>(x => x.ClickUp_Id);

        // Test Relationship
        modelBuilder.Entity<TestAnswer>()
            .HasOne<Test>(x => x.Test)
            .WithMany(x => x.Answers)
            .HasForeignKey(x => x.Test_Id);

        base.OnModelCreating(modelBuilder);
    }
}
