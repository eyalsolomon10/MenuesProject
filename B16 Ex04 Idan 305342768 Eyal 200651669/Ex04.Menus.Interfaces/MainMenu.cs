using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    class MainMenu : MenuItem
    {
        public string m_ItemName
        {
            get
            {
                return m_ItemName;
            }

            set
            {
                m_ItemName = value;
            }
        }

        public List<T> m_MenuItemsList
        {
            get
            {
                return m_MenuItemsList;
            }

            set
            {
                m_MenuItemsList = value;
            }
        }

        public bool m_IsSubMenu
        {
            get
            {
                return true;
            }
        }
    }
}
