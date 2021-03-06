﻿using System;
using System.Collections.Generic;
using System.Text;

using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class TestDelegates
    {
        public static void Start()
        {
            const bool v_IsMainMenu = true;
            MenuItem showVersionItem = new MenuItem(buttonVersion_Click, "Show Version");
            MenuItem countCharsItem = new MenuItem(buttonChar_Click, "Count Characters");
            MenuItem countSpaces = new MenuItem(buttonSpace_Click, "Count Spaces");
            MenuItem timeActionItem = new MenuItem(buttonTime_Click, "Show Time");
            MenuItem dateActionItem = new MenuItem(buttonDate_Click, "Show Date");

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
