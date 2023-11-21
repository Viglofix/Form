namespace DataBase.Model;
    public class Test 
    {
     public long Id_Test { get; set; }
     public required string Question { get; set; }
     public string? CorrectAnswer { get; set; }
     public ICollection<TestAnswer>? Answers { get; set; }
    }  
