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

namespace DevCitySim
{
    public sealed partial class SoftwareDeveloperWindow : Window
    {
        public string DeveloperName {  get; set; }
        public int DeveloperAge {  get; set; }
        public SoftwareDeveloperWindow(string developerName)
        {
            this.InitializeComponent();

            DeveloperName = developerName;
        }
    }
}
