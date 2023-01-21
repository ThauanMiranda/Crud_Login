using Crud_Login.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Login.services {
    public class ServiceUsuario : IServiceUsuario {

        IUsuarioRepository usuarioRepository = new UsuarioRepository();

        public void atualizarUsuario(string email, Usuario usuario) {
            usuarioRepository.atualizar(email, usuario);
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

        public bool validarLogin(Usuario usuario) {
            Usuario validar = usuarioRepository.getPorEmail(usuario.email);
            if (validar == null) {
                return false;
            }
            if (!(validar.email.Equals(usuario.email))) {
                return false;
            }
            if (!(validar.senha.Equals(usuario.senha))) {
                return false;
            }
            return true;
        }

        public bool salvarUsuario(Usuario usuario) {
            if (usuario.email.Length <= 0) { 
                return false; 
            }
            if (usuario.senha.Length <= 0) {
                return false;
            }
            if (usuarioRepository.existePorEmail(usuario.email)) {
                return false;
            }
            usuarioRepository.salvar(usuario);
            return true;
        }

    }
}
