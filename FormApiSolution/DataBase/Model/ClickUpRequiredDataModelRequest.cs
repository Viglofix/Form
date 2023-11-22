using Microsoft.AspNetCore.Http;

namespace DataBase.Model;

    public class ClickUpRequiredDataModelRequest
    {
    public required string fullName { get; set; }
    public required string email { get; set; }
    public required string phoneNumber { get; set; }
    public required DateTime dateOfBirth { get; set; }
    public string? githubAccount { get; set; }
    public required string specialization { get; set; }
    public required string nameOfUniversityOrOccupation { get; set; }
    public string? programmingLangugages { get; set; }
    public string? graphicInspitation { get; set; }
    public string? proficientGraphicTools { get; set; }
    public string? experience { get; set; }
    public string? finishedProject { get; set; }
    public required string english_Level { get; set; }
    public required string learningGoals { get; set; }
    public required string goalOfAcademyParticipation { get; set; }
    public DateTime? practicesStart { get; set; }
    public DateTime? practicesEnd { get; set; }
    public string? additionalInformation { get; set; }
    public IFormFile formFile { get; set; }
}
