using System;
using System.Windows.Forms;

namespace FinalProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseHelper.InitializeDatabase();
            Application.Run(new Form1());
        }
    }
}