using Crud_Login.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Login.services {
    internal interface IServiceUsuario {

        void salvarUsuario(Usuario usuario);
        Usuario getUsuarioPorId(int id);
        bool atualizarUsuario(int id, Usuario usuario);
        bool existePorId(int id);
        bool deletarUsuario(int id);

    }
}
