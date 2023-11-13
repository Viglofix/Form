using DataBase;
using Microsoft.AspNetCore.Http;
using Npgsql;
using Services.Helper;
using Services.Service;
using DataBase.Model;
using Microsoft.EntityFrameworkCore;

namespace Services.Container;
public class FileManagementService : IFileManagementService
{
    private readonly FormDbContext _formDbContext;
    public FileManagementService(FormDbContext formDbContext)
    {
        _formDbContext = formDbContext;
    }

    public List<DropFilesModel>? DownloadFile(List<IFormFile>? file, long? id)
    {
        try
        {
            if (file!.Count <= 0)
            {
                throw new Exception("No files found");
            }
            List<DropFilesModel>? dropFilesModel = new();
            foreach (var item in file)
            {
                using (var memory = new MemoryStream())
                {
                    item.CopyTo(memory);
                    var obj = new DropFilesModel() {
                        FileName = item.FileName,
                        FileSize = item.Length,
                        FileData = memory.ToArray(),
                        ClickUp_Id = id
                    };
                    dropFilesModel.Add(obj);
                }
            }
            return dropFilesModel!;
        }
        catch (Exception ex)
        {
            return new List<DropFilesModel>()
            {
                new DropFilesModel() {FileName = ex.Message}
            };
        }
    }
    public async Task<ApiResponse> UploadFile(IFormFile file)
    {
        ApiResponse _response = new ApiResponse();
        try
        {
            if (file is null || file.Length <= 0)
            {
                throw new Exception("No files found");
            }
            DropFilesModel? db = null;
            /*
             *MemoryStream to klasa, która przechowuje dane w pamięci RAM jako tablicę bajtów (byte[]). 
             *Jest to przydatne, gdy chcesz operować na danych w pamięci, na przykład,
             *gdy pracujesz z danymi, które są generowane dynamicznie lub przetwarzane w 
             *pamięci, a nie pochodzą z plików na dysku. 
             */
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                db = new DropFilesModel()
                {
                    FileName = file.FileName,
                    FileSize = file.Length,
                    FileData = memoryStream.ToArray()
                };
                await _formDbContext.drop_files.AddAsync(db);
                await _formDbContext.SaveChangesAsync();
            }
            _response.ResponseCode = 201;
            _response.Result = db;
        }
        catch(Exception ex)
        {
            // Bad Request
            _response.ResponseCode = 400;
            _response.ErrorMessage = ex.Message;
            return _response;
        }
        return _response;
    }
}
