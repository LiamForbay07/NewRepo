using Newtonsoft.Json;
using NumberWordAnalyzerApi.BusinessLogic.Interfaces;
using NumberWordAnalyzerApi.DTOs;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NumberWordAnalyzerApi.BusinessLogic.Implementation
{
    public class PuzzleSolverApiCalls : IPuzzleSolverApiCalls
    {
        private readonly string _numberGeneratorApiUrl;

        public PuzzleSolverApiCalls(IConfiguration configuration)
        {
            _numberGeneratorApiUrl = configuration.GetSection("NumberGeneratorApi").Value ?? "";
        }

        public async Task<string> GetOrderedStringApi()
        {
            var result = "";
            try
            {
                using var client = new HttpClient();
                var endpointUrl = $"{_numberGeneratorApiUrl}/TestNumberWordGenerator/ordered";
                var response = await client.GetAsync(endpointUrl);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.SerializeObject(result);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }

        public async Task<string> GetRandomStringApi()
        {
            var result = "";
            try
            {
                using var client = new HttpClient();
                var endpointUrl = $"{_numberGeneratorApiUrl}/TestNumberWordGenerator/random";
                var response = await client.GetAsync(endpointUrl);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.SerializeObject(result);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
