using System;

namespace Ex04.Menus.Interfaces
{
    class ActionMethods
    {
        public void ShowVersion()
        {
            Console.WriteLine("Version: 16.2.4.0");
        }

        public void CharsCount()
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
            Console.WriteLine(string.Format("There's {0} letters in the given sentence"), letterCounter);
        }

        public void SpacesCount()
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
            Console.WriteLine(string.Format("There's {0} spaces in the given sentence"), letterCounter);
        }

        public void ShowTime()
        {
            Console.WriteLine(string.Format("Current time is: {0:HH:mm:ss tt}", DateTime.Now));
        }

        public void ShowDate()
        {
            Console.WriteLine(string.Format("Current date is: {0}", DateTime.Now.ToString("dd/MM/yyyy")));
        }

    }
}
