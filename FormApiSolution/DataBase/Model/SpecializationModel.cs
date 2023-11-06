namespace DataBase.Model;

public class SpecializationModel
{
    public long Id_Specialization { get;set; }
    public required string Specialization_Name { get; set; }
    public ClickUpRequiredDataModel? clickUpRequiredDataModel { get; set; }
}