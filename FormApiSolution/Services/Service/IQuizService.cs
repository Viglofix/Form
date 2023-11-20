using Services.Helper.DataInsertHelpers;

namespace Services.Service;
    public interface IQuizService
    {
    public Task<FrontendData> GetQuestion(int id);
    }
