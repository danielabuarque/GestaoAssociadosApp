using GestaoAssociadosApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoAssociadosApp.Infrastructure.Mappings
{
    public class AssociadoMap : IEntityTypeConfiguration<Associado>
    {
        public void Configure(EntityTypeBuilder<Associado> builder)
        {
            builder.ToTable("associado");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(e => e.CPF).HasColumnName("cpf").HasMaxLength(11).IsRequired();
            builder.HasIndex(e => e.CPF).IsUnique();
            builder.Property(e => e.DataNascimento).HasColumnName("datanascimento").IsRequired();
            builder.Property(e => e.Email).HasColumnName("email").HasMaxLength(100).IsRequired();
            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(e => e.Telefone).HasColumnName("telefone").HasMaxLength(20).IsRequired();
            builder.Property(e => e.DataPagtoPrimeiraAnuidade).HasColumnName("datapagtoprimeiraanuidade");
            builder.Property(e => e.DataIngresso).HasColumnName("dataingresso").IsRequired();
            builder.Property(e => e.DataVencimento).HasColumnName("datavencimento").IsRequired();
            builder.Property(e => e.PadrinhoId).HasColumnName("padrinho_id");
            builder.Property(e => e.Status).HasColumnName("status").HasMaxLength(50).IsRequired();
            builder.Property(e => e.SetorMercadoId).HasColumnName("setormercado_id").IsRequired();
            builder.Property(e => e.AreaAtuacaoId).HasColumnName("areaatuacao_id").IsRequired();
            builder.Property(e => e.Nacionalidade).HasColumnName("nacionalidade").HasMaxLength(25).IsRequired();
            builder.Property(e => e.RGNumero).HasColumnName("rgnumero").HasMaxLength(15).IsRequired();
            builder.Property(e => e.RGOrgaoEmissor).HasColumnName("rgorgaoemissor").HasMaxLength(25).IsRequired();
            builder.Property(e => e.RGUF).HasColumnName("rguf").HasMaxLength(2).IsRequired();
            builder.Property(e => e.EstadoCivil).HasColumnName("estadocivil").HasMaxLength(15).IsRequired();
            builder.Property(e => e.Profissao).HasColumnName("profissao").HasMaxLength(150).IsRequired();
            builder.Property(e => e.ContatoEmergenciaId).HasColumnName("contatoemergencia_id").IsRequired();
            builder.Property(e => e.Foto).HasColumnName("foto");
            builder.Property(e => e.NomeProfissional).HasColumnName("nomeprofissional").HasMaxLength(25);
            builder.Property(e => e.Site).HasColumnName("site").HasMaxLength(60);
            builder.Property(e => e.RedeSocialLinkedIn).HasColumnName("redesociallinkedin").HasMaxLength(60);
            builder.Property(e => e.RedeSocialInstagram).HasColumnName("redesocialinstagram").HasMaxLength(60);
            builder.Property(e => e.RedeSocialYouTube).HasColumnName("redesocialyoutube").HasMaxLength(60);
            builder.Property(e => e.RedeSocialOutros).HasColumnName("redesocialoutros").HasMaxLength(60);
            builder.Property(e => e.PublicoIdeal).HasColumnName("publicoideal").HasMaxLength(150);
            builder.Property(e => e.PrincipaisProblemas).HasColumnName("principaisproblemas").HasMaxLength(150);
            builder.Property(e => e.ConexoesEstrategicas).HasColumnName("conexoesestrategicas").HasMaxLength(150);
            builder.Property(e => e.InteressesPessoais).HasColumnName("interessespessoais").HasMaxLength(150);
            builder.Property(e => e.Ativo).HasColumnName("ativo").HasDefaultValue(true);
            builder.Property(e => e.DataInclusao).HasColumnName("datainclusao").HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(e => e.DataAlteracao).HasColumnName("dataalteracao").HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasOne(a => a.Padrinho).WithMany().HasForeignKey(a => a.PadrinhoId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.SetorMercado).WithMany(sm => sm.Associados).HasForeignKey(a => a.SetorMercadoId);
            builder.HasOne(a => a.AreaAtuacao).WithMany(aa => aa.Associados).HasForeignKey(a => a.AreaAtuacaoId);
            builder.HasOne(a => a.ContatoEmergencia).WithMany(ce => ce.Associados).HasForeignKey(a => a.ContatoEmergenciaId);

            builder.HasMany(a => a.Enderecos).WithMany(e => e.Associados).UsingEntity(j => j.ToTable("associado_endereco"));
            builder.HasMany(a => a.CargosLideranca).WithMany(cl => cl.Associados).UsingEntity(j => j.ToTable("associado_cargolideranca"));
            builder.HasMany(a => a.Grupamentos).WithMany(g => g.Associados).UsingEntity(j => j.ToTable("associado_grupamento"));
            builder.HasMany(a => a.Beneficiarios).WithMany(b => b.Associados).UsingEntity(j => j.ToTable("associado_beneficiario"));
            builder.HasMany(a => a.Empresas).WithMany(e => e.Associados).UsingEntity(j => j.ToTable("associado_empresa"));
        }
    }
}