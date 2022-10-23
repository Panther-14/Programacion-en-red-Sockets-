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


namespace SimpleClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Quien guarda la referencia al servidor es el CLIENTE
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*MessageService.UserManagerClient client = new MessageService.UserManagerClient();

            //Aqui implementamos el RPC
            MessageService.User user = client.GetUserById("Xx");*/

            //Console.WriteLine(user.UserName);
            PlayerManager.PlayerManagerClient cliente = new PlayerManager.PlayerManagerClient();
            try
            {
                
                var res = cliente.DoWork("Panther", "123");
                Console.WriteLine($"Respuesta -> {res}");
            }
            catch
            {
                Console.WriteLine("Hola!");
            }
            finally
            {
                cliente.Close();
            }
        }
    }
}
