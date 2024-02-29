using Csharp_PrevencionIncendiosXUNIT.Model;
using Csharp_PrevencionIncendiosXUNIT.ViewModel;
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
        private CalculadoraModelView calcu = new CalculadoraModelView();
        private double resultado;
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = calcu;
        }
        private void btnCalcular(object sender,RoutedEventArgs e)
        {
            CalculadoraCBI c = new CalculadoraCBI
            {
                Temperatura = calcu.Temperatura,
                HumedadRelativa = calcu.HumedadRelativa,
            };
            resultado = c.CalcularCBI(c.Temperatura, c.HumedadRelativa);
            txtCBINum.Content = resultado.ToString();
        }
    }
}