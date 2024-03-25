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
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descricao).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.Marca).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Unidade).IsRequired();
            builder.Property(x => x.Quilograma).IsRequired();
            builder.Property(x => x.Metro).IsRequired();
            builder.Property(x => x.FornecedorId);
            builder.HasOne(x => x.Fornecedor);
        }
    }
}
