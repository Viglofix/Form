namespace DataBase.Model;
public class DropFilesModel
{
    public long FileID { get; set; }
    public required string FileName { get; set; }
    public long FileSize { get; set; }
    public byte[]? FileData { get; set; }
    public virtual ICollection<ClickUpRequiredDataModel>? clickUpRequiredDataModels { get; set; }
}