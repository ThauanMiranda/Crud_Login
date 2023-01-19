using Crud_Login.models;
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
            lblBemVindo.Text = "Olá, Bem-vindo " + usuarioLogado.email;
            usuarioRepository = new UsuarioRepository();
        }

        private void btnDeletarConta_Click(object sender, EventArgs e) {
            usuarioRepository.deletar(usuarioLogado);
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Visible = true; 
            this.Visible = false;
        }

    }
}
