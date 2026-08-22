using System;
using System.Windows.Forms;

namespace TichDiemTest
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseHelper.Initialize(
                server: "42.113.173.5,3636",
                database: "TestTichDiem",
                user: "sa",
                password: "YourPassword123!"
            );

            Application.Run(new Form1());
        }
    }
}