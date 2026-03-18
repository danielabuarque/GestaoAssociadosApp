using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class ContatoEmergenciaMap : IEntityTypeConfiguration<ContatoEmergencia>
    {
        public void Configure(EntityTypeBuilder<ContatoEmergencia> builder)
        {
            builder.ToTable("contatoemergencia");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(e => e.GrauRelacionamento).HasColumnName("graurelacionamento").HasMaxLength(150).IsRequired();
            builder.Property(e => e.TelefonePrincipal).HasColumnName("telefoneprincipal").HasMaxLength(20).IsRequired();
            builder.Property(e => e.TelefoneSecundario).HasColumnName("telefonesecundario").HasMaxLength(20);
            builder.Property(e => e.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("datainclusao").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("dataalteracao").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}