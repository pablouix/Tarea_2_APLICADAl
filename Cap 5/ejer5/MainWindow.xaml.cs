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

namespace ejer5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //numeros a cadena
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnLetra(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NumeroDigitado.Text) || string.IsNullOrEmpty(NumeroDigitado.Text))
            {
                MessageBox.Show("Aun no a puesto un numero");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(NumeroDigitado.Text, "[^0-9]"))
            {
                MessageBox.Show("Aun no a puesto un numero valido");
            }
            else
            {
                ResultadosLetra.Text = numeroPalabra(Convert.ToInt32(NumeroDigitado.Text));
            }
        }

        public void btnNuevo(object sender, RoutedEventArgs e)
        {
            ResultadosLetra.Text = "";
            NumeroDigitado.Text = "";
        }
        public string numeroPalabra(int numero)
        {
            switch(numero)
            {
                case 0:
                    return "Cero";
                case 1:
                    return "Uno";
                case 2:
                    return "Dos";
                case 3:
                    return "Tres";
                case 4: 
                    return "Cuatro";
                case 5:
                    return "Cinco";
                case 6:
                    return "Seis";
                case 7:
                    return "Siete";
                case 8: 
                    return "Ocho";
                case 9:
                    return "Nueve";
                case 10: 
                    return "Dies";
                default:
                    return numero+" No esta registrado";
            }
        }
    }
}
