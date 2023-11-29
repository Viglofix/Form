using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;

namespace DataBase.Model;
public class ClickUpRequiredDataModel 
{
    public long Id { get; set; }
    public required string FullName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    /* Zakomentowane sa tutaj relacje, ktore nie sa na razie potrzebne 
     * public long? Specialization_Id { get; set; }
      public long? EnglishLevel_Id { get; set; }
      public long? Status_Id { get; set; }
      public virtual SpecializationModel? Specialization { get; set; }
      public virtual StatusOfRecruiterModel? Status { get; set; }
      public virtual EnglishLevelModel? EnglishLevel { get; set; }
      public virtual ICollection<DropFilesModel>? DropFiles { get; set; } 
      // Knowledge Section */
    public virtual DropFilesModel? DropFilesModel { get; set; }
    public string? GithubAccount { get; set; }  
    public string? NameOfUniversityOrOccupation { get; set; }
    public string? ProgrammingLangugages { get; set; }
    public string? GraphicInspitation { get; set; }
    public string? ProficientGraphicTools { get; set; }
    public string? Experience { get; set; }
    public string? FinishedProject { get; set; }
    public string? English_Level { get; set; }
    public string? LearningGoals { get; set; }
    public string? GoalOfAcademyParticipation { get; set; }
    public DateTime? PracticesStart { get; set; }
    public DateTime? PracticesEnd { get; set; }
    public string? AdditionalInformation { get; set; }
    public IFormFile FormFile { get; set; }
    public string? ColumnId {get;set;}
    public long? Range {get;set;}
    public string? Note {get;set;}
    public long? AssignedToProjectId {get;set;}
    public long? Specialization_Id {get;set;}
    public virtual Specialization? Specializations {get;set;}
}

public class Specialization {
  public long? Id {get;set;}
  public required string Domain {get;set;}
  public required string Role {get;set;}
  public virtual ClickUpRequiredDataModel? ClickUpRequiredDataModel {get;set;}
}