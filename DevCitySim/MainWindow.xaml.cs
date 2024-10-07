using DevCitySim.Data;
using DevCitySim.Data.Classes;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Linq;

namespace DevCitySim
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            ShowCitizens();

            FilterBox.TextChanged += FilterBox_TextChanged;
        }

        private void ShowCitizens()
        {
            using (var db = new AppDbContext())
            {
                bewonersListView.ItemsSource = db.Citizens
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
                    .ToList();

                bewonersListView.ItemsSource = filteredCitizens;
            }
        }

        private void bewonersListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedItem = (Citizen)e.ClickedItem;

            FilterBox.Text = selectedItem.Name;
        }
    }
}
