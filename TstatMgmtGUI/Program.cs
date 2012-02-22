using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facade;
using System.Diagnostics;

namespace TstatMgmtGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FindAvailableNetworks());
        }
    }
}
