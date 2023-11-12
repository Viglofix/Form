namespace DataBase.Model;

public class AdminPanel
{
    public long Id_Admin { get; set; }
    public required string Login { get; set; }
    public required string Password { get; set; }
    public string? Note { get; set; }
}