using CG.Infra.Interfaces;
using CG.Infra.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CG.IoC
{
    public class ConfigureBindingsRepositories
    {
        public static void RegisterBindings(IServiceCollection services)
        {
            services.AddScoped<IRepositoryDadosPessoais, DadosPessoaRepository>();
            services.AddScoped<IRepositoryEndereco, EnderecoRepository>();
        }
    }
}
