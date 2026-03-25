using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class ContatoEmergenciaMap : IEntityTypeConfiguration<ContatoEmergencia>
    {
        public void Configure(EntityTypeBuilder<ContatoEmergencia> builder)
        {
            builder.ToTable("CONTATOEMERGENCIA");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Nome).HasColumnName("NOME").HasMaxLength(150).IsRequired();
            builder.Property(e => e.GrauRelacionamento).HasColumnName("GRAURELACIONAMENTO").HasMaxLength(150).IsRequired();
            builder.Property(e => e.TelefonePrincipal).HasColumnName("TELEFONEPRINCIPAL").HasMaxLength(20).IsRequired();
            builder.Property(e => e.TelefoneSecundario).HasColumnName("TELEFONESECUNDARIO").HasMaxLength(20);
            builder.Property(e => e.Ativo).HasColumnName("ATIVO").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("DATAINCLUSAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("DATAALTERACAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}