using Crud_Login.models;
using System;

namespace Crud_Login {
    internal interface IUsuarioRepository {

        public void salvar(Usuario usuario);
        public void deletar(Usuario usuario);
        public void atualizar(Usuario usuario);
        public Usuario getPorId(int id);
        public List<Usuario> getTodos();

    }
}