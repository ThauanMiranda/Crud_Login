using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Login.models
{
    public class Usuario
    {

        public int id { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public Usuario() { 
        }

        public Usuario(int id, string email, string senha) {
            this.id = id;   
            this.email = email;
            this.senha = senha;
        }

        public Usuario(string email, string senha) {
            this.email = email;
            this.senha = senha;
        }

    }

}
