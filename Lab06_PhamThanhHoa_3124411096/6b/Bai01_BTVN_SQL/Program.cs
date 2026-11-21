using System;
using System.Windows.Forms;

namespace Bai01_BTVN_SQL
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
