using DataBase.Model;
using FluentValidation;

namespace Services.Helper;
    public class Validation : AbstractValidator<ClickUpRequiredDataModelRequest>
    {
    public Validation()
    {
        RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Pole 'FullName' jest wymagane.");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Pole 'Email' jest wymagane.")
            .EmailAddress().WithMessage("Niepoprawny format adresu email.");

        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("Pole 'PhoneNumber' jest wymagane.")
            .Matches(@"^\(\+48\) \d{3}-\d{3}-\d{3}$").WithMessage("Niepoprawny format numeru telefonu. Oczekiwany format: (+48) 000-000-000");

        RuleFor(x => x.DateOfBirth)
            .NotEmpty().WithMessage("Pole 'DateOfBirth' jest wymagane.")
            .WithMessage("Niepoprawny format daty urodzenia.");

        RuleFor(x => x.Specialization)
            .NotEmpty().WithMessage("Pole 'Specialization' jest wymagane.");

        RuleFor(x => x.NameOfUniversityOrOccupation)
            .NotEmpty().WithMessage("Pole 'NameOfUniversityOrOccupation' jest wymagane.");

        RuleFor(x => x.English_Level)
            .NotEmpty().WithMessage("Pole 'English_Level' jest wymagane.")
            .Matches(@"\b(?:B1|B2|C1|C2)\b");

        RuleFor(x => x.LearningGoals)
            .NotEmpty().WithMessage("Pole 'LearningGoals' jest wymagane.");

        RuleFor(x => x.GoalOfAcademyParticipation)
            .NotEmpty().WithMessage("Pole 'GoalOfAcademyParticipation' jest wymagane.");
    }

}
