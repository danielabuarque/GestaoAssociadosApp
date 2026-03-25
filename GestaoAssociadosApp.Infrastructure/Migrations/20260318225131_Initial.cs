using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoAssociadosApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BENEFICIARIO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CPF = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    GRAUPARENTESCO = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    DATANASCIMENTO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PERCENTUAL = table.Column<decimal>(type: "numeric(10,2)", nullable: false),
                    TELEFONE = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BENEFICIARIO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CARGOLIDERANCA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CLASSIFICACAO = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    DATAINICIO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DATAFIM = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    STATUS = table.Column<int>(type: "integer", maxLength: 10, nullable: true),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CARGOLIDERANCA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONTATOEMERGENCIA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    GRAURELACIONAMENTO = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    TELEFONEPRINCIPAL = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    TELEFONESECUNDARIO = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTATOEMERGENCIA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EMPRESA",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    CNPJ = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    RAZAOSOCIAL = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    LOGOMARCA = table.Column<byte[]>(type: "bytea", nullable: true),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPRESA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ENDERECO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    RUA = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    NUMERO = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    BAIRRO = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CIDADE = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ESTADO = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    CEP = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EQUIPE",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    DATAINICIOFORMACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATAPREVISAOLANCAMENTO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATAEFETIVALANCAMENTO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DIAREUNIAO = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    HORAREUNIAO = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    MODELOREUNIAO = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    LOCALREUNIAO = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    LINKREUNIAO = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EQUIPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GRUPAMENTO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SIGLA = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRUPAMENTO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SETORMERCADO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SETORMERCADO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EMPRESA_ENDERECO",
                columns: table => new
                {
                    EmpresasId = table.Column<Guid>(type: "uuid", nullable: false),
                    EnderecosId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPRESA_ENDERECO", x => new { x.EmpresasId, x.EnderecosId });
                    table.ForeignKey(
                        name: "FK_EMPRESA_ENDERECO_EMPRESA_EmpresasId",
                        column: x => x.EmpresasId,
                        principalTable: "EMPRESA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EMPRESA_ENDERECO_ENDERECO_EnderecosId",
                        column: x => x.EnderecosId,
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AREAATUACAO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SETORMERCADO_ID = table.Column<Guid>(type: "uuid", nullable: false),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AREAATUACAO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AREAATUACAO_SETORMERCADO_SETORMERCADO_ID",
                        column: x => x.SETORMERCADO_ID,
                        principalTable: "SETORMERCADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASSOCIADO",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NOME = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CPF = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    DATANASCIMENTO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EMAIL = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TELEFONE = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    DATAPAGTOPRIMEIRAANUIDADE = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DATAINGRESSO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DATAVENCIMENTO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PADRINHO_ID = table.Column<Guid>(type: "uuid", nullable: false),
                    STATUS = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    SETORMERCADO_ID = table.Column<Guid>(type: "uuid", nullable: false),
                    AREAATUACAO_ID = table.Column<Guid>(type: "uuid", nullable: false),
                    NACIONALIDADE = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    RGNUMERO = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    RGORGAOEMISSOR = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    RGUF = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    ESTADOCIVIL = table.Column<int>(type: "integer", maxLength: 15, nullable: false),
                    PROFISSAO = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CONTATOEMERGENCIA_ID = table.Column<Guid>(type: "uuid", nullable: false),
                    ATIVO = table.Column<bool>(type: "boolean", nullable: false, defaultValue: true),
                    DATAINCLUSAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    DATAALTERACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    FOTO = table.Column<byte[]>(type: "bytea", nullable: false),
                    NOMEPROFISSIONAL = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    SITE = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    REDESOCIALLINKEDIN = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    REDESOCIALINSTAGRAM = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    REDESOCIALYOUTUBE = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    REDESOCIALOUTROS = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    PUBLICOIDEAL = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    PRINCIPAISPROBLEMAS = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    CONEXOESESTRATEGICAS = table.Column<string>(name: "CONEXOESESTRATEGICAS   ", type: "character varying(150)", maxLength: 150, nullable: true),
                    INTERESSESPESSOAIS = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSOCIADO", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_AREAATUACAO_AREAATUACAO_ID",
                        column: x => x.AREAATUACAO_ID,
                        principalTable: "AREAATUACAO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_ASSOCIADO_PADRINHO_ID",
                        column: x => x.PADRINHO_ID,
                        principalTable: "ASSOCIADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_CONTATOEMERGENCIA_CONTATOEMERGENCIA_ID",
                        column: x => x.CONTATOEMERGENCIA_ID,
                        principalTable: "CONTATOEMERGENCIA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_SETORMERCADO_SETORMERCADO_ID",
                        column: x => x.SETORMERCADO_ID,
                        principalTable: "SETORMERCADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASSOCIADO_BENEFICIARIO",
                columns: table => new
                {
                    AssociadosId = table.Column<Guid>(type: "uuid", nullable: false),
                    BeneficiariosId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSOCIADO_BENEFICIARIO", x => new { x.AssociadosId, x.BeneficiariosId });
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_BENEFICIARIO_ASSOCIADO_AssociadosId",
                        column: x => x.AssociadosId,
                        principalTable: "ASSOCIADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_BENEFICIARIO_BENEFICIARIO_BeneficiariosId",
                        column: x => x.BeneficiariosId,
                        principalTable: "BENEFICIARIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASSOCIADO_CARGOLIDERANCA",
                columns: table => new
                {
                    AssociadosId = table.Column<Guid>(type: "uuid", nullable: false),
                    CargosLiderancaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSOCIADO_CARGOLIDERANCA", x => new { x.AssociadosId, x.CargosLiderancaId });
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_CARGOLIDERANCA_ASSOCIADO_AssociadosId",
                        column: x => x.AssociadosId,
                        principalTable: "ASSOCIADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_CARGOLIDERANCA_CARGOLIDERANCA_CargosLiderancaId",
                        column: x => x.CargosLiderancaId,
                        principalTable: "CARGOLIDERANCA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASSOCIADO_EMPRESA",
                columns: table => new
                {
                    AssociadosId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmpresasId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSOCIADO_EMPRESA", x => new { x.AssociadosId, x.EmpresasId });
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_EMPRESA_ASSOCIADO_AssociadosId",
                        column: x => x.AssociadosId,
                        principalTable: "ASSOCIADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_EMPRESA_EMPRESA_EmpresasId",
                        column: x => x.EmpresasId,
                        principalTable: "EMPRESA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASSOCIADO_ENDERECO",
                columns: table => new
                {
                    AssociadosId = table.Column<Guid>(type: "uuid", nullable: false),
                    EnderecosId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSOCIADO_ENDERECO", x => new { x.AssociadosId, x.EnderecosId });
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_ENDERECO_ASSOCIADO_AssociadosId",
                        column: x => x.AssociadosId,
                        principalTable: "ASSOCIADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_ENDERECO_ENDERECO_EnderecosId",
                        column: x => x.EnderecosId,
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASSOCIADO_EQUIPE",
                columns: table => new
                {
                    ASSOCIADO_ID = table.Column<Guid>(type: "uuid", nullable: false),
                    EQUIPE_ID = table.Column<Guid>(type: "uuid", nullable: false),
                    ORIGEMASSOCIADO = table.Column<int>(type: "integer", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSOCIADO_EQUIPE", x => new { x.ASSOCIADO_ID, x.EQUIPE_ID });
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_EQUIPE_ASSOCIADO_ASSOCIADO_ID",
                        column: x => x.ASSOCIADO_ID,
                        principalTable: "ASSOCIADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_EQUIPE_EQUIPE_EQUIPE_ID",
                        column: x => x.EQUIPE_ID,
                        principalTable: "EQUIPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ASSOCIADO_GRUPAMENTO",
                columns: table => new
                {
                    AssociadosId = table.Column<Guid>(type: "uuid", nullable: false),
                    GrupamentosId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSOCIADO_GRUPAMENTO", x => new { x.AssociadosId, x.GrupamentosId });
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_GRUPAMENTO_ASSOCIADO_AssociadosId",
                        column: x => x.AssociadosId,
                        principalTable: "ASSOCIADO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ASSOCIADO_GRUPAMENTO_GRUPAMENTO_GrupamentosId",
                        column: x => x.GrupamentosId,
                        principalTable: "GRUPAMENTO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AREAATUACAO_SETORMERCADO_ID",
                table: "AREAATUACAO",
                column: "SETORMERCADO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_AREAATUACAO_ID",
                table: "ASSOCIADO",
                column: "AREAATUACAO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_CONTATOEMERGENCIA_ID",
                table: "ASSOCIADO",
                column: "CONTATOEMERGENCIA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_CPF",
                table: "ASSOCIADO",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_EMAIL",
                table: "ASSOCIADO",
                column: "EMAIL",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_PADRINHO_ID",
                table: "ASSOCIADO",
                column: "PADRINHO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_SETORMERCADO_ID",
                table: "ASSOCIADO",
                column: "SETORMERCADO_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_BENEFICIARIO_BeneficiariosId",
                table: "ASSOCIADO_BENEFICIARIO",
                column: "BeneficiariosId");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_CARGOLIDERANCA_CargosLiderancaId",
                table: "ASSOCIADO_CARGOLIDERANCA",
                column: "CargosLiderancaId");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_EMPRESA_EmpresasId",
                table: "ASSOCIADO_EMPRESA",
                column: "EmpresasId");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_ENDERECO_EnderecosId",
                table: "ASSOCIADO_ENDERECO",
                column: "EnderecosId");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_EQUIPE_EQUIPE_ID",
                table: "ASSOCIADO_EQUIPE",
                column: "EQUIPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ASSOCIADO_GRUPAMENTO_GrupamentosId",
                table: "ASSOCIADO_GRUPAMENTO",
                column: "GrupamentosId");

            migrationBuilder.CreateIndex(
                name: "IX_BENEFICIARIO_CPF",
                table: "BENEFICIARIO",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EMPRESA_CNPJ",
                table: "EMPRESA",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EMPRESA_ENDERECO_EnderecosId",
                table: "EMPRESA_ENDERECO",
                column: "EnderecosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASSOCIADO_BENEFICIARIO");

            migrationBuilder.DropTable(
                name: "ASSOCIADO_CARGOLIDERANCA");

            migrationBuilder.DropTable(
                name: "ASSOCIADO_EMPRESA");

            migrationBuilder.DropTable(
                name: "ASSOCIADO_ENDERECO");

            migrationBuilder.DropTable(
                name: "ASSOCIADO_EQUIPE");

            migrationBuilder.DropTable(
                name: "ASSOCIADO_GRUPAMENTO");

            migrationBuilder.DropTable(
                name: "EMPRESA_ENDERECO");

            migrationBuilder.DropTable(
                name: "BENEFICIARIO");

            migrationBuilder.DropTable(
                name: "CARGOLIDERANCA");

            migrationBuilder.DropTable(
                name: "EQUIPE");

            migrationBuilder.DropTable(
                name: "ASSOCIADO");

            migrationBuilder.DropTable(
                name: "GRUPAMENTO");

            migrationBuilder.DropTable(
                name: "EMPRESA");

            migrationBuilder.DropTable(
                name: "ENDERECO");

            migrationBuilder.DropTable(
                name: "AREAATUACAO");

            migrationBuilder.DropTable(
                name: "CONTATOEMERGENCIA");

            migrationBuilder.DropTable(
                name: "SETORMERCADO");
        }
    }
}
