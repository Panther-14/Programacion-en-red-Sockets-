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
using System.ServiceModel;

namespace ClienteCalculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, CalculadoraService.ICalculatorServiceCallback
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Response(int result)
        {
            this.txtResultado.Text = result.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InstanceContext context = new InstanceContext(this);
            CalculadoraService.CalculatorServiceClient client = new CalculadoraService.CalculatorServiceClient(context);
            client.Sum(2, 4);
        }
    }
}
