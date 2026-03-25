using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class AreaAtuacaoMap : IEntityTypeConfiguration<AreaAtuacao>
    {
        public void Configure(EntityTypeBuilder<AreaAtuacao> builder)
        {
            builder.ToTable("AREAATUACAO");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Nome).HasColumnName("NOME").HasMaxLength(50).IsRequired();
            builder.Property(e => e.SetorMercadoId).HasColumnName("SETORMERCADO_ID").IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("ATIVO").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("DATAINCLUSAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("DATAALTERACAO").HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasOne(aa => aa.SetorMercado)
                .WithMany(sm => sm.AreasAtuacao)
                .HasForeignKey(aa => aa.SetorMercadoId);
        }
    }
}