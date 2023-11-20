namespace DataBase.Model;
    public class TestAnswer
    {
    public long Id_TestAnswer { get; set; }
    public string? Answer { get; set; }
    public long Test_Id { get; set; }
    public Test? Test { get; set; }
    }
