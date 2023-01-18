using Crud_Login.models;
using Crud_Login.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Login.services {
    internal class ServiceUsuario : IServiceUsuario {

        IUsuarioRepository usuarioRepository = new UsuarioRepository();

        public bool atualizarUsuario(long id, Usuario usuario) {
            return true;
        }

        public bool deletarUsuario(long id) {
            return true;
        }

        public bool existePorId(long id) {
            return true;
        }

        public Usuario getUsuarioPorId(long id) {
            return null;
        }

        public void salvarUsuario(Usuario usuario) {
        }

    }
}
