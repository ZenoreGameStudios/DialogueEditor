using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueEditor
{
    static class Program
    {
        private static bool isMenuOpen = true;

        static MainMenu theMainMenu;
        static MainScreen theMainScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main () {
            Application.EnableVisualStyles ();
            Application.SetCompatibleTextRenderingDefault (false);

            theMainMenu = new MainMenu ();
            theMainScreen = new MainScreen ();

            theMainScreen.Hide ();
            theMainMenu.Show ();

            Application.Run ();
        }

        public static void ChangeForm () {
            if (isMenuOpen) {
                theMainMenu.Hide ();
                theMainScreen.Show ();
            } else {
                theMainMenu.Show ();
                theMainScreen.Hide ();
            }
            isMenuOpen = !isMenuOpen;
        }
    }
}
