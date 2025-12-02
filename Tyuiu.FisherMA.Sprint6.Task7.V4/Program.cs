using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.FisherMA.Sprint6.Task7.V4
{
    internal static class Program
    {
        /// <summary>
        /// Ãëàâíàÿ òî÷êà âõîäà äëÿ ïðèëîæåíèÿ.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    internal class Form1 : Form
    {
    }
}