using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("EMPRESA");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.CNPJ).HasColumnName("CNPJ").HasMaxLength(20).IsRequired();
            builder.HasIndex(e => e.CNPJ).IsUnique();
            builder.Property(e => e.RazaoSocial).HasColumnName("RAZAOSOCIAL").HasMaxLength(250).IsRequired();
            builder.Property(e => e.Logomarca).HasColumnName("LOGOMARCA");
            builder.Property(e => e.Ativo).HasColumnName("ATIVO").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("DATAINCLUSAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("DATAALTERACAO").HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasMany(e => e.Enderecos).WithMany(e => e.Empresas).UsingEntity(j => j.ToTable("EMPRESA_ENDERECO"));
        }
    }
}