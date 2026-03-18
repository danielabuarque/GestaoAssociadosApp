using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoAssociadosApp.Domain.Entities
{
    public class Beneficiario
    {
        #region Properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string GrauParentesco { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public decimal Percentual { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        #endregion

        #region Relationships
        public ICollection<Associado> Associados { get; set; }
        #endregion
    }
}

