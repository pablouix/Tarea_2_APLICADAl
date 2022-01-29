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

namespace ejer4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //calcula el factorial de un numero 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnFactorial(object sender, RoutedEventArgs e)
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
            else if(Convert.ToInt32(NumeroDigitado.Text) == 0)
            {
                MessageBox.Show("No numero 0"); 
            }
            else
            {
                ResultadosFactorial.Text = Convert.ToString(Factorial(Convert.ToInt32(NumeroDigitado.Text)));
            }
        }

        public void btnNuevo(object sender, RoutedEventArgs e)
        {
            ResultadosFactorial.Text = "";
            NumeroDigitado.Text = "";
        }

        public double Factorial(int numero)
        {
            if (numero == 1)
                return 1;
            return numero * Factorial(numero - 1);
        }
    }
}
