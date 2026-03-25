using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class CargoLiderancaMap : IEntityTypeConfiguration<CargoLideranca>
    {
        public void Configure(EntityTypeBuilder<CargoLideranca> builder)
        {
            builder.ToTable("CARGOLIDERANCA");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Nome).HasColumnName("NOME").HasMaxLength(50).IsRequired();
            builder.Property(e => e.Classificacao).HasColumnName("CLASSIFICACAO").HasMaxLength(15).IsRequired();
            builder.Property(e => e.DataInicio).HasColumnName("DATAINICIO");
            builder.Property(e => e.DataFim).HasColumnName("DATAFIM");
            builder.Property(e => e.Status).HasColumnName("STATUS").HasMaxLength(10);
            builder.Property(e => e.Ativo).HasColumnName("ATIVO").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("DATAINCLUSAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("DATAALTERACAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}