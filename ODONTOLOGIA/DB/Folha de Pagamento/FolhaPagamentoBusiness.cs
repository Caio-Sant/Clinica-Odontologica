using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.Folha_de_Pagamento
{
    class FolhaDePagamentoBussenis
    {
        public int Salvar(FolhaDePagamentoDTO dto)
        {

            FolhaDePagamentoDatabase db = new FolhaDePagamentoDatabase();
            return db.Salvar(dto);
        }


        public List<FolhaDePagamentoDTO> Consultar(string folhadepagamento)
        {
            FolhaDePagamentoDatabase db = new FolhaDePagamentoDatabase();
            return db.Consultar(folhadepagamento);
        }
    }
}