using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class BeneficiarioMap : IEntityTypeConfiguration<Beneficiario>
    {
        public void Configure(EntityTypeBuilder<Beneficiario> builder)
        {
            builder.ToTable("BENEFICIARIO");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Nome).HasColumnName("NOME").HasMaxLength(150).IsRequired();
            builder.Property(e => e.CPF).HasColumnName("CPF").HasMaxLength(11).IsRequired();
            builder.HasIndex(e => e.CPF).IsUnique();
            builder.Property(e => e.GrauParentesco).HasColumnName("GRAUPARENTESCO").HasMaxLength(25).IsRequired();
            builder.Property(e => e.DataNascimento).HasColumnName("DATANASCIMENTO").IsRequired();
            builder.Property(e => e.Percentual).HasColumnName("PERCENTUAL").HasColumnType("decimal(10, 2)").IsRequired();
            builder.Property(e => e.Telefone).HasColumnName("TELEFONE").HasMaxLength(20).IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("ATIVO").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("DATAINCLUSAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("DATAALTERACAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}