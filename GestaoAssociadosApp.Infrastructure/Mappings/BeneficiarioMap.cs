using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class BeneficiarioMap : IEntityTypeConfiguration<Beneficiario>
    {
        public void Configure(EntityTypeBuilder<Beneficiario> builder)
        {
            builder.ToTable("beneficiario");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(e => e.CPF).HasColumnName("cpf").HasMaxLength(11).IsRequired();
            builder.HasIndex(e => e.CPF).IsUnique();
            builder.Property(e => e.GrauParentesco).HasColumnName("grauparentesco").HasMaxLength(25).IsRequired();
            builder.Property(e => e.DataNascimento).HasColumnName("datanascimento").IsRequired();
            builder.Property(e => e.Percentual).HasColumnName("percentual").HasColumnType("decimal(10, 2)").IsRequired();
            builder.Property(e => e.Telefone).HasColumnName("telefone").HasMaxLength(20).IsRequired();
            builder.Property(e => e.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("datainclusao").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("dataalteracao").HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}