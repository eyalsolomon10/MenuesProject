using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class SpaceAction : IActionable
    {
        public void DoAction()
        {
            SpacesCount();
        }
        
        private static void SpacesCount()
        {
            Console.WriteLine("Please enter a sentence:");
            string userInput = Console.ReadLine();
            int letterCounter = 0;
            foreach (char c in userInput)
            {
                if (char.IsWhiteSpace(c))
                {
                    letterCounter++;
                }
            }
            Console.WriteLine(string.Format("There's {0} spaces in the given sentence", letterCounter));
        }

    }
}
