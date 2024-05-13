using MySql.Data.MySqlClient;
using ODONTOLOGIA.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.Folha_de_Pagamento
{
    class FolhaDePagamentoDatabase
    {
        public int Salvar(FolhaDePagamentoDTO dto)
        {
            string script = @" INSERT INTO tb_folhapagamento (id_funcionario, vl_total, dt_pagamento, vl_salariobase, qtd_horaextra, vl_salariofamilia, vl_inss, vl_irrf, vl_valetransporte, 
                                 qtd_faltas, qtd_atrasos, vl_fgts, vl_dsr, vl_diastra, vl_domintra) VALUES 
                                  (@id_funcionario, @vl_total, @dt_pagamento, @vl_salariobase, @qtd_horaextra, @vl_salariofamilia, @vl_inss, @vl_irrf, 
                                       @vl_valetransporte, @qtd_faltas, @qtd_atrasos, @vl_fgts, @vl_dsr, @vl_diastra , @vl_domintra) ";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", dto.id_Funcionario));
            parms.Add(new MySqlParameter("dt_pagamento", dto.DataPagamento));
            parms.Add(new MySqlParameter("vl_salariobase", dto.SalarioBase));
            parms.Add(new MySqlParameter("vl_fgts", dto.FGTS));
            parms.Add(new MySqlParameter("vl_total", dto.ValorTotal));
            parms.Add(new MySqlParameter("qtd_horaextra", dto.HoraExtra));
            parms.Add(new MySqlParameter("vl_salariofamilia", dto.SalarioFamilia));
            parms.Add(new MySqlParameter("vl_dsr", dto.DSR));
            parms.Add(new MySqlParameter("vl_inss", dto.INSS));
            parms.Add(new MySqlParameter("vl_irrf", dto.IRRF));
            parms.Add(new MySqlParameter("vl_valetransporte", dto.ValeTransporte));
            parms.Add(new MySqlParameter("qtd_atrasos", dto.Atrasos));
            parms.Add(new MySqlParameter("qtd_faltas", dto.Faltas));
            parms.Add(new MySqlParameter("vl_diastra", dto.Diastrabalhados));
            parms.Add(new MySqlParameter("vl_domintra", dto.DomingosTrabalhados));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }


        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_folhapagamento WHERE id_folhapagamento = @id_folhapagamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folhapagamento", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }


        public List<FolhaDePagamentoDTO> Consultar(string folhapagamento)
        {
            string script = @"SELECT * FROM tb_folhapagamento WHERE id_folhapagamento like @id_folhapagamento";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_folhapagamento", folhapagamento + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FolhaDePagamentoDTO> lista = new List<FolhaDePagamentoDTO>();
            while (reader.Read())
            {
                FolhaDePagamentoDTO dto = new FolhaDePagamentoDTO();
                dto.id_FolhaPagamento = reader.GetInt32("id_folhapagamento");
                dto.id_Funcionario = reader.GetInt32("id_funcionario");
                dto.DataPagamento = reader.GetDateTime("dt_pagamento");
                dto.ValorTotal = reader.GetDouble("vl_total");
                dto.HoraExtra = reader.GetInt32("qtd_horaextra");
                dto.SalarioFamilia = reader.GetDouble("vl_salariofamilia");
                dto.DSR = reader.GetDouble("vl_dsr");
                dto.INSS = reader.GetDouble("vl_inss");
                dto.IRRF = reader.GetDouble("vl_irrf");
                dto.Atrasos = reader.GetInt32("qtd_atrasos");
                dto.Faltas = reader.GetInt32("qtd_faltas");
                dto.ValeTransporte = reader.GetDouble("vl_valetransporte");
                dto.FGTS = reader.GetDouble("vl_fgts");
                dto.SalarioBase = reader.GetDouble("vl_salariobase");
                dto.DomingosTrabalhados = reader.GetDouble("vl_domintra");
                dto.Diastrabalhados = reader.GetDouble("vl_diastra");

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}