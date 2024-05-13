using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.Fluco_de_Caixa
{
    class FluxoDeCaixaDTO
    {
        public int id_fluxocaixa { get; set; }
        public int caixa { get; set; }
        public int id_pedidofornecedor { get; set; }
        public int id_venda { get; set; }

    }
}
