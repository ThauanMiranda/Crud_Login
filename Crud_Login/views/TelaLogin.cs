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
        public TelaLogin() {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e) {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
