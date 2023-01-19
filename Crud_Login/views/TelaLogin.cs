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
            Usuario usuario = new Usuario(txtEmail.Text, txtSenha.Text);

            if (serviceUsuario.validarLogin(usuario)) {
                TelaPrincipal telaPrincipal = new TelaPrincipal(usuario);
                this.Visible = false;
                telaPrincipal.Visible = true;
                return;
            }

            MessageBox.Show("Senha ou email incorreto.");
        }
    }
}
