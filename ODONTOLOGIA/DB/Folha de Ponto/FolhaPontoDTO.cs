using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.Folha_de_pontos
{
    class FolhaDepontoDTO
    {
        public int id_folhadeponto { get; set; }
        public DateTime chegada { get; set; }
        public DateTime almoco { get; set; }
        public DateTime chegadaalmoco { get; set; }
        public DateTime saida { get; set; }
        public DateTime horas { get; set; }
    }
}
