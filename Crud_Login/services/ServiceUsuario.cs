using Crud_Login.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Login.services {
    internal class ServiceUsuario : IServiceUsuario {

        IUsuarioRepository usuarioRepository = new UsuarioRepository();

        public bool atualizarUsuario(int id, Usuario usuario) {
            return true;
        }

        public bool deletarUsuario(int id) {
            return true;
        }

        public bool existePorId(int id) {
            return true;
        }

        public Usuario getUsuarioPorId(int id) {
            return null!;
        }

        public void salvarUsuario(Usuario usuario) {
        }

    }
}
