using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenchmarkDotNet.Running;

namespace Proyecto_DesarrolloSoftware
{
    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Deshabilitar la detección de deadlock
            System.Diagnostics.Debug.Listeners.Clear();

            // Configurar manejo de memoria
            System.Runtime.GCSettings.LatencyMode = System.Runtime.GCLatencyMode.Interactive;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1 ());

         
        }
    }
}
