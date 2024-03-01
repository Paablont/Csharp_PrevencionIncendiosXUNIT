using Csharp_PrevencionIncendiosXUNIT.Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Csharp_PrevencionIncendiosXUNIT
{
  
    public partial class MainWindow : Window
    {
        CalculadoraCBI calc = new CalculadoraCBI();
        private double temperatura, humedadRelativa;
        private int resultado;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = calc;

        }
        private void btnCalcular(object sender, RoutedEventArgs e)
        {
            
            temperatura = calc.Temperatura;
            humedadRelativa = calc.HumedadRelativa;
            if (comprobarHumedad(humedadRelativa))
            {
                resultado = CalculadoraCBI.CalcularCBI(temperatura, humedadRelativa);
                txtCBINum.Content = resultado.ToString();
            }
            else
            {
                MessageBox.Show("La humedad relativa no puede ser menor que 0");
            }
        }

        public static bool comprobarHumedad(double humRel)
        {
            bool bien = false;
            if (humRel > 0)
            {
                bien = true;
            }
            return bien;
        }
    }
}