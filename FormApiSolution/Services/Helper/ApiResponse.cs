namespace Services.Helper;

public class ApiResponse
{
    public object? Result { get; set; }
    public int ResponseCode { get; set; }
    public string? ErrorMessage { get; set; }    
}