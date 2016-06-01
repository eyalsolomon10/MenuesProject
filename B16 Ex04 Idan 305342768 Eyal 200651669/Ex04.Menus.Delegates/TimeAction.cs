using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class TimeAction : IActionable
    {

        public void DoAction()
        {
            ShowTime();
        }

        private static void ShowTime()
        {
            Console.WriteLine(string.Format("Current time is: {0:HH:mm:ss tt}", DateTime.Now));
        }

    }
}
