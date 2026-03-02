using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase.Model
{
    public partial class Menu : ObservableObject
    {
        public string Label { get; set; }
        public string IconPath { get; set; }

        [ObservableProperty]
        private bool isActive;

        public Menu(string label, string iconPath)
        {
            Label = label;
            IconPath = iconPath; 
        }
    } //Aqui tambien use ia 
}
