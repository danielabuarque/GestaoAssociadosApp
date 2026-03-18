using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAssociadosApp.Domain.Entities
{
    public class SetorMercado
    {
        #region Properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public bool Ativo { get; set; } = true;
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { get; set; } = DateTime.Now;

        #endregion

        #region Relationships
        public ICollection<AreaAtuacao> AreasAtuacao { get; set; }
        public ICollection<Associado> Associados { get; set; }
        #endregion

    }
}
