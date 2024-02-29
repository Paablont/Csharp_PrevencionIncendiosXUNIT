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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculadoraCBI calc = new CalculadoraCBI();
        private double resultado;
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = calc;
            
        }
        private void btnCalcular(object sender,RoutedEventArgs e)
        {
            CalculadoraCBI c = new CalculadoraCBI
            {
                Temperatura = calc.Temperatura,
                HumedadRelativa = calc.HumedadRelativa,
            };
            resultado = c.CalcularCBI(c.Temperatura, c.HumedadRelativa);
            //N2 es un formato de ToString para que solo muestre 2 decimales
            txtCBINum.Content = resultado.ToString("N2");
        }
    }
}