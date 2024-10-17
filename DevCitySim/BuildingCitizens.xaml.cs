using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using DevCitySim.Data.Classes;
using DevCitySim.Data;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using Microsoft.EntityFrameworkCore;

namespace DevCitySim
{

    public sealed partial class BuildingCitizens : Window
    {
        internal BuildingCitizens(Building building)
        {
            this.InitializeComponent();
            using (var db = new AppDbContext())
            {
                var newBuilding = db.Buildings
                    .Include(building => building.BuildingCitizens)
                    .ThenInclude(pivot => pivot.Citizen)
                    .FirstOrDefault(c => c.Id == building.Id);

                buildingCitizensListView.ItemsSource = newBuilding.BuildingCitizens;
            }
        }
    }
}
