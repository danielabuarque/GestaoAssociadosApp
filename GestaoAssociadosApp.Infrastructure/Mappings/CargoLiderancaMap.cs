using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class CargoLiderancaMap : IEntityTypeConfiguration<CargoLideranca>
    {
        public void Configure(EntityTypeBuilder<CargoLideranca> builder)
        {
            builder.ToTable("cargolideranca");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
            builder.Property(e => e.Classificacao).HasColumnName("classificacao").HasMaxLength(15).IsRequired();
            builder.Property(e => e.DataInicio).HasColumnName("datainicio");
            builder.Property(e => e.DataFim).HasColumnName("datafim");
            builder.Property(e => e.Status).HasColumnName("status").HasMaxLength(10);
            builder.Property(e => e.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("datainclusao").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("dataalteracao").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}