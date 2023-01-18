using Crud_Login.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Login.repository {
    internal class UsuarioRepository : IUsuarioRepository {

        public List<Usuario> usuarios { get; set; }

        public UsuarioRepository() { 
            usuarios = new List<Usuario>();
        }

        public void salvarUsuario(Usuario usuario) {
            usuarios.Add(usuario);
        }

        public Usuario getUsuarioPorId(long id) { 
            return usuarios.Find(item => item.id == id);
        }

        public bool atualizarUsuario(long id, Usuario usuario) {
            Usuario encontrado = usuarios.Find(item => id == item.id);

            if (encontrado == null) {
                return false;   
            }

            int index = usuarios.IndexOf(encontrado);

            usuarios[index] = usuario;
            return true;
        }

        public bool existePorId(long id) {
            return usuarios.Exists(item => item.id == id); 
        }

        public bool deletarUsuario(long id) {
            Usuario encontrado = usuarios.Find(item => id == item.id);

            if (encontrado == null) {
                return false;
            }

            usuarios.Remove(encontrado);
            return true;
        }

    }

}
