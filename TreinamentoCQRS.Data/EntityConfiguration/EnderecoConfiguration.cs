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
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Cep).HasMaxLength(9).IsRequired();
            builder.Property(x => x.Logradouro).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Bairro).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Localidade).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Uf).HasMaxLength(2).IsRequired();
        }
    }
}
