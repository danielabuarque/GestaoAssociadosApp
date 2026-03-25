using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class AssociadoEquipeMap : IEntityTypeConfiguration<AssociadoEquipe>
    {
        public void Configure(EntityTypeBuilder<AssociadoEquipe> builder)
        {
            builder.ToTable("ASSOCIADO_EQUIPE");

            builder.HasKey(ae => new { ae.AssociadoId, ae.EquipeId });

            builder.Property(e => e.AssociadoId).HasColumnName("ASSOCIADO_ID");
            builder.Property(e => e.EquipeId).HasColumnName("EQUIPE_ID");
            builder.Property(e => e.OrigemAssociado).HasColumnName("ORIGEMASSOCIADO").HasMaxLength(15).IsRequired();

            builder.HasOne(ae => ae.Associado).WithMany(a => a.AssociadoEquipes).HasForeignKey(ae => ae.AssociadoId);
            builder.HasOne(ae => ae.Equipe).WithMany(e => e.AssociadoEquipes).HasForeignKey(ae => ae.EquipeId);
        }
    }
}