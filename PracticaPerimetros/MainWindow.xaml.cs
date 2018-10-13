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

namespace PracticaPerimetros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            controlPerimetroCirculo.Visibility = Visibility.Collapsed;
            controlPerimetroCuadrado.Visibility = Visibility.Collapsed;
            controlPerimetroRectangulo.Visibility = Visibility.Collapsed;
            controlPerimetroTrapecio.Visibility = Visibility.Collapsed;

            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //circulo
                    controlPerimetroCirculo.Visibility = Visibility.Visible;
                    break;
                case 1: //cuadrado
                    controlPerimetroCuadrado.Visibility = Visibility.Visible;
                    break;
                case 2: //circulo
                    controlPerimetroRectangulo.Visibility = Visibility.Visible;
                    break;
                case 3: //cuadrado
                    controlPerimetroTrapecio.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            float perimetro = 0.0f;

            switch(cbTipoFigura.SelectedIndex)
            {
                case 0:
                    float radio = float.Parse(controlPerimetroCirculo.txtRadio.Text);
                    float pi = Convert.ToSingle(Math.PI);
                    perimetro = 2 * radio * pi;
                    break;
                case 1:
                    float lado = float.Parse(controlPerimetroCuadrado.txtLado.Text);
                    perimetro = 4 * lado;
                    break;
                case 2:
                    float baseRec = float.Parse(controlPerimetroRectangulo.txtBase.Text);
                    float alturaRec = float.Parse(controlPerimetroRectangulo.txtAltura.Text);
                    perimetro = baseRec + baseRec + alturaRec + alturaRec;
                    break;
                case 3:
                    float baseMenor = float.Parse(controlPerimetroTrapecio.txtBaseMenor.Text);
                    float baseMayor = float.Parse(controlPerimetroTrapecio.txtBaseMayor.Text);
                    float ladoMenor = float.Parse(controlPerimetroTrapecio.txtLadoMenor.Text);
                    float ladoMayor = float.Parse(controlPerimetroTrapecio.txtLadoMayor.Text);
                    perimetro = baseMayor + baseMenor + ladoMayor + ladoMenor;
                    break;
                default:
                    break;
            }
            lblPerimetro.Text = perimetro.ToString();
        }
    }
}
