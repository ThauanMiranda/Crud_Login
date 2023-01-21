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
    public partial class TelaCadastro : Form {

        private IServiceUsuario serviceUsuario = new ServiceUsuario();

        public TelaCadastro() {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("O campo está vazio");
                return;
            }
            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O campo está vazio");
                return;
            }

            Usuario usuario = new Usuario(txtEmail.Text, txtSenha.Text);
            serviceUsuario.salvarUsuario(usuario);
            this.Visible = false;
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
