using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class AreaAtuacaoMap : IEntityTypeConfiguration<AreaAtuacao>
    {
        public void Configure(EntityTypeBuilder<AreaAtuacao> builder)
        {
            builder.ToTable("areaatuacao");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
            builder.Property(e => e.SetorMercadoId).HasColumnName("setormercado_id").IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("datainclusao").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("dataalteracao").HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasOne(aa => aa.SetorMercado).WithMany(sm => sm.AreasAtuacao).HasForeignKey(aa => aa.SetorMercadoId);
        }
    }
}