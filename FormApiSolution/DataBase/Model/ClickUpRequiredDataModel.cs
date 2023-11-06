namespace DataBase.Model;

public class ClickUpRequiredDataModel
{
    public long Id { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumeber { get; set; }
    public required DateTime DateOfBirth { get; set; }
    public long? Specialization_Id { get; set; }
    public virtual required SpecializationModel Specialization { get; set; }
 /*   public virtual StatusOfRecruiterModel? Status { get; set; }
    public string? GithubAccount { get; set; }
    // Knowledge Section
    public string? ProgrammingKnowledge { get; set; }
    public string? GraphicInspitation { get; set; }
    public string? GraphicPrograms { get; set; }
    public string? Experience { get; set; }
    public string? FinishedProjects { get; set; }
    public required virtual EnglishLevelModel EnglishLevel { get; set; }
    public required string Expectations { get; set; }
    public string? AdditionalInformation { get; set; }
    public DropFilesModel? DropFilesModel { get; set; } */

}