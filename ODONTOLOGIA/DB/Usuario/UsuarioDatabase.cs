using MySql.Data.MySqlClient;
using ODONTOLOGIA.DB.Base;
using ODONTOLOGIA.DB.Usuário;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.DB.Usuario
{
    class UsuarioDatabase
    {
        public int Salvar(UsuarioDTO dto)
        {
            string script = @"INSERT INTO tb_usuario (ds_cpf, ds_senha)
                                   VALUES (@ds_cpf, @ds_senha)";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_cpf", dto.Cpf));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);
        }


        public UsuarioDTO ConsultarPorCpf(string cpf)
        {
            string script = @"SELECT * FROM tb_usuario WHERE ds_cpf = @ds_cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_cpf", cpf));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            UsuarioDTO dto = null;
            if (reader.Read())
            {
                dto = new UsuarioDTO();

                dto.Id = reader.GetInt32("id_usuario");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Senha = reader.GetString("ds_senha");
            }
            reader.Close();

            return dto;
        }


        public List<UsuarioDTO> Listar()
        {
            string script = @"SELECT * FROM tb_usuario";

            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            while (reader.Read())
            {
                UsuarioDTO dto = new UsuarioDTO();
                dto.Id = reader.GetInt32("id_usuario");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Senha = reader.GetString("ds_senha");


                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
    }
}
