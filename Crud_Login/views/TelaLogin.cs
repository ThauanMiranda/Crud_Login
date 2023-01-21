using Crud_Login.models;
using Crud_Login.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Login.views {
    public partial class TelaLogin : Form {

        private IServiceUsuario serviceUsuario;

        public TelaLogin() {
            InitializeComponent();
            serviceUsuario = new ServiceUsuario();
        }

        private void btnCadastro_Click(object sender, EventArgs e) {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            
            if (String.IsNullOrEmpty(email)) {
                MessageBox.Show("O campo do e-mail está vázio.");
                return;
            }

            if (String.IsNullOrEmpty(senha)) {
                MessageBox.Show("O campo da senha está vázio.");
                return;
            }

            Usuario usuario = new Usuario(email, senha);

            if (serviceUsuario.validarLogin(usuario)) {
                TelaPrincipal telaPrincipal = new TelaPrincipal(usuario);
                this.Visible = false;
                telaPrincipal.Visible = true;
                return;
            }
            MessageBox.Show("Os dados informados estão incorretos, tente novamente.");
        }

    }
}
