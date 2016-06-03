using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private List<MenuItem> m_Menues;
        private string m_Title;
        private bool m_IsAction;
        private IActionable Action;
        private bool m_IsFirstMenu;

        public MenuItem(List<MenuItem> i_Menues, string i_Title, bool i_IsFirst)
        {
            m_Menues = i_Menues;
            m_Title = i_Title;
            m_IsAction = false;
            m_IsFirstMenu = i_IsFirst;
        }

        public MenuItem(IActionable i_Action, string i_Title)
        {
            m_Menues = null;
            m_Title = i_Title;
            Action = i_Action;
            m_IsAction = true;
        }

        public void Add(MenuItem i_MenuItem)
        {
            if (m_Menues == null)
            {
                m_Menues = new List<MenuItem>();
            }

            m_Menues.Add(i_MenuItem);
        }

        public void Activate()
        {
            if (m_IsAction)
            {
                Action.DoAction();
            }
            else
            {
                Show();
            }
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Please choose one of the below items:");
                if (m_IsFirstMenu)
                {
                    Console.WriteLine("0: Exit");
                }
                else
                {
                    Console.WriteLine("0: Back");
                }

                for (int i = 0; i < m_Menues.Count; i++)
                {
                    Console.WriteLine(string.Format("{0}: {1}", i + 1, m_Menues[i].m_Title));
                }

                if (GetInputAndActivate() == 0)
                {
                    break;
                }
            }
        }

        public int GetInputAndActivate()
        {
            string input = string.Empty;
            input = Console.ReadLine();
            Console.Clear();
            int parsedInt = this.parseInput(input);

            if (parsedInt != -1 && parsedInt != 0)
            {
                this.m_Menues[parsedInt - 1].Activate();
            }
            else if (parsedInt != 0)
            {
                Console.WriteLine("Invalid Input!");
            }

            return parsedInt;
        }

        private int parseInput(string i_Input)
        {
            int o_Result = 0;
            int toReturn = -1;
            if (int.TryParse(i_Input, out o_Result))
            {
                if (o_Result <= m_Menues.Count && o_Result >= 0)
                {
                    toReturn = o_Result;
                }
            }

            return toReturn;
        }
    }
}
