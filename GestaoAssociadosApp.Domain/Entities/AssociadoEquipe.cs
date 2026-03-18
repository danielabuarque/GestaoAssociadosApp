using GestaoAssociadosApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoAssociadosApp.Domain.Entities
{
    public class AssociadoEquipe
    {
        #region Properties
        public Guid AssociadoId { get; set; }
        public Guid EquipeId { get; set; }
        public OrigemAssociado OrigemAssociado { get; set; }
        #endregion

        #region Relationships
        public Associado Associado { get; set; }
        public Equipe Equipe { get; set; }

        #endregion

    }
}
