using FluentValidation;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TreinamentoCQRS.Application.Members.Commands.Validations;
using TreinamentoCQRS.Data.BussinesLayer;
using TreinamentoCQRS.Data.Context;
using TreinamentoCQRS.Data.Repositories;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Interface;
using TreinamentoCQRS.Domain.View;

namespace TreinamentoCQRS.CrossCuting.Extensoes
{
    public static class Extensoes
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                           IConfiguration configuration)
        {
            services.AddEntityFrameworkSqlServer()
                       .AddDbContext<DataContext>(
                          options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //configuration.GetSection("").Value

            services.AddScoped<IEnderecoRepositorie, EnderecoRepositorie>();
            services.AddScoped<IProdutoRepositorie, ProdutoRepositorie>();
            services.AddScoped<IFornecedorRepositorie, FornecedorRepositorie>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProdutoBussines, ProdutoBussines>();
            services.AddScoped<IFornecedorBussines, FornecedorBussines>();
            services.AddScoped<IProdutoDapperRepositorie, ProdutoQuerieDapperRepositorie>();

            var myHandlers = AppDomain.CurrentDomain.Load("TreinamentoCQRS.Application");

            services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssemblies(myHandlers);
                cfg.AddBehavior(typeof(ValidationBehaviour<,>));
             });

            services.AddValidatorsFromAssembly(Assembly.Load("TreinamentoCQRS.Application"));

            services.AddSingleton<IDbConnection>(provider => {

                var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
                connection.Open();

                return connection;
              
            });

            return services;
        }

    }
}
