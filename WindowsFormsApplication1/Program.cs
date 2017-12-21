using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    static class Program
    {
       /// <summary>
       /// This is the main entry point into the application.
       /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Launcher mainForm = new Launcher();
            mainForm.Show();
            Application.Run();
        }
    }
}
