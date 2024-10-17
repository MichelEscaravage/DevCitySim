using DevCitySim.Data;
using DevCitySim.Data.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevCitySim
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ShowCitizens();
            /*      TEST();*/
            FilterBox.TextChanged += FilterBox_TextChanged;
        }

        private void ShowCitizens()
        {
            using (var db = new AppDbContext())
            {
                bewonersListView.ItemsSource = db.Citizens
                 .Include(citizen => citizen.BuildingCitizens)
                 .ThenInclude(pivot => pivot.Building)
                 .OrderBy(citizenName => citizenName.Name)
                 .ToList();
            }
        }

        private void ActivateSoftwareDeveloper(object sender, RoutedEventArgs e)
        {
            SoftwareDeveloperWindow softwaredeveloperWindow = new SoftwareDeveloperWindow(FilterBox.Text);
            softwaredeveloperWindow.Closed += SoftwaredeveloperWindow_Closed;
            softwaredeveloperWindow.Activate();
        }

        private async void SoftwaredeveloperWindow_Closed(object sender, WindowEventArgs args)
        {
           SoftwareDeveloperWindow softwareDeveloperWindow = (SoftwareDeveloperWindow)sender;
            int age = softwareDeveloperWindow.DeveloperAge;

            ContentDialog dialog = new ContentDialog()
            {
                Title = "Jouw leeftijd",
                Content = "De door jou opgegeven leeftijd is: " + age,
                CloseButtonText = "Ok",
                XamlRoot = this.Content.XamlRoot,
            };
            await dialog.ShowAsync();
        }

        private void FilterBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filter = FilterBox.Text;

            FilterCitizenByName(filter);
        }

        private void FilterCitizenByName(string filter)
        {
            using (var db = new AppDbContext())
            {
                var filteredCitizens = db.Citizens
                    .Where(citizen => citizen.Name.Contains(filter))
                    .OrderBy(citizen => citizen.Name)
                    .Include(c => c.BuildingCitizens)
                    .ThenInclude(pivot => pivot.Building)
                    .ToList();

                bewonersListView.ItemsSource = filteredCitizens;
            }
        }

        private void bewonersListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Citizen selectedItem = (Citizen)e.ClickedItem;

            FilterBox.Text = selectedItem.Name;

            CitizenBuilding citizenBuilding = new CitizenBuilding(selectedItem, this);
            citizenBuilding.Activate();
        }
    }
}
