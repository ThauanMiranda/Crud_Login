using Crud_Login.models;
using System;

namespace Crud_Login {
    public interface IUsuarioRepository {

        public void salvar(Usuario usuario);
        public void deletar(Usuario usuario);
        public void atualizar(Usuario usuario);
        public Usuario getPorId(int id);
        public List<Usuario> getTodos();
        public bool existePorEmail(string email);
        public Usuario getPorEmail(string email);

    }
}