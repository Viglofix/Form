using Microsoft.AspNetCore.Http;

namespace DataBase.Model;

    public class ClickUpRequiredDataModelRequest
    {
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required DateTime DateOfBirth { get; set; }
    public string? GithubAccount { get; set; }
    public required string Specialization { get; set; }
    public required string NameOfUniversityOrOccupation { get; set; }
    public string? ProgrammingLangugages { get; set; }
    public string? GraphicInspitation { get; set; }
    public string? ProficientGraphicTools { get; set; }
    public string? Experience { get; set; }
    public string? FinishedProject { get; set; }
    public required string English_Level { get; set; }
    public required string LearningGoals { get; set; }
    public required string GoalOfAcademyParticipation { get; set; }
    public DateTime? PracticesStart { get; set; }
    public DateTime? PracticesEnd { get; set; }
    public string? AdditionalInformation { get; set; }
    public IFormFile FormFile { get; set; }
}
