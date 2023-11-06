namespace DataBase.Model;

public class SpecializationModel
{
    public long Id_Specialization { get;set; }
    public required string Specialization_Name { get; set; }
    public virtual ICollection<ClickUpRequiredDataModel>? clickUpRequiredDataModel { get; set; }
}