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

namespace ejer2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    // elavar numeros a cualquier postencia
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnElevar(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NumeroDigitado.Text) || string.IsNullOrEmpty(NumeroDigitado.Text))
            {
                MessageBox.Show("Aun no a puesto un numero");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(NumeroDigitado.Text, "[^0-9]"))
            {
                MessageBox.Show("Aun no a puesto un numero valido");
            }
            else if (Convert.ToInt32(NumeroDigitado.Text) < 0)
            {
                MessageBox.Show("No numero negativos");
            }
            else if (String.IsNullOrWhiteSpace(NumeroPotencia.Text) || string.IsNullOrEmpty(NumeroPotencia.Text))
            {
                MessageBox.Show("Aun no a puesto un numero");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(NumeroPotencia.Text, "[^0-9]"))
            {
                MessageBox.Show("Aun no a puesto un numero valido");

            }
            else if (Convert.ToInt32(NumeroPotencia.Text) < 0)
            {
                MessageBox.Show("No numero negativos");
            }
            else
            {
                double resultado;
                resultado = Math.Pow(Convert.ToDouble(NumeroDigitado.Text), Convert.ToDouble(NumeroPotencia.Text));
                ResultadosPotencia.Text = Convert.ToString(resultado);
            }
        }

        private void btnNuevo(object sender, RoutedEventArgs e)
        {
            NumeroDigitado.Text = "";
            NumeroPotencia.Text = "";
            ResultadosPotencia.Text = "";
        }
    }
}
