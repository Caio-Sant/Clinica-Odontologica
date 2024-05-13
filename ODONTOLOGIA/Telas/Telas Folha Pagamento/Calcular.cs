using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.Telas.Telas_Folha_Pagamento
{
    class Calcular
    {
        public double CalcularSH(double SalarioBase)
        {
            double SH = SalarioBase / 220;
            return SH;
        }
        public double CalcularHE(double SH, double percentual, double quantidade)
        {
            double SalarioHora = SH;
            double ValorHE = SH * (percentual / 100.0);
            double HE = (ValorHE + SH) * quantidade;
            return HE;
        }
        public double CalcularDsr(double DiasT, double DominT, double HE)
        {
            double HoraExtra = HE;
            double Conta1 = HoraExtra / DiasT * DominT;
            return Conta1;
        }
        public double CalcularAtrasos(double Horas, double QtdHorasAtrasadas)
        {
            double SalarioHora = Horas;
            double Atraso = SalarioHora * QtdHorasAtrasadas;
            return Atraso;
        
        }
        public double CalcularFaltas(double SalarioBase, double QtdFaltas, double QtdDomingos)
        {
            double SalarioDia = SalarioBase / 30;
            double Faltas = QtdFaltas + QtdDomingos;
            double Desc = SalarioDia * Faltas;
            return Desc;
        }

        public double CalcularINSS(double SalarioBase, double HE, double Conta1, double Desc, double Atraso)
        {
            double BaseINSS = (SalarioBase + HE + Conta1) - (Desc + Atraso);
            if (BaseINSS <= 1659.38)
            {
                double INSS1 = BaseINSS * (8 / 100.0);
                return INSS1;
                
            }
            else if (BaseINSS >= 1659.39 && BaseINSS <= 2365.66)
            {
                double INSS2 = BaseINSS * (9 / 100.0);
                return INSS2;
            }
            else 
            {
                double INSS3 = BaseINSS * (11 / 100.0);
                return INSS3;


            }
        }
        public double CalcularFGTS(double BaseINSS)
        {
            double FGTS = BaseINSS * (8 / 100.0);
            return FGTS;
            
        }
        public double CalcularVT(double SalarioBase)
        {
            double VT = SalarioBase * (6 / 100.0);
            return VT;
        }
        public double CalcularSF(double SalarioBase, double QuantDeMenor)
        {
            if (SalarioBase > 1319.18)
            {
                double SF = 0;
                return SF;
            }
            else
            {
               double SF = QuantDeMenor * 31.71;
               return SF;
            }

            
        }
        public double CalcularTotal(double SalarioBase, double HE, double DSR, double Desc, double Atraso, double INSS, double VT, double SalarioFamilia)
        {
            double Total = (SalarioBase + HE + DSR + SalarioFamilia) - (Desc + Atraso + INSS + VT);
            return Total;
        }
    }
}
