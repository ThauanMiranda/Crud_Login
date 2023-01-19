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

        public void atualizarUsuario(Usuario usuario) {
            usuarioRepository.atualizar(usuario);
        }

        public bool deletarUsuario(int id) {
            Usuario usuario = usuarioRepository.getPorId(id);
            if (usuario == null) {
                return false;
            }
            usuarioRepository.deletar(usuario);
            return true;
        }

        public bool existePorId(int id) {
            Usuario usuario = usuarioRepository.getPorId(id);
            if (usuario == null) {
                return false;
            }
            return true;
        }

        public Usuario getUsuarioPorId(int id) {
            return usuarioRepository.getPorId(id);
        }

        public bool salvarUsuario(Usuario usuario) {
            if (usuarioRepository.existePorEmail(usuario.email)) {
                return false;
            }
            usuarioRepository.salvar(usuario);
            return true;
        }

    }
}
