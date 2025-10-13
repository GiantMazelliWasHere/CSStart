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

namespace CalculadoraWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculadoraCore core = new CalculadoraCore();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void processa_Click(object sender, RoutedEventArgs e)
        {
            
            double valor = core.Processa();
            
            textoSaida.Text = valor.ToString();
        }

        private void botaoBuffer_Click(object sender, RoutedEventArgs e)
        {
            double valor = double.Parse(campoEntrada.Text);

            if(double.TryParse(campoEntrada.Text, out valor)){
                if (core.AdicionaBuffer(valor))
                {
                    conteudo.Text += valor.ToString() + "\n";
                    campoEntrada.Text = "";
                }
            }   
        }

        private void campoEntrada_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            core = new CalculadoraCore();
            campoEntrada.Text = String.Empty;
            textoSaida.Text = String.Empty;
            conteudo.Text = String.Empty;
        }
    }
}