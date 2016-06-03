using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
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
