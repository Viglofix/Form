
using DataBase.Model;
using Services.Helper.DTO;

namespace Services.Helper.DataManager
{
    internal class DTOManager
    {
       // private readonly object _locker = new object();
        public async Task UpdateUserDTOConverter(ClickUpRequiredDataModel objToUpdate,UpdateUserDTO model) {
         objToUpdate.FullName = model.FullName ?? objToUpdate.FullName;
         objToUpdate.Email = model.Email ?? objToUpdate.Email;
         objToUpdate.PhoneNumber = model.PhoneNumber ?? objToUpdate.PhoneNumber;
         objToUpdate.DateOfBirth = model.DateOfBirth ?? objToUpdate.DateOfBirth;
         objToUpdate.GithubAccount = model.GithubAccount ?? objToUpdate.GithubAccount;
         objToUpdate.NameOfUniversityOrOccupation = model.NameOfUniversityOrOccupation ?? objToUpdate.NameOfUniversityOrOccupation;
         objToUpdate.ProgrammingLangugages = model.ProgrammingLanguages ?? objToUpdate.ProgrammingLangugages;
         objToUpdate.GraphicInspiration = model.ProgrammingLanguages ?? objToUpdate.GraphicInspiration;
         objToUpdate.ProficientGraphicTools = model.ProficientGraphicTools ?? objToUpdate.ProficientGraphicTools;
         objToUpdate.Experience = model.Experience ?? objToUpdate.Experience;
         objToUpdate.FinishedProject = model.FinishedProject ?? objToUpdate.FinishedProject;
         objToUpdate.English_Level = model.English_Level ?? objToUpdate.English_Level;
         objToUpdate.LearningGoals = model.LearningGoals ?? objToUpdate.LearningGoals;
         objToUpdate.GoalOfAcademyParticipation = model.GoalOfAcademyParticipation ?? objToUpdate.GoalOfAcademyParticipation;
         objToUpdate.PracticesStart = model.PracticesStart ?? objToUpdate.PracticesStart;
         objToUpdate.PracticesEnd = model.PracticesEnd ?? objToUpdate.PracticesEnd;
         objToUpdate.AdditionalInformation = model.AdditionalInformation ?? objToUpdate.AdditionalInformation;
         objToUpdate.FormFile = model.FormFile! ?? objToUpdate.FormFile;
         objToUpdate.ColumnId = model.ColumnId ?? objToUpdate.ColumnId;
         objToUpdate.AssignedToProjectId = model.AssignedToProjectId ?? objToUpdate.AssignedToProjectId;
         objToUpdate.Range = model.Range ?? objToUpdate.Range;
        }
    }
}
