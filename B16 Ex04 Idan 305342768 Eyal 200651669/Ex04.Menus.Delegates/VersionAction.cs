using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class VersionAction : IActionable
    {
        public void DoAction()
        {
            ShowVersion();
        }

        private static void ShowVersion()
        {
            Console.WriteLine("Version: 16.2.4.0");
        }
    }
}
