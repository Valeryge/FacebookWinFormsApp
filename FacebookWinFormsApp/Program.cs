using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookApp.GameOfLifeFiles;
using FacebookWrapper;


namespace FacebookApp
{
    static class Program
    {
 [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());     
        }
    }
}
