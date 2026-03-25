using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class EquipeMap : IEntityTypeConfiguration<Equipe>
    {
        public void Configure(EntityTypeBuilder<Equipe> builder)
        {
            builder.ToTable("EQUIPE");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Nome).HasColumnName("NOME").HasMaxLength(150).IsRequired();
            builder.Property(e => e.DataInicioFormacao).HasColumnName("DATAINICIOFORMACAO").IsRequired();
            builder.Property(e => e.DataPrevisaoLancamento).HasColumnName("DATAPREVISAOLANCAMENTO").IsRequired();
            builder.Property(e => e.DataEfetivaLancamento).HasColumnName("DATAEFETIVALANCAMENTO").IsRequired();
            builder.Property(e => e.DiaReuniao).HasColumnName("DIAREUNIAO").HasMaxLength(25).IsRequired();
            builder.Property(e => e.HoraReuniao).HasColumnName("HORAREUNIAO").HasMaxLength(25).IsRequired();
            builder.Property(e => e.ModeloReuniao).HasColumnName("MODELOREUNIAO").HasMaxLength(25).IsRequired();
            builder.Property(e => e.LocalReuniao).HasColumnName("LOCALREUNIAO").HasMaxLength(150).IsRequired();
            builder.Property(e => e.LinkReuniao).HasColumnName("LINKREUNIAO").HasMaxLength(250).IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("ATIVO").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("DATAINCLUSAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("DATAALTERACAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}