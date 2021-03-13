//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Particular">
// <author>Emerson Barros</author>
// </copyright>
//-----------------------------------------------------------------------
namespace ConometroEmerson
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    ///  Internal Class of the Stopwatch
    /// </summary>
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCronometro());
        }
    }
}
