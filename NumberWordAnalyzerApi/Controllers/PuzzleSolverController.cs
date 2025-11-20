using Microsoft.AspNetCore.Mvc;
using NumberWordAnalyzerApi.BusinessLogic.Interfaces;

namespace NumberWordAnalyzerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PuzzleSolverController : ControllerBase
    {
        private readonly IPuzzleSolverApiCalls _puzzleSolverApiCalls;
        private readonly ILogger<PuzzleSolverController> _logger;

        public PuzzleSolverController(ILogger<PuzzleSolverController> logger, IPuzzleSolverApiCalls puzzleSolverApiCalls)
        {
            _logger = logger;
            _puzzleSolverApiCalls = puzzleSolverApiCalls;
        }

        [HttpGet("GetOrderedString")]
        public Task<string> GetOrderedString()
        {
            try
            {
                var result = _puzzleSolverApiCalls.GetOrderedStringApi();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured: {ex.Message}");
                throw new Exception("Something went wrong");
            }
            
        }

        [HttpGet("GetRandomString")]
        public Task<string> GetRandomString()
        {
            try
            {
                var result = _puzzleSolverApiCalls.GetRandomStringApi();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured: {ex.Message}");
                throw new Exception("Something went wrong");
            }
          
        }
    }
}
