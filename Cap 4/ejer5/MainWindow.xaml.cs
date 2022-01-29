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
    public partial class MainWindow : Window
    {
        //variable global 
        public int menor = 0;
        public int promedio = 0;
        public int mayor = 0;
        public int cantidadPersonas = 0;
        public bool paso = false;
        public bool agregoPersonas = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregar(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(CantidadPersonasDigitados.Text) || string.IsNullOrEmpty(CantidadPersonasDigitados.Text))
            {
                MessageBox.Show("Aun no a puesto un numero");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(CantidadPersonasDigitados.Text, "[^0-9]"))
            {
                MessageBox.Show("Aun no a puesto un numero valido");
            }
            else if (Convert.ToInt32(CantidadPersonasDigitados.Text) == 0)
            {
                MessageBox.Show("No numero 0");
            }
            else
            {
                CantidadPersonasDigitados.IsEnabled = false;
                EdadesDigitadas.IsEnabled = true;
                if (agregoPersonas == true)
                {

                    if (String.IsNullOrWhiteSpace(EdadesDigitadas.Text) || string.IsNullOrEmpty(EdadesDigitadas.Text))
                    {
                        MessageBox.Show("Aun no a puesto un numero");
                    }
                    else if (System.Text.RegularExpressions.Regex.IsMatch(EdadesDigitadas.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Aun no a puesto un numero valido");
                    }
                    else if (Convert.ToInt32(EdadesDigitadas.Text) == 0)
                    {
                        MessageBox.Show("No numero 0");
                    }
                    else
                    {
                        resultadosEdad();
                    }
                }
                else
                {
                    agregoPersonas = true;
                }

            }
        }
        private void btnLimpiar(object sender, RoutedEventArgs e)
        {
            CantidadPersonasDigitados.Text = "";
            EdadesDigitadas.Text = "";
            CantidadPersonasDigitados.IsEnabled = true;
            EdadesDigitadas.IsEnabled = false;
            ResultadosEdadMayor.Text = "Edad mayor";
            ResultadosEdadMenor.Text = "Edad menor";
            ResultadosEdadPromedio.Text = "Promedio de edades";
            paso = false;
            menor = 0;
            promedio = 0;
            mayor = 0;
            cantidadPersonas = 0;
            agregoPersonas = false;
        }

        public void resultadosEdad()
        {
            int edad = Convert.ToInt32(EdadesDigitadas.Text);

            if (paso == false)
            {
                menor = edad;
                paso = true;
                cantidadPersonas = Convert.ToInt32(CantidadPersonasDigitados.Text);
                EdadesDigitadas.Text = "";
            }

            if (edad > mayor)
                mayor = edad;
            if (edad < menor)
                menor = edad;
            promedio += edad;

            CantidadPersonasDigitados.Text = Convert.ToString(Convert.ToInt32(CantidadPersonasDigitados.Text) - 1);

            if (CantidadPersonasDigitados.Text == "0")
            {
                ResultadosEdadMayor.Text = Convert.ToString(mayor);
                ResultadosEdadMenor.Text = Convert.ToString(menor);
                ResultadosEdadPromedio.Text = Convert.ToString(promedio / cantidadPersonas);
                EdadesDigitadas.IsEnabled = false;
            }
            EdadesDigitadas.Text = "";
        }
    }
}
