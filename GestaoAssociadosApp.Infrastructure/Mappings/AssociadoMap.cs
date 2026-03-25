using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class AssociadoMap : IEntityTypeConfiguration<Associado>
    {
        public void Configure(EntityTypeBuilder<Associado> builder)
        {
            builder.ToTable("ASSOCIADO");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("ID");
            builder.Property(e => e.Nome).HasColumnName("NOME").HasMaxLength(150).IsRequired();
            builder.Property(e => e.CPF).HasColumnName("CPF").HasMaxLength(11).IsRequired();
            builder.HasIndex(e => e.CPF).IsUnique();
            builder.Property(e => e.DataNascimento).HasColumnName("DATANASCIMENTO").IsRequired();
            builder.Property(e => e.Email).HasColumnName("EMAIL").HasMaxLength(100).IsRequired();
            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(e => e.Telefone).HasColumnName("TELEFONE").HasMaxLength(20).IsRequired();
            builder.Property(e => e.DataPagtoPrimeiraAnuidade).HasColumnName("DATAPAGTOPRIMEIRAANUIDADE");
            builder.Property(e => e.DataIngresso).HasColumnName("DATAINGRESSO").IsRequired();
            builder.Property(e => e.DataVencimento).HasColumnName("DATAVENCIMENTO").IsRequired();
            builder.Property(e => e.PadrinhoId).HasColumnName("PADRINHO_ID");
            builder.Property(e => e.Status).HasColumnName("STATUS").HasMaxLength(50).IsRequired();
            builder.Property(e => e.SetorMercadoId).HasColumnName("SETORMERCADO_ID").IsRequired();
            builder.Property(e => e.AreaAtuacaoId).HasColumnName("AREAATUACAO_ID").IsRequired();
            builder.Property(e => e.Nacionalidade).HasColumnName("NACIONALIDADE").HasMaxLength(25).IsRequired();
            builder.Property(e => e.RGNumero).HasColumnName("RGNUMERO").HasMaxLength(15).IsRequired();
            builder.Property(e => e.RGOrgaoEmissor).HasColumnName("RGORGAOEMISSOR").HasMaxLength(25).IsRequired();
            builder.Property(e => e.RGUF).HasColumnName("RGUF").HasMaxLength(2).IsRequired();
            builder.Property(e => e.EstadoCivil).HasColumnName("ESTADOCIVIL").HasMaxLength(15).IsRequired();
            builder.Property(e => e.Profissao).HasColumnName("PROFISSAO").HasMaxLength(150).IsRequired();
            builder.Property(e => e.ContatoEmergenciaId).HasColumnName("CONTATOEMERGENCIA_ID").IsRequired();
            builder.Property(e => e.Foto).HasColumnName("FOTO");
            builder.Property(e => e.NomeProfissional).HasColumnName("NOMEPROFISSIONAL").HasMaxLength(25);
            builder.Property(e => e.Site).HasColumnName("SITE").HasMaxLength(60);
            builder.Property(e => e.RedeSocialLinkedIn).HasColumnName("REDESOCIALLINKEDIN").HasMaxLength(60);
            builder.Property(e => e.RedeSocialInstagram).HasColumnName("REDESOCIALINSTAGRAM").HasMaxLength(60);
            builder.Property(e => e.RedeSocialYouTube).HasColumnName("REDESOCIALYOUTUBE").HasMaxLength(60);
            builder.Property(e => e.RedeSocialOutros).HasColumnName("REDESOCIALOUTROS").HasMaxLength(60);
            builder.Property(e => e.PublicoIdeal).HasColumnName("PUBLICOIDEAL").HasMaxLength(150);
            builder.Property(e => e.PrincipaisProblemas).HasColumnName("PRINCIPAISPROBLEMAS").HasMaxLength(150);
            builder.Property(e => e.ConexoesEstrategicas).HasColumnName("CONEXOESESTRATEGICAS   ").HasMaxLength(150);
            builder.Property(e => e.InteressesPessoais).HasColumnName("INTERESSESPESSOAIS").HasMaxLength(150);
            builder.Property(e => e.Ativo).HasColumnName("ATIVO").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("DATAINCLUSAO").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("DATAALTERACAO").HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasOne(a => a.Padrinho).WithMany().HasForeignKey(a => a.PadrinhoId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.SetorMercado).WithMany(sm => sm.Associados).HasForeignKey(a => a.SetorMercadoId);
            builder.HasOne(a => a.AreaAtuacao).WithMany(aa => aa.Associados).HasForeignKey(a => a.AreaAtuacaoId);
            builder.HasOne(a => a.ContatoEmergencia).WithMany(ce => ce.Associados).HasForeignKey(a => a.ContatoEmergenciaId);

            builder.HasMany(a => a.Enderecos).WithMany(e => e.Associados).UsingEntity(j => j.ToTable("ASSOCIADO_ENDERECO"));
            builder.HasMany(a => a.CargosLideranca).WithMany(cl => cl.Associados).UsingEntity(j => j.ToTable("ASSOCIADO_CARGOLIDERANCA"));
            builder.HasMany(a => a.Grupamentos).WithMany(g => g.Associados).UsingEntity(j => j.ToTable("ASSOCIADO_GRUPAMENTO"));
            builder.HasMany(a => a.Beneficiarios).WithMany(b => b.Associados).UsingEntity(j => j.ToTable("ASSOCIADO_BENEFICIARIO"));
            builder.HasMany(a => a.Empresas).WithMany(e => e.Associados).UsingEntity(j => j.ToTable("ASSOCIADO_EMPRESA"));
        }
    }
}