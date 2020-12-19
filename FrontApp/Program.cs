using FrontApp.Pages;
using System;
using System.Windows.Forms;

namespace FrontApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInScreen());
        }
    }
}
