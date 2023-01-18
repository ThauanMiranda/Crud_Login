using Crud_Login.models;

namespace Crud_Login {
    internal static class App {
        [STAThread]
        static void Main() {
            //ApplicationConfiguration.Initialize();
            //Application.Run();

            IUsuarioRepository usuarioRep = new UsuarioRepository();

            Usuario usuario = new Usuario();
            usuario.email = "jonas@gmail.com";
            usuario.senha = "JonasDias123";
            
            usuarioRep.salvar(usuario);


        }
    }
}