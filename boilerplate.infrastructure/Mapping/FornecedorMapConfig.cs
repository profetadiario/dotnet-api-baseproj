using Boilerplate.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Boilerplate.Infra.Mapping
{
    public class FornecedorMapConfig : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("TBL_FORNECEDOR");
            builder.HasKey(fornecedor => fornecedor.Id);
            builder.Property(fornecedor => fornecedor.Id).HasColumnName("ID");
            builder.Property(fornecedor => fornecedor.Nome).HasColumnName("NOME").HasColumnType("varchar(100)").IsRequired();
            builder.Property(fornecedor => fornecedor.Link).HasColumnName("LINK").HasColumnType("varchar(200)").IsRequired();
            builder.Property(fornecedor => fornecedor.MantemHistorico).HasColumnName("HAS_HISTORICO").HasColumnType("boolean").IsRequired();
            builder.Property(fornecedor => fornecedor.Vertical).HasColumnName("VERTICAL").HasColumnType("int").IsRequired();
        }
    }
}
