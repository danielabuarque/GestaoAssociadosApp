using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresa");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.CNPJ).HasColumnName("cnpj").HasMaxLength(20).IsRequired();
            builder.HasIndex(e => e.CNPJ).IsUnique();
            builder.Property(e => e.RazaoSocial).HasColumnName("razaosocial").HasMaxLength(250).IsRequired();
            builder.Property(e => e.Logomarca).HasColumnName("logomarca");
            builder.Property(e => e.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("datainclusao").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("dataalteracao").HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasMany(e => e.Enderecos).WithMany(e => e.Empresas).UsingEntity(j => j.ToTable("empresa_endereco"));
        }
    }
}