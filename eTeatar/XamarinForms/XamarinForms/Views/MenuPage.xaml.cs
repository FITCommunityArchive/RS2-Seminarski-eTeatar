﻿using XamarinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.HomePage, Title="Početna" },
                new HomeMenuItem {Id = MenuItemType.Predstave, Title="Predstave" },
                new HomeMenuItem {Id = MenuItemType.Termini, Title="Termini" },
                new HomeMenuItem {Id = MenuItemType.Obavijesti, Title="Obavijesti" },
                new HomeMenuItem {Id = MenuItemType.MojePredstave, Title="Moje predstave" },
                new HomeMenuItem {Id = MenuItemType.Ocjene, Title="Ocjene" },
                new HomeMenuItem {Id = MenuItemType.MojProfil, Title="Moj profil" },
                new HomeMenuItem {Id = MenuItemType.Registracija, Title="Registracija" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}