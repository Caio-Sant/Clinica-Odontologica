using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.DB.Funcionario
{
    class FuncionarioBusiness
    {
        public int Salvar(FuncionarioDTO dto)
        {

            FuncionarioDTO cliente = this.ConsultarPorCpf(dto.Cpf);

            if (dto.Nome == string.Empty)
            {
                throw new ArgumentException("Nome é obrigatório");
            }

            if (dto.Cep == string.Empty)
            {
                throw new ArgumentException("Cep é obrigatório");
            }

            if (dto.Cpf == string.Empty)
            {
                throw new ArgumentException("Cpf já cadastrado no sistema.");
            }

            if (dto.NumeroCasa == string.Empty)
            {
                throw new ArgumentException("Numero da casa é obrigatório");
            }

            if (dto.Email == string.Empty)
            {
                throw new ArgumentException("E-mail é obrigatório");
            }

            if (dto.Cargo == string.Empty)
            {
                throw new ArgumentException("Cargo é obrigatório");
            }

            if (dto.Salario < 954)
            {
                throw new ArgumentException("Esse valor deve ser maior que um salário minímo");
            }

            if (dto.Sexo == string.Empty)
            {
                throw new ArgumentException("Sexo é obrigatório");
            }

            if (dto.Telefone == string.Empty)
            {
                throw new ArgumentException("Telefone é obrigatório");
            }

            if (dto.Rg == string.Empty)
            {
                throw new ArgumentException("Rg é obrigatório");
            }

            if (dto.Senha == string.Empty)
            {
                throw new ArgumentException("Você precisa da senha para logar no sistema");
            }

            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Salvar(dto);
        }
        public FuncionarioDTO ConsultarPorCpf(string cpf)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarPorCpf(cpf);
        }

        public List<FuncionarioDTO> Listar()
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Listar();
        }
        public FuncionarioDTO Logar(string login, string senha)
        {
            if (login == string.Empty)
            {
                throw new ArgumentException("Usuário é obrigatório.");
            }

            if (senha == string.Empty)
            {
                throw new ArgumentException("Senha é obrigatório.");
            }

            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.Logar(login, senha);
        }
    }
}
