namespace DataBase.Model;

public class ClickUpRequiredDataModel
{
    public long Id { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumeber { get; set; }
    public required DateTime DateOfBirth { get; set; }
    // if this property is equal to school or university then relation will be perform
   // public required string StatusOfRecruiter { get; set; }
    public long? Specialization_Id { get; set; }
    public long? Status_Id { get; set; }
    public long? EnglishLevel_Id { get; set; }
    public long? DropFile_Id { get; set; }
  //  public required long TypeOfPractice_Id { get; set; }
    public virtual SpecializationModel? Specialization { get; set; }
    public virtual StatusOfRecruiterModel? Status { get; set; }
    public virtual EnglishLevelModel? EnglishLevel { get; set; }
    public virtual DropFilesModel? DropFiles { get; set; }
  //  public virtual TypeOfPracticeModel? TypeOfPractice { get; set; }
    public string? GithubAccount { get; set; } 
    // Knowledge Section
    public string? ProgrammingKnowledge { get; set; }
    public string? GraphicInspitation { get; set; }
    public string? GraphicProgram { get; set; }
    public string? Experience { get; set; }
    public string? FinishedProject { get; set; }
 /*   public required string Expectation { get; set; }
    public string? AdditionalInformation { get; set; } */
    /* public DropFilesModel? DropFilesModel { get; set; } */

}