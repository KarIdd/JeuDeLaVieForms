using System;
using System.Windows.Forms;

namespace Jeu_de_la_vie
{
    class Program
    {
        /*
        static void Main()
        {

            Game game = new Game(10, 10);

            game.RunGameConsole();
        }*/

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
