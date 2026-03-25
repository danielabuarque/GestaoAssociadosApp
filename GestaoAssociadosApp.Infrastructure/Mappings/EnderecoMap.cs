using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("ENDERECO");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Rua).HasColumnName("RUA").HasMaxLength(250).IsRequired();
            builder.Property(e => e.Numero).HasColumnName("NUMERO").HasMaxLength(25).IsRequired();
            builder.Property(e => e.Complemento).HasColumnName("COMPLEMENTO").HasMaxLength(150);
            builder.Property(e => e.Bairro).HasColumnName("BAIRRO").HasMaxLength(100).IsRequired();
            builder.Property(e => e.Cidade).HasColumnName("CIDADE").HasMaxLength(100).IsRequired();
            builder.Property(e => e.Estado).HasColumnName("ESTADO").HasMaxLength(2).IsRequired();
            builder.Property(e => e.CEP).HasColumnName("CEP").HasMaxLength(8).IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("ATIVO").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("DATAINCLUSAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("DATAALTERACAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}