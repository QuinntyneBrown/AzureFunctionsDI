using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(AzureFunctionsDI.Startup))]
namespace AzureFunctionsDI
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //builder.Services.AddScoped<IMyService, MyService>();
            //builder.Services.AddTransient<IMyService, MyService>();
            builder.Services.AddSingleton<IMyService, MyService>();
        }
    }
}
