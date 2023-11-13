using Microsoft.AspNetCore.Http;

namespace DataBase.Model;
public class DropFilesModel : IDisposable
{
    public long Id_File { get; set; }
    public required string FileName { get; set; }
    public long FileSize { get; set; }
    public byte[]? FileData { get; set; }
    public List<IFormFile>? File { get; set; }
    public long? ClickUp_Id { get; set; }
    public virtual ClickUpRequiredDataModel? clickUpRequiredDataModel { get; set; }

    public void Dispose()
    {
    }
}