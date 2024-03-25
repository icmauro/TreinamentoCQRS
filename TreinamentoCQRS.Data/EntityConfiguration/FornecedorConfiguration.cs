using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoCQRS.Domain.Entities;

namespace TreinamentoCQRS.Data.EntityConfiguration
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Cnpj).HasMaxLength(15).IsRequired();
            builder.Property(x => x.Telefone).HasMaxLength(10).IsRequired();
            builder.Property(x => x.EnderecoId).IsRequired();
            builder.HasMany(x => x.Produtos).WithOne(x => x.Fornecedor).HasForeignKey(x => x.FornecedorId);
            
        }
    }
}
