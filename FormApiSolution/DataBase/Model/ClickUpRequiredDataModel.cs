using Microsoft.AspNetCore.Http;

namespace DataBase.Model;

public class ClickUpRequiredDataModel
{
    public long Id { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumeber { get; set; }
    public required DateTime DateOfBirth { get; set; }
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
    public required string Specialization { get; set; }
    public required string NameOfUniversityOrOccupation { get; set; }
    public string? ProgrammingLangugages { get; set; }
    public string? GraphicInspitation { get; set; }
    public string? ProficientGraphicTools { get; set; }
    public string? Experience { get; set; }
    public string? FinishedProject { get; set; }
    public required string english_Level { get; set; }
    public required string LearningGoals { get; set; }
    public required string GoalOfAcademyParticipation { get; set; }
    public DateTime? PracticesStart { get; set; }
    public DateTime? PracticesEnd { get; set; }
    public string? AdditionalInformation { get; set; }
    public IFormFile? formFile { get; set; }
}