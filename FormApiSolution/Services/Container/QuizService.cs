using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services.Helper.DataInsertHelpers;
using Services.Service;

namespace Services.Container;
public class QuizService : IQuizService
{
    private readonly FormDbContext _formDbContext;
    private readonly IConfiguration _configuration;
    public QuizService(FormDbContext formDbContext, IConfiguration configuration)
    {
        _formDbContext = formDbContext;
        _configuration = configuration;
    }
    public async Task<FrontendData> GetQuestion(int id)
    {
        try
        {
            if (_formDbContext.tests is null || !_formDbContext.tests.Any())
            {
                await _formDbContext.AddRangeAsync(new InsertFrontendData().GetTests());
                await _formDbContext.SaveChangesAsync();
            }

            var query = await _formDbContext.tests!
                 .Include(x => x.Answers)
                 .FirstOrDefaultAsync(x => x.Id_Test == id);

            List<string> tempList = new();
            foreach (var item in query!.Answers!)
            {
                tempList!.Add(item.Answer!);
            }

            FrontendData refactoredObj = new()
            {
                Question = query.Question,
                CorrectAnswer = query.CorrectAnswer,
                Answers = tempList
            };

            if (refactoredObj is null)
            {
                return null!;
            }
            return refactoredObj!;
        }
        catch (Exception ex)
        {
            return null!;
        }
    }
}
