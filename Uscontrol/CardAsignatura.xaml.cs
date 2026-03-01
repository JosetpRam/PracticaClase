using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaClase.Uscontrol
{
    /// <summary>
    /// Lógica de interacción para CardAsignatura.xaml
    /// </summary>
    public partial class CardAsignatura : UserControl
    {
        public CardAsignatura()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get => (string)GetValue(NombreProperty);
            set => SetValue(NombreProperty, value);
        }
        public static readonly DependencyProperty NombreProperty =
            DependencyProperty.Register(nameof(Nombre), typeof(string), typeof(CardAsignatura),
                new PropertyMetadata(""));

        public string Descripcion
        {
            get => (string)GetValue(DescripcionProperty);
            set => SetValue(DescripcionProperty, value);
        }
        public static readonly DependencyProperty DescripcionProperty =
            DependencyProperty.Register(nameof(Descripcion), typeof(string), typeof(CardAsignatura),
                new PropertyMetadata(""));

        public string Carreras
        {
            get => (string)GetValue(CarrerasProperty);
            set => SetValue(CarrerasProperty, value);
        }
        public static readonly DependencyProperty CarrerasProperty =
            DependencyProperty.Register(nameof(Carreras), typeof(string), typeof(CardAsignatura),
                new PropertyMetadata(""));
    }
}
