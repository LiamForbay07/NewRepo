using NumberWordAnalyzerApi.BusinessLogic.Implementation;
using NumberWordAnalyzerApi.BusinessLogic.Interfaces;

namespace NumberWordAnalyzerApi.Helpers
{
    public static class NumberWordAnalyzerServiceExtension
    {
        //Inject Services so that the functions from the interfaces are callable
        public static IServiceCollection BusinessLogicDependencies(this IServiceCollection services) {
            
            services.AddScoped<INumberWordAnalyzer, NumberWordAnalyzer>();
            services.AddScoped<IPuzzleSolverApiCalls, PuzzleSolverApiCalls>();

            return services;
        }
    }
}
