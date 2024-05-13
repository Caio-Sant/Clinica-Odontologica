using MySql.Data.MySqlClient;
using ODONTOLOGIA.DB.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.DB.Funcionario
{
    class FuncionarioDatabase
    {
        public FuncionarioDTO Logar(string login, string senha)
        {
            string script = @"SELECT * FROM tb_permissao WHERE ds_login = @ds_login AND ds_senha = @ds_senha";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_login", login));
            parms.Add(new MySqlParameter("ds_senha", senha));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            FuncionarioDTO funcionario = null;

            if (reader.Read())
            {
                funcionario = new FuncionarioDTO();
                funcionario.Id = reader.GetInt32("id_permissao");
                funcionario.Nome = reader.GetString("nm_permissao");
                funcionario.Login = reader.GetString("ds_login");
                funcionario.PermissaoAdm = reader.GetBoolean("bt_permissao_adm");
            }
            reader.Close();

            return funcionario;
        }
    
        public int Salvar(FuncionarioDTO dto)
        {
            string script = @" INSERT INTO tb_funcionario (nm_funcionario, 
                                ds_numerocasa, ds_telefone, ds_sexo, dt_nascimento, ds_rg, ds_cep, ds_email,
                                        ds_cpf, ds_senha, dt_admissao, ds_cargo, 
                                        bt_permissao_adm, ds_salario)
                           VALUES (@nm_funcionario, @ds_numerocasa, @ds_telefone, @ds_sexo, @dt_nascimento, @ds_rg, @ds_cep, @ds_email, @ds_cpf, 
                        @ds_senha, @dt_admissao, @bt_permissao_adm,  @ds_salario)";
            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_funcionario", dto.Nome));
            parms.Add(new MySqlParameter("ds_numerocasa", dto.NumeroCasa));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_sexo", dto.Sexo));
            parms.Add(new MySqlParameter("dt_nascimento", dto.Nascimento));
            parms.Add(new MySqlParameter("ds_rg", dto.Rg));
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cpf", dto.Cpf));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));
            parms.Add(new MySqlParameter("dt_admissao", dto.Admissao));
            parms.Add(new MySqlParameter("ds_cargo", dto.Cargo));
            parms.Add(new MySqlParameter("bt_permissao_adm", dto.PermissaoAdm));
            parms.Add(new MySqlParameter("ds_salario", dto.Salario));


            Database db = new Database();
            return db.ExecuteInsertScriptWithPk(script, parms);

        }
        public FuncionarioDTO ConsultarPorCpf(string cpf)
        {
            string script = @"SELECT * FROM tb_funcionario WHERE ds_cpf = @ds_cpf";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("ds_cpf", cpf));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            FuncionarioDTO dto = null;
            if (reader.Read())
            {
                dto = new FuncionarioDTO();

                dto.Id = reader.GetInt32("id_funcionario");
                dto.Nome = reader.GetString("nm_funcionario");
                dto.Cep = reader.GetString("ds_cep");
                dto.NumeroCasa = reader.GetString("ds_numerocasa");
                dto.Telefone = reader.GetString("ds_cep");
                dto.Sexo = reader.GetString("ds_sexo");
                dto.Rg = reader.GetString("ds_rg");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Senha = reader.GetString("ds_senha");
                dto.Nascimento = reader.GetDateTime("dt_nascimento");
                dto.Salario = reader.GetInt32("ds_salario");
                dto.Email = reader.GetString("ds_email");
                dto.Cargo = reader.GetString("ds_cargo");
                dto.Admissao = reader.GetDateTime("dt_admissao");
                dto.PermissaoAdm = reader.GetBoolean("bt_permissao_adm");
            }
            reader.Close();

            return dto;
        }

        public void Alterar(FuncionarioDTO dto)
        {
            string script = @"UPDATE tb_funcionario 
                                 SET nm_funcionario  = @nm_funcionario,
                                     ds_cpf = @ds_cpf,
                                     dt_admissao = @dt_admissao,
                                     ds_cep = @ds_cep,
                                     ds_numerocasa = @ds_numerocasa,
                                     ds_cargo = @ds_cargo,
                                     ds_rg = @ds_rg,
                                     ds_senha = @ds_senha,
                                     ds_telefone = @ds_telefone,
                                     ds_email = @ds_email,
                                     dt_nascimento = @dt_nascimento,
                                     ds_sexo = @ds_sexo,
                                     bt_permissao_adm = @bt_Permissao_adm,
                                    
                                     ds_salario = @ds_salario
                                     WHERE id_funcionario = @id_funcionario";


            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", dto.Id));
            parms.Add(new MySqlParameter("nm_funcionario", dto.Nome));
            parms.Add(new MySqlParameter("ds_numerocasa", dto.NumeroCasa));
            parms.Add(new MySqlParameter("ds_telefone", dto.Telefone));
            parms.Add(new MySqlParameter("ds_sexo", dto.Sexo));
            parms.Add(new MySqlParameter("dt_nascimento", dto.Nascimento));
            parms.Add(new MySqlParameter("ds_rg", dto.Rg));
            parms.Add(new MySqlParameter("ds_cep", dto.Cep));
            parms.Add(new MySqlParameter("ds_email", dto.Email));
            parms.Add(new MySqlParameter("ds_cpf", dto.Cpf));
            parms.Add(new MySqlParameter("ds_senha", dto.Senha));
            parms.Add(new MySqlParameter("dt_admissao", dto.Admissao));
            parms.Add(new MySqlParameter("ds_cargo", dto.Cargo));
            parms.Add(new MySqlParameter("bt_permissao_adm", dto.PermissaoAdm));
            parms.Add(new MySqlParameter("ds_salario", dto.Salario));


            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public void Remover(int id)
        {
            string script = @"DELETE FROM tb_funcionario WHERE id_funcionario = @id_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("id_funcionario", id));

            Database db = new Database();
            db.ExecuteInsertScript(script, parms);
        }
        public List<FuncionarioDTO> Consultar(string funcionario)
        {
            string script = @"SELECT * FROM tb_funcionario WHERE nm_funcionario like @nm_funcionario";

            List<MySqlParameter> parms = new List<MySqlParameter>();
            parms.Add(new MySqlParameter("nm_funcionario", funcionario + "%"));

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> lista = new List<FuncionarioDTO>();
            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id = reader.GetInt32("id_funcionario");
                dto.Nome = reader.GetString("nm_funcionario");
                dto.Cep = reader.GetString("ds_cep");
                dto.NumeroCasa = reader.GetString("ds_numerocasa");
                dto.Telefone = reader.GetString("ds_telefone");
                dto.Sexo = reader.GetString("ds_sexo");
                dto.Rg = reader.GetString("ds_rg");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Senha = reader.GetString("ds_senha");
                dto.Nascimento = reader.GetDateTime("dt_nascimento");
                dto.Salario = reader.GetInt32("ds_salario");
                dto.Email = reader.GetString("ds_email");
                dto.Cargo = reader.GetString("ds_cargo");
                dto.Admissao = reader.GetDateTime("dt_admissao");
                dto.PermissaoAdm = reader.GetBoolean("bt_permissao_adm");
               

                lista.Add(dto);
            }
            reader.Close();

            return lista;
        }
        public List<FuncionarioDTO> Listar()
        {

            string script = "select * from tb_funcionario";
            List<MySqlParameter> parms = new List<MySqlParameter>();

            Database db = new Database();
            MySqlDataReader reader = db.ExecuteSelectScript(script, parms);

            List<FuncionarioDTO> listar = new List<FuncionarioDTO>();

            while (reader.Read())
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.Id = reader.GetInt32("id_funcionario");
                dto.Nome = reader.GetString("nm_funcionario");
                dto.Cep = reader.GetString("ds_cep");
                dto.NumeroCasa = reader.GetString("ds_numerocasa");
                dto.Telefone = reader.GetString("ds_cep");
                dto.Sexo = reader.GetString("ds_sexo");
                dto.Rg = reader.GetString("ds_rg");
                dto.Cpf = reader.GetString("ds_cpf");
                dto.Senha = reader.GetString("ds_senha");
                dto.Nascimento = reader.GetDateTime("dt_nascimento");
                dto.Salario = reader.GetInt32("ds_salario");
                dto.Email = reader.GetString("ds_email");
                dto.Admissao = reader.GetDateTime("dt_admissao");
                dto.PermissaoAdm = reader.GetBoolean("bt_permissao_adm");
               


                listar.Add(dto);
            }
            reader.Close();
            return listar;
        }
    }
}
