using System;
using System.Collections.Generic;
using System.Text;

using Ex04.Menus.Interfaces;
namespace Ex04.Menus.Test
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
