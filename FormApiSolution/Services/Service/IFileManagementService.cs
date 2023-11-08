using Services.Helper;
using Microsoft.AspNetCore.Http;

namespace Services.Service;
public interface IFileManagementService
{
    public Task<ApiResponse> UploadFile(IFormFile file);
}
