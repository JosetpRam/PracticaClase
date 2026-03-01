using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PracticaClase.Interface;
using PracticaClase.Model;
using PracticaClase.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticaClase.ViewModel
{
    public partial class CardViewModel : ObservableObject
    {
        private IClasesRepository _repo = new AsignaturaRepository();

        [ObservableProperty]
        private ObservableCollection<Asignaturas> asignaturas = new ObservableCollection<Asignaturas>();

        public CardViewModel() { }

        [RelayCommand]
        public void GetAll()
        {
            var lista = _repo.GetAll();

            Asignaturas.Clear();

            foreach (var item in lista)
            {
                Asignaturas.Add(item);
            }

            MessageBox.Show("Se agregaron " + Asignaturas.Count + " asignaturas.");
        }

    }
}
