using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Data.BussinesLayer;
using TreinamentoCQRS.Data.Context;
using TreinamentoCQRS.Data.Repositories;
using TreinamentoCQRS.Domain.Interface;

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

            services.AddScoped<IEnderecoRepositorie, EnderecoRepositorie>();
            services.AddScoped<IProdutoRepositorie, ProdutoRepositorie>();
            services.AddScoped<IFornecedorRepositorie, FornecedorRepositorie>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProdutoBussines, ProdutoBussines>();
            services.AddScoped<IFornecedorBussines, FornecedorBussines>();

            return services;
        }
    }
}
