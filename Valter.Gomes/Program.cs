using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valter.Gomes
{
    static class Program
    {
        /// <summary>
        /// Criado por Valter Gomes Neto para vaga de Dev Jr Thomas Gregg
        /// Criado em: 24/12/2020
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
