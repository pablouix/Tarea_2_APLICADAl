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

namespace ejer1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //Permite calcular la tabla de multiplical del 1 al 10 de cualquier numero 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public void btnCarcular(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NumeroDigitado.Text) || string.IsNullOrEmpty(NumeroDigitado.Text))
            {
                MessageBox.Show("Aun no a puesto un numero");
            }
            else if(System.Text.RegularExpressions.Regex.IsMatch(NumeroDigitado.Text, "[^0-9]")) 
            {
                MessageBox.Show("Aun no a puesto un numero");

            }
            else if(Convert.ToInt32(NumeroDigitado.Text) < 0)
            {
                MessageBox.Show("No numero negativos");
            }
            else
            {
                ListaTabla.Items.Clear();
                ObtenerTabla();
            }
        }

        private void ObtenerTabla()
        {

            int resultado;
            for (int i = 1; i <= 10; i++)
            {
                resultado = i * Convert.ToInt32(NumeroDigitado.Text);
                ListaTabla.Items.Add(Convert.ToInt32(NumeroDigitado.Text) + " x " + i + " = " + resultado);
            }
        }
        public void btnNuevo(object sender, RoutedEventArgs e)
        {
            ListaTabla.Items.Clear();
            NumeroDigitado.Text = "";
        }
    }
}
