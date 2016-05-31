using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    interface MenuItem
    {
        string m_ItemName
        {
            get;
            set;
        }

        List<T> m_MenuItemsList
        {
            get;
            set;
        }

        bool m_IsSubMenu
        {
            get;
        }


    }
}
