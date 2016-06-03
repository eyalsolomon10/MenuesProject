using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TestInterfaces
    {
        public static void Start()
        {
            const bool v_IsMainMenu = true;
            MenuItem showVersionItem = new MenuItem(new VersionAction(), "Show Version");
            MenuItem countCharsItem = new MenuItem(new CountCharsAction(), "Count Characters");
            MenuItem countSpaces = new MenuItem(new SpaceAction(), "Count Spaces");
            MenuItem timeActionItem = new MenuItem(new TimeAction(), "Show Time");
            MenuItem dateActionItem = new MenuItem(new DateAction(), "Show Date");

            List<MenuItem> actionsMenuList = new List<MenuItem>();
            actionsMenuList.Add(countCharsItem);
            actionsMenuList.Add(countSpaces);
            MenuItem secondMenu = new MenuItem(actionsMenuList, "Actions", !v_IsMainMenu);

            MenuItem versionActionsItem = new MenuItem(new List<MenuItem>(), "Version and actions", !v_IsMainMenu);
            versionActionsItem.Add(showVersionItem);
            versionActionsItem.Add(secondMenu);

            actionsMenuList = new List<MenuItem>();
            actionsMenuList.Add(dateActionItem);
            actionsMenuList.Add(timeActionItem);

            MenuItem dateTimeActionsItem = new MenuItem(actionsMenuList, "Show Date/Time", !v_IsMainMenu);
            MenuItem mainMenuItem = new MenuItem(new List<MenuItem>(), "Main Menu", v_IsMainMenu);
            mainMenuItem.Add(versionActionsItem);
            mainMenuItem.Add(dateTimeActionsItem);
            MainMenu mainMenu = new MainMenu(mainMenuItem);

            mainMenu.Show();
        }
    }
}
