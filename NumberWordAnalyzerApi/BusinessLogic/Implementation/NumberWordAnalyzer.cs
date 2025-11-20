using NumberWordAnalyzerApi.BusinessLogic.Interfaces;
using NumberWordAnalyzerApi.DTOs;
using NumberWordAnalyzerApi.Helpers;

namespace NumberWordAnalyzerApi.BusinessLogic.Implementation
{
    public class NumberWordAnalyzer : INumberWordAnalyzer
    {
        public List<WordCountResultDTO> CountNumberWordsFromString(string inputString)
        {
            var result = new List<WordCountResultDTO>();
            var acceptedNumberWords = AcceptedNumberWords.GetAcceptedNumberWords();
            var countedWords = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            try
            {

                if (string.IsNullOrEmpty(inputString))
                {
                    return result;
                }
                else
                {
                    for (int i = 0; i < inputString.Length; i++)
                    {
                        foreach (var kv in acceptedNumberWords)
                        {
                            var word = kv.Key;
                            if (i + word.Length <= inputString.Length)
                            {
                                var matchesAcceptedNumberWord = string.Equals(inputString.Substring(i, word.Length), word, StringComparison.OrdinalIgnoreCase);
                                if (matchesAcceptedNumberWord)
                                {
                                    if (!countedWords.ContainsKey(word))
                                    {
                                        countedWords[word] = 0;
                                    }
                                    countedWords[word]++;
                                }

                            }
                        }
                    }
                    result = countedWords.Select(kv => new WordCountResultDTO()
                    {
                        Word = kv.Key,
                        Value = acceptedNumberWords[kv.Key],
                        Count = kv.Value
                    }).ToList();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
