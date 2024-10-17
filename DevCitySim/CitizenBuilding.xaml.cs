using DevCitySim.Data;
using DevCitySim.Data.Classes;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace DevCitySim
{
    public sealed partial class CitizenBuilding : Window
    {


        internal CitizenBuilding(Citizen citizen, MainWindow mainWindow)
        {
            this.InitializeComponent();

            buildingListView.ItemsSource = citizen.BuildingCitizens;
            citizenName.Text = citizen.Name;
        }

        private void buildingListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Building selectedItem = ((BuildingCitizen)e.ClickedItem).Building;

            BuildingCitizens citizenBuilding = new BuildingCitizens(selectedItem);
            citizenBuilding.Activate();
        }
    }
}
