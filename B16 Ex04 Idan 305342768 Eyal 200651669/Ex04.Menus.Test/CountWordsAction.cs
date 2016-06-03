using System;
using System.Collections.Generic;
using System.Text;

using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountCharsAction : IActionable
    {
        public void DoAction()
        {
            CharsCount();
        }

        private static void CharsCount()
        {
            Console.WriteLine("Please enter a sentence:");
            string userInput = Console.ReadLine();
            int letterCounter = 0;
            foreach (char c in userInput)
            {
                if (char.IsLetter(c))
                {
                    letterCounter++;
                }
            }

            Console.WriteLine(string.Format("There's {0} letters in the given sentence", letterCounter));
        }
    }
}
