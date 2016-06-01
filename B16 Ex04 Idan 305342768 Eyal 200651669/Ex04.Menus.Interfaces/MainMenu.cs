using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private MenuItem m_MenuItem;

        public MainMenu(MenuItem i_MenuItem)
        {
            m_MenuItem = i_MenuItem;
        }

        public MenuItem MenuItem
        {
            set
            {
                m_MenuItem = value;
            }
        }


        public void Show()
        {
            m_MenuItem.Show();
        }
    }
}
