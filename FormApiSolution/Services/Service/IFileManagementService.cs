using Services.Helper;
using Microsoft.AspNetCore.Http;
using DataBase.Model;

namespace Services.Service;
public interface IFileManagementService
{
    public Task<ApiResponse> UploadFile(IFormFile file);
    public DropFilesModel DownloadSingleFile(IFormFile file, long id);
    public List<DropFilesModel>? DownloadFile(List<IFormFile>? file, long? id);

}
