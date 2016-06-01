using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class DateAction : IActionable
    {
        public void DoAction()
        {
            ShowDate();
        }

        private static void ShowDate()
        {
            Console.WriteLine(string.Format("Current date is: {0}", DateTime.Now.ToString("dd/MM/yyyy")));
        }

    }
}
