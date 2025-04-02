using System;
using System.Windows.Forms;
using Hotel_Philoxenia.Forms; 

namespace Hotel_Philoxenia
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
