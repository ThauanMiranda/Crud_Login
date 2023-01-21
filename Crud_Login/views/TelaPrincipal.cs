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
    public partial class TelaPrincipal : Form {

        private Usuario usuarioLogado;
        private IUsuarioRepository usuarioRepository;

        public TelaPrincipal(Usuario usuario) {
            InitializeComponent();
            this.usuarioLogado = usuario;

            string resultado = usuarioLogado.email.Split('@')[0].ToUpper();
            lblBemVindo.Text = "Olá, Bem-vindo " + resultado + "!";

            usuarioRepository = new UsuarioRepository();
        }

        private void btnDeletarConta_Click(object sender, EventArgs e) {
            usuarioRepository.deletar(usuarioLogado);
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Visible = true; 
            this.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e) {
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

            Usuario usuarioAtualizar = new Usuario(email, senha);

            usuarioRepository.atualizar(usuarioLogado.email, usuarioAtualizar);

            string resultado = usuarioLogado.email.Split('@')[0].ToUpper();
            lblBemVindo.Text = "Olá, Bem-vindo " + resultado + "!";
        }

        private void btnSair_Click(object sender, EventArgs e) {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Visible = true;
            this.Visible = false;
        }
    }
}
