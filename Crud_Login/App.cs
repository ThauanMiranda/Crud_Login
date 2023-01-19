using Crud_Login.views;
using System.Runtime.CompilerServices;

namespace Crud_Login {
    internal static class App {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaLogin());
        }
    }
}