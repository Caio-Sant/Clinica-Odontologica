using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.DB.Funcionario
{
    class FuncionarioDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool PermissaoAdm { get; set; }
        
        public string Cpf { get; set; }
       
        public string Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public string Rg { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }

        public string NumeroCasa { get; set; }
        public string Email { get; set; }
        public DateTime Admissao { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
    }
}
