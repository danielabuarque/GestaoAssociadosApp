using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class AssociadoEquipeMap : IEntityTypeConfiguration<AssociadoEquipe>
    {
        public void Configure(EntityTypeBuilder<AssociadoEquipe> builder)
        {
            builder.ToTable("associado_equipe");

            builder.HasKey(ae => new { ae.AssociadoId, ae.EquipeId });

            builder.Property(e => e.AssociadoId).HasColumnName("associado_id");
            builder.Property(e => e.EquipeId).HasColumnName("equipe_id");
            builder.Property(e => e.OrigemAssociado).HasColumnName("origemassociado").HasMaxLength(15).IsRequired();

            builder.HasOne(ae => ae.Associado).WithMany(a => a.AssociadoEquipes).HasForeignKey(ae => ae.AssociadoId);
            builder.HasOne(ae => ae.Equipe).WithMany(e => e.AssociadoEquipes).HasForeignKey(ae => ae.EquipeId);
        }
    }
}