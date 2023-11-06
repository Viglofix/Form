namespace DataBase.Model;

public class StatusOfRecruiterModel
{
    public int RecruiterId { get; set; }
    public required string NameOfTheUniversity { get; set; }
    public required DateTime? StartDateOfPractice { get; set; }
    public required DateTime? EndDateOfPractice { get; set; }

}