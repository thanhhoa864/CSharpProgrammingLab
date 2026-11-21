using System;
using System.Windows.Forms;

namespace Bai02_BTNC_SQL
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
