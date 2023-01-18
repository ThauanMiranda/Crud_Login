using Crud_Login.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Login.services {
    internal interface IServiceUsuario {

        void salvarUsuario(Usuario usuario);
        Usuario getUsuarioPorId(long id);
        bool atualizarUsuario(long id, Usuario usuario);
        bool existePorId(long id);
        bool deletarUsuario(long id);

    }
}
