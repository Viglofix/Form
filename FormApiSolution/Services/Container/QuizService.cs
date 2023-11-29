using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services.Helper.DataInsertHelpers;
using Services.Service;
using DataBase.Model;
using Npgsql;

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
    public async Task<List<FrontendData>> GetQuestion(string specialization)
    {
        try
        {
            if (_formDbContext.tests is null || !_formDbContext.tests.Any())
            {
                using(var connection = new NpgsqlConnection(_configuration.GetConnectionString("FormDb")))
                {
                    await connection.OpenAsync();
                    using var command = new NpgsqlCommand(@"ALTER SEQUENCE ""tests_id_test_seq"" RESTART WITH 1 ",connection);
                    using var commandTwo = new NpgsqlCommand(@"ALTER SEQUENCE ""test_answers_id_test_answer_seq"" RESTART WITH 1 ",connection);

                    command.ExecuteScalar();
                    commandTwo.ExecuteScalar();

                    await connection.CloseAsync();
                }
                await _formDbContext.AddRangeAsync(new InsertFrontendData().GetTests());
                await _formDbContext.SaveChangesAsync();
            }

            List<Test>? query = new();
            switch(specialization)
            {
                case "react":
                    query = await _formDbContext.tests!
                   .Include(x => x.Answers)
                   .Where(x => x.Id_Test > 0 && x.Id_Test <= 5)
                   .ToListAsync();
                 break;
                case ".net":
                 query = await _formDbContext.tests!
                 .Include(x => x.Answers)
                 .Where(x => x.Id_Test > 5 && x.Id_Test <= 10)
                 .ToListAsync();
                break;
                case "react native":
                 query = await _formDbContext.tests!
                 .Include(x=>x.Answers)
                 .Where(x=>x.Id_Test > 10 && x.Id_Test <= 15)
                 .ToListAsync();
                 break;
                case "node.js":
                 query = await _formDbContext.tests!
                 .Include(x=>x.Answers)
                 .Where(x=>x.Id_Test > 15 && x.Id_Test <= 20)
                 .ToListAsync();
                 break;
            }

            List<FrontendData> tempList = new();
            List<string> tempListString = new();

            foreach(var obj in query)
            {
                FrontendData frontData = new()
                {
                    Question = obj.Question,
                    CorrectAnswer = obj.CorrectAnswer,
                    Answers = obj.Answers!.Select(x=>x.Answer).ToList()!
                };
                tempList!.Add(frontData);
            }
          /*  if (refactoredObj is null)
            {
                return null!;
            } */
            return tempList!;
        }
        catch (Exception ex)
        {
            return null!;
        }
    }
}
