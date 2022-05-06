using CG.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CG.IoC
{
    public static class ConfigureBindingsServices
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<DadosPessoaService>();
            services.AddScoped<EnderecoService>();
        }
    }
}
