﻿using Microsoft.AspNetCore.Http;

namespace Services.Helper.DTO;
    public class UpdateUserDTO
    {
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? GithubAccount { get; set; }
    public string? Specialization { get; set; }
    public string? NameOfUniversityOrOccupation { get; set; }
    public string? ProgrammingLanguages { get; set; }
    public string? GraphicInspiration { get; set; }
    public string? ProficientGraphicTools { get; set; }
    public string? Experience { get; set; }
    public string? FinishedProject { get; set; }
    public string? English_Level { get; set; }
    public string? LearningGoals { get; set; }
    public string? GoalOfAcademyParticipation { get; set; }
    public DateTime? PracticesStart { get; set; }
    public DateTime? PracticesEnd { get; set; }
    public string? AdditionalInformation { get; set; }
    public string? ColumnId { get; set; }
    public long? AssignedToProjectId { get; set; }
    public long? Range { get; set; }
    public IFormFile? FormFile { get; set; }
}
