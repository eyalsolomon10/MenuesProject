using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex04.Menus.Interfaces interfaceMenu = new Menus.Interfaces();
            Ex04.Menus.Delegates delegateMenu = new Menus.Delegates();

            while (true)
            {
                interfaceMenu.run();
                if (interfaceMenu.m_Exit = true)
                {
                    delegateMenu.run();
                }
            }
        }
    }
}
