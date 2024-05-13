using ODONTOLOGIA.DB.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA
{
   static class UserSession
    {
        public static FuncionarioDTO UsuarioLogado { get; set; }
    }
}
