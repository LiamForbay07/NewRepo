
using NumberWordAnalyzerApi.Helpers;

namespace NumberWordAnalyzerApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Allow app to read appsettings file so that numberGeneratorApi can be called for use in app
            builder.Configuration
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",optional:false, reloadOnChange:true);
            
            //Dependency Injection for Interface & Implemenetation of NumberWordAnalyzer logic
            NumberWordAnalyzerServiceExtension.BusinessLogicDependencies(builder.Services);

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
