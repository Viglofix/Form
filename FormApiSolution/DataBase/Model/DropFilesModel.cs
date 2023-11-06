namespace DataBase.Model;
public class DropFilesModel
{
    public long FileID { get; set; }
    public required string FileName { get; set; }
    public long FileSize { get; set; }
    public required byte[] FileData { get; set; }
}