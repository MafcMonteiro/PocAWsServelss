using Domain.ProjetoSunshine.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Services.Services.ProjetoSunshine;

namespace CrossCutting.Dependencies
{
    public class Bootstrapper
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddScoped<IProjetoSunshineService, ProjetoSunshineService>();
        }
    }
}
