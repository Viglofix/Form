using DataBase.Model;
using FluentValidation;

namespace Services.Helper;
    public class Validation : AbstractValidator<ClickUpRequiredDataModelRequest>
    {
    public Validation()
    {
        RuleFor(x => x.fullName)
                .NotEmpty().WithMessage("Pole 'FullName' jest wymagane.");

        RuleFor(x => x.email)
            .NotEmpty().WithMessage("Pole 'Email' jest wymagane.")
            .EmailAddress().WithMessage("Niepoprawny format adresu email.");

        RuleFor(x => x.phoneNumber)
            .NotEmpty().WithMessage("Pole 'PhoneNumber' jest wymagane.")
            .Matches(@"^\(\+48\) \d{3}-\d{3}-\d{3}$").WithMessage("Niepoprawny format numeru telefonu. Oczekiwany format: (+48) 000-000-000");

        RuleFor(x => x.dateOfBirth)
            .NotEmpty().WithMessage("Pole 'DateOfBirth' jest wymagane.")
            .WithMessage("Niepoprawny format daty urodzenia.");

        RuleFor(x => x.specialization)
            .NotEmpty().WithMessage("Pole 'Specialization' jest wymagane.");

        RuleFor(x => x.nameOfUniversityOrOccupation)
            .NotEmpty().WithMessage("Pole 'NameOfUniversityOrOccupation' jest wymagane.");

        RuleFor(x => x.english_Level)
            .NotEmpty().WithMessage("Pole 'English_Level' jest wymagane.")
            .Matches(@"\b(?:B1|B2|C1|C2)\b");

        RuleFor(x => x.learningGoals)
            .NotEmpty().WithMessage("Pole 'LearningGoals' jest wymagane.");

        RuleFor(x => x.goalOfAcademyParticipation)
            .NotEmpty().WithMessage("Pole 'GoalOfAcademyParticipation' jest wymagane.");

        RuleFor(x => x.practicesStart)
            .NotEmpty().WithMessage("Niepoprawny format daty rozpoczęcia praktyk.");

        RuleFor(x => x.practicesEnd)
            .NotEmpty()
            .WithMessage("Niepoprawny format daty zakończenia praktyk.");
    }

}
