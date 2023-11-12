namespace DataBase.Model;
public class TypeOfPracticeModel
{
    public long Id_TypeOfPractice { get; set; }
    public required string TypeOfPracticeName { get; set; }
   // public required virtual ICollection<ClickUpRequiredDataModel> ClickUpRequiredDataModels { get; set; }
    public required virtual ICollection<StatusOfRecruiterModel> StatusOfRecruiterModels { get; set; }
}