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
    /// Lógica de interacción para Menucontrol.xaml
    /// </summary>
    public partial class Menucontrol : UserControl
    {
        public static readonly DependencyProperty LabelProperty =
           DependencyProperty.Register(nameof(Label), typeof(string), typeof(Menucontrol),
               new PropertyMetadata(string.Empty, OnLabelChanged));

        private static void OnLabelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Menucontrol ctrl)
                ctrl.IconGeometry = BuildIcon(e.NewValue as string ?? "");
        }

        private static object BuildIcon(string v)
        {
            throw new NotImplementedException();
        }

        public static readonly DependencyProperty IsSelectedProperty =
            DependencyProperty.Register(nameof(IsSelected), typeof(bool), typeof(Menucontrol),
                new PropertyMetadata(false));

        public static readonly DependencyProperty IconGeometryProperty =
            DependencyProperty.Register(nameof(IconGeometry), typeof(object), typeof(Menucontrol),
                new PropertyMetadata(null));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        public bool IsSelected
        {
            get => (bool)GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }

        public object IconGeometry
        {
            get => GetValue(IconGeometryProperty);
            set => SetValue(IconGeometryProperty, value);
        }

        //en algunas de estas lineas use ia para generar el codigo no se si es correcto, espero que no haya problemas con eso
        public Menucontrol()
        {
            InitializeComponent();
        }
    }
}
