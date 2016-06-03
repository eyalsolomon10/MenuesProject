using System;
using System.Collections.Generic;
using System.Text;

using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class TestDelegates
    {
        public static void Start()
        {
            MenuItem showVersionItem = new MenuItem(new Clicker(buttonVersion_Click), "Show Version");
            MenuItem countCharsItem = new MenuItem(new Clicker(buttonChar_Click), "Count Characters");
            MenuItem countSpaces = new MenuItem(new Clicker(buttonSpace_Click), "Count Spaces");
            MenuItem timeActionItem = new MenuItem(new Clicker(buttonTime_Click), "Show Time");
            MenuItem dateActionItem = new MenuItem(new Clicker(buttonDate_Click), "Show Date");

            List<MenuItem> actionsMenuList = new List<MenuItem>();
            actionsMenuList.Add(countCharsItem);
            actionsMenuList.Add(countSpaces);
            MenuItem secondMenu = new MenuItem(actionsMenuList, "Actions", false);

            MenuItem versionActionsItem = new MenuItem(new List<MenuItem>(), "Version and actions", false);
            versionActionsItem.Add(showVersionItem);
            versionActionsItem.Add(secondMenu);

            actionsMenuList = new List<MenuItem>();
            actionsMenuList.Add(dateActionItem);
            actionsMenuList.Add(timeActionItem);

            MenuItem dateTimeActionsItem = new MenuItem(actionsMenuList, "Show Date/Time", false);
            MenuItem mainMenuItem = new MenuItem(new List<MenuItem>(), "Main Menu", true);
            mainMenuItem.Add(versionActionsItem);
            mainMenuItem.Add(dateTimeActionsItem);
            MainMenu mainMenu = new MainMenu(mainMenuItem);

            mainMenu.Show();
        }

        private static void buttonDate_Click()
        {
            new DateAction().DoAction();
        }

        private static void buttonTime_Click()
        {
            new TimeAction().DoAction();
        }

        private static void buttonSpace_Click()
        {
            new SpaceAction().DoAction();
        }

        private static void buttonChar_Click()
        {
            new CountCharsAction().DoAction();
        }

        private static void buttonVersion_Click()
        {
            new VersionAction().DoAction();
        }
    }
}
