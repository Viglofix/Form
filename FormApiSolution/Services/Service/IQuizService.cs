using Services.Helper.DataInsertHelpers;

namespace Services.Service;
    public interface IQuizService
    {
    public Task<List<FrontendData>> GetQuestion(string specialization);
    public Task<long?> RangUpdate(long id, int score);
    }
