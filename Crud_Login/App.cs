using Crud_Login.models;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Crud_Login {
    internal static class App {
        [STAThread]
        static void Main() {
            //ApplicationConfiguration.Initialize();
            //Application.Run();

            IUsuarioRepository usuarioRep = new UsuarioRepository();

            MessageBox.Show(usuarioRep.existePorEmail("jonas@gmail.com").ToString());

        }
    }
}