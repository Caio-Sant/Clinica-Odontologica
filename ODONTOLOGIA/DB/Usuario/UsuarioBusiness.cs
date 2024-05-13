using ODONTOLOGIA.DB.Usuário;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODONTOLOGIA.DB.Usuario
{
    class UsuarioBusiness
    {
        public int Salvar(UsuarioDTO dto)
        {
            UsuarioDTO cliente = this.ConsultarPorCpf(dto.Cpf);

            if (dto.Cpf == string.Empty)
            {
                throw new ArgumentException("Cpf já cadastrado no sistema.");
            }

            if (dto.Senha == string.Empty)
            {
                throw new ArgumentException("Senha é obrigatória.");
            }

            UsuarioDatabase db = new UsuarioDatabase();
            return db.Salvar(dto);
        }

        public UsuarioDTO ConsultarPorCpf(string cpf)
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.ConsultarPorCpf(cpf);
        }

        public List<UsuarioDTO> Listar()
        {
            UsuarioDatabase db = new UsuarioDatabase();
            return db.Listar();
        }
    }
}
