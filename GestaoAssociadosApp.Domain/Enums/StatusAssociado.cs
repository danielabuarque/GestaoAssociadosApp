using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAssociadosApp.Domain.Enums
{
    public enum StatusAssociado
    {
        PreAtivo,
        Ativo,
        InativoPausaProgramada,
        InativoDesistencia,
        InativoFalecimento,
        InativoDesligado,
        InativoOutro
    }
}
