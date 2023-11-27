using System;
using System.Windows.Forms;
using DotNetEnv;

namespace Biblivres
{
    internal static class Program
    {
        /// <summary>
        ///     Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Env.Load();
            Env.TraversePath().Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}