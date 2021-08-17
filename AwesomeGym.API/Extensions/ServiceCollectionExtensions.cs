using AwesomeGym.Application.InputModels;
using AwesomeGym.Application.Services;
using AwesomeGym.Application.Validators;
using AwesomeGym.Infrastructure.Persistencia.Repositorios;
using AwesymeGym.Core.Intefaces.Repositorios;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace AwesomeGym.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IUnidadeRepository, UnidadeRepository>();

            return services;
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IUnidadeService, UnidadeService>();

            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<UnidadeInputModel>, UnidadeInputModelValidator>();

            return services;
        }
    }
}
