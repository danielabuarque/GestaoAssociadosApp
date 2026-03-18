using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class EquipeMap : IEntityTypeConfiguration<Equipe>
    {
        public void Configure(EntityTypeBuilder<Equipe> builder)
        {
            builder.ToTable("equipe");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(e => e.DataInicioFormacao).HasColumnName("datainicioformacao").IsRequired();
            builder.Property(e => e.DataPrevisaoLancamento).HasColumnName("dataprevisaolancamento").IsRequired();
            builder.Property(e => e.DataEfetivaLancamento).HasColumnName("dataefetivalancamento").IsRequired();
            builder.Property(e => e.DiaReuniao).HasColumnName("diareuniao").HasMaxLength(25).IsRequired();
            builder.Property(e => e.HoraReuniao).HasColumnName("horareuniao").HasMaxLength(25).IsRequired();
            builder.Property(e => e.ModeloReuniao).HasColumnName("modeloreuniao").HasMaxLength(25).IsRequired();
            builder.Property(e => e.LocalReuniao).HasColumnName("localreuniao").HasMaxLength(150).IsRequired();
            builder.Property(e => e.LinkReuniao).HasColumnName("linkreuniao").HasMaxLength(250).IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("datainclusao").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("dataalteracao").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}