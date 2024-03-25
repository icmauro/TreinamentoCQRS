using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Data.EntityConfiguration;
using TreinamentoCQRS.Domain.Entities;
using TreinamentoCQRS.Domain.Notificacao;

namespace TreinamentoCQRS.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            :base(options)
        { 
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new FornecedorConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.Ignore<Error>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
