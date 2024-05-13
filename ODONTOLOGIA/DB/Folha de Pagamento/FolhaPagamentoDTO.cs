using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.Folha_de_Pagamento
{
    class FolhaDePagamentoDTO
    {
        public int id_FolhaPagamento { get; set; }
        public int id_Funcionario { get; set; }
        public DateTime DataPagamento { get; set; }
        public double SalarioBase { get; set; }
        public double FGTS { get; set; }
        public double HoraExtra { get; set; }
        public double SalarioFamilia { get; set; }
        public double INSS { get; set; }
        public double IRRF { get; set; }
        public double ValeTransporte { get; set; }
        public double Atrasos { get; set; }
        public double Faltas { get; set; }
        public double DSR { get; set; }
        public double ValorTotal { get; set; }
        public double Diastrabalhados { get; set; }
        public double DomingosTrabalhados { get; set; }
    }
}

