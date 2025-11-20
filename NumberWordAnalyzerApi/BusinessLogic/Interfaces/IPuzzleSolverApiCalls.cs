using NumberWordAnalyzerApi.DTOs;

namespace NumberWordAnalyzerApi.BusinessLogic.Interfaces
{
    public interface IPuzzleSolverApiCalls
    {
        Task<string> GetOrderedStringApi();
        Task<string> GetRandomStringApi();
    }
}
