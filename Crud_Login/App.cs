using Crud_Login.models;
using Crud_Login.views;

namespace Crud_Login {
    internal static class App {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaLogin());
        }
    }
}