namespace DataBase.Model;

public class StatusOfRecruiterModel
{
    public long Id_StatusOfRecruiter { get; set; }
    public required string NameOfTheUniversity { get; set; }
    public required DateTime? StartDateOfPractice { get; set; }
    public required DateTime? EndDateOfPractice { get; set; }
    public virtual ICollection<ClickUpRequiredDataModel>? clickUpRequiredDataModel { get; set; }
    public long? TypeOfPracticeModel_Id { get; set; }
    public virtual TypeOfPracticeModel? TypeOfPracticeModel { get; set; }
}