using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HerrmDiag.TestAtencion;

namespace HerrmDiag
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Splash());
            //Application.Run( new BEN.MainForm() );

            #region Test de atencion
            Application.Run( new Autent_User() );
            #endregion
        }
    }
}