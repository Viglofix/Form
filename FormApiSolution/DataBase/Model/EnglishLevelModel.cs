namespace DataBase.Model;

public class EnglishLevelModel
{
    public long Id_EnglishLevel { get; set; }
    public required string EnglishLevelProperty {get;set;}
    public virtual ICollection<ClickUpRequiredDataModel>? ClickUpRequiredDataModels {  get; set; }    
}