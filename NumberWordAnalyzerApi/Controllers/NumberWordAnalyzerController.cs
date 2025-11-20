using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumberWordAnalyzerApi.BusinessLogic.Interfaces;
using NumberWordAnalyzerApi.DTOs;
using System.Net;

namespace NumberWordAnalyzerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumberWordAnalyzerController : ControllerBase
    {
        private readonly INumberWordAnalyzer _numberWordAnalyzer;
        private readonly ILogger<NumberWordAnalyzerController> _logger;

        public NumberWordAnalyzerController(INumberWordAnalyzer numberWordAnalyzer, ILogger<NumberWordAnalyzerController> logger)
        {
            _numberWordAnalyzer = numberWordAnalyzer;
            _logger = logger;
        }

        [HttpPost("CountNumberWordsFoundInString")]
        public Task<List<WordCountResultDTO>> CountNumberWordsFoundInString([FromBody] string input)
        {
            var result = new List<WordCountResultDTO>();
            try
            {
                if (string.IsNullOrEmpty(input)) {
                    return Task.FromResult<List<WordCountResultDTO>>(result);
                }
                {
                    result = _numberWordAnalyzer.CountNumberWordsFromString(input);
                }
                return Task.FromResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex.Message} found in CountNumberWordsFoundInString");
                throw new Exception($"Error {ex.Message} found in CountNumberWordsFoundInString");
            }
        }
    }
}
