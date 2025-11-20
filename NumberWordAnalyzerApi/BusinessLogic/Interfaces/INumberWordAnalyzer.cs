using NumberWordAnalyzerApi.DTOs;

namespace NumberWordAnalyzerApi.BusinessLogic.Interfaces
{
    public interface INumberWordAnalyzer
    {
        List<WordCountResultDTO> CountNumberWordsFromString(string inputString);
    }
}
