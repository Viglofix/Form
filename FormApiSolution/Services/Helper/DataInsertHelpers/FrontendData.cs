using DataBase.Model;

namespace Services.Helper.DataInsertHelpers;
    public class FrontendData
 {
    public required string Question { get; set; }
    public string? CorrectAnswer { get; set; }
    public List<string>? Answers { get; set; }
  }
