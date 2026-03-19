using System;
using System.Windows.Forms;

namespace SmartWaste.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DatabaseHelper.InitializeDatabase();

            Application.Run(new LoginForm());
        }
    }
}