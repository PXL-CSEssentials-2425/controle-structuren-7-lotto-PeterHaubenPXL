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

namespace Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            string result = "";

            var rand = new Random();

            for (int i = 1; i <= 6; i++)
            {
                result += $"Getal {i}: " + rand.Next(1,46).ToString() + "\n";
            }

            resultTextBox.Text = result;
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}