using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Abstractions;
using DataObjects.DTOS;
using EDCORE.Helpers;
using Mvvm.Services;
using SQLite;
using AdminArea = WT.UWP.ED2.Views.AdminArea;
using DocumentsPage = WT.UWP.ED2.Views.DocumentsPage;
using InternalAuditsPage = WT.UWP.ED2.Views.InternalAuditsPage;
using ReportsPage = WT.UWP.ED2.Views.ReportsPage;
using WT.UWP.ED2.Views;

public class MenuItemCollection : IMenuItemCollection
{
    private IPageLookup _pageLookup;
    private IMenuStore _iMenuStore;

    public MenuItemCollection(IPageLookup pageLookup, IMenuStore iMenuStore)
    {
        _pageLookup = pageLookup;
        _iMenuStore = iMenuStore;
    }


    public ObservableCollection<MenuItem> GetSideMenu()
    {
       var menu = new ObservableCollection<MenuItem>
            {
                new MenuItem()
                {
                    Glyph = Icon.GetIcon("InfoIcon"),
                    Text = "Reports",
                    NavigationDestination = typeof(ReportsPage)
                },
                new MenuItem()
                {
                    Glyph = Icon.GetIcon("InfoIcon"),
                    Text = "Internal Audits",
                    NavigationDestination = typeof(InternalAuditsPage)
                },
                new MenuItem()
                {
                    Glyph = Icon.GetIcon("InfoIcon"),
                    Text = "Documents",
                    NavigationDestination = typeof(DocumentsPage)
                },
                new MenuItem()
                {
                    Glyph = Icon.GetIcon("InfoIcon"),
                    Text = "Admin",
                    NavigationDestination = typeof(AdminArea)
                }
            };

        return menu;
    }

    public ObservableCollection<MenuItem> GetSubMenu()
    {
        var menu = new ObservableCollection<MenuItem>
            {
                new MenuItem()
                {
                    Glyph = Icon.GetIcon("InfoIcon"),
                    Text = "Default",
                    NavigationDestination = typeof(ReportsPage) 
                }
            };

        return menu;
    }

    public ObservableCollection<MenuItem> GetTopMenu()
    {
        
        var menus = _iMenuStore.GetMenusAsync();

        var mainMenu = new ObservableCollection<MenuItem>();


        Func<IEnumerable<MenuDTO>, ObservableCollection<MenuItem>> makeSubMenu = s =>
        {
            var subMenu = new ObservableCollection<MenuItem>();

            foreach (var m in s)
            {
                subMenu.Add(new MenuItem()
                {
                    Text = m.Caption,
                    NavigationDestination = _pageLookup.PageType(m.Destination),
                    Param = m.Destination
                });
            }
            return subMenu;
        };

        foreach (var m in menus.Result.Where(m=>m.ParentMenuId == 0))
        {
            mainMenu.Add(new MenuItem
                    {
                        Text = m.Caption,
                        SubMenu = makeSubMenu(menus.Result.Where(p=>p.ParentMenuId == m.Id)),                    
                        NavigationDestination = _pageLookup.PageType(m.Destination),
                        Param = m.Destination
            });
        }


        return mainMenu;
    }
}