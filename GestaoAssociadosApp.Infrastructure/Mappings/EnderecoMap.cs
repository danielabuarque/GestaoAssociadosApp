using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Rua).HasColumnName("rua").HasMaxLength(250).IsRequired();
            builder.Property(e => e.Numero).HasColumnName("numero").HasMaxLength(25).IsRequired();
            builder.Property(e => e.Complemento).HasColumnName("complemento").HasMaxLength(150);
            builder.Property(e => e.Bairro).HasColumnName("bairro").HasMaxLength(100).IsRequired();
            builder.Property(e => e.Cidade).HasColumnName("cidade").HasMaxLength(100).IsRequired();
            builder.Property(e => e.Estado).HasColumnName("estado").HasMaxLength(2).IsRequired();
            builder.Property(e => e.CEP).HasColumnName("cep").HasMaxLength(8).IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("datainclusao").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("dataalteracao").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}