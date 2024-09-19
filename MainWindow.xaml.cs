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

namespace EP_01___1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int contador = 0;
        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            Botón1.Content = "Activado"; 
        }

        private void checkbox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            Botón1.Content = "Desactivado!!";
        }

        private void Botón2_Click(object sender, RoutedEventArgs e)
        {
            if (checkbox.IsChecked == true){
                contador += 1;
                Label1.Content=contador.ToString();
            }
        }
    }
}