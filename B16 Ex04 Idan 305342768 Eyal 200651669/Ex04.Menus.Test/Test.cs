using System;
using System.Collections.Generic;
using System.Text;

using Ex04.Menus.Interfaces;
//using Ex04.Menus.Delegates;
namespace Ex04.Menus.Test
{
    public class Test

    {
        public static void Start()
        {
            //Ex04.Menus.Interfaces.MainMenu interfaceMenu = new Ex04.Menus.Interfaces.MainMenu();
            //Ex04.Menus.Delegates delegateMenu = new Menus.Delegates();
            VersionAction versionAction = new VersionAction();
            SpaceAction spaceAction = new SpaceAction();
            CountCharsAction countCharsAction = new CountCharsAction();

            MenuItem showVersionItem = new MenuItem(versionAction, "Show Version");
            MenuItem countCharsItem = new MenuItem(countCharsAction, "Count Characters");
            MenuItem countSpaces = new MenuItem(spaceAction, "Count Spaces");
            MenuItem timeActionItem = new MenuItem(new TimeAction(), "Show Time");
            MenuItem dateActionItem = new MenuItem(new DateAction(), "Show Date");

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
    }
}
