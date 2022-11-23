using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace СashRegister
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new Form1());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().First();
            form1.WriteToOperationsLog("Ошибка: " + e.Exception.Message, Color.Red);
        }
    }
}
