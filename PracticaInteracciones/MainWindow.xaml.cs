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

namespace PracticaInteracciones {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            txtCuenta.Text = "0";
        }

        private void sldPorcentajePropina_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            lblPorcentajePropina.Text = ((int)sldPorcentajePropina.Value).ToString() + "%";

            float cuenta = float.Parse(txtCuenta.Text);
            float montoPropina = cuenta * ((int)sldPorcentajePropina.Value / 100f);
            float totalAPagar = cuenta + montoPropina;

            lblTotalConPropina.Text = "$" + totalAPagar.ToString();
        }
    }
}
