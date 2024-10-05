using FluentValidation;
using FluentValidation.AspNetCore;
using GerenciadorDeBiblioteca.Application.Commands.LivroCommand.InsertLivro;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
               
                .AddHandler()
                .AddValidation();

            return services;
        }

       
        private static IServiceCollection AddHandler(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            config.RegisterServicesFromAssemblyContaining<InsertLivroCommand>());
                                   

            return services;
        }
        private static IServiceCollection AddValidation(this IServiceCollection services)
        {
            services
               .AddFluentValidationAutoValidation()
               .AddValidatorsFromAssemblyContaining<InsertLivroCommand>();

                
            return services;
        }

    }
}
