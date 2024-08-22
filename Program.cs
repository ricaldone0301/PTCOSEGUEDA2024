using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTC.Controller;
using PTC.Vista;
using PTC.Vista.Login;

namespace PTC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ControllerInit.DeterminarVistaInicial();
        }
    }
}
