using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoAssociadosApp.Domain.Entities
{
    public class Empresa
    {
        #region MyRegion
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CNPJ { get; set; } = string.Empty;
        public string RazaoSocial { get; set; } = string.Empty;
        public byte[]? Logomarca { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;
        #endregion

        #region Relationships
        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Associado> Associados { get; set; }
        #endregion

    }

}
