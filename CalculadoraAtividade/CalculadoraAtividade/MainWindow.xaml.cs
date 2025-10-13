using System.Data.Common;
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

namespace CalculadoraAtividade
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculadora calc = new Calculadora();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void botaoAdicina_Click(object sender, RoutedEventArgs e)
        {
            double valor;
            if(double.TryParse(campoEntrada.Text, out valor))
            {
                if (calc.AdicionaBuffer(valor)){
                    textoConteudo.Text += valor.ToString() + "\n";
                    campoEntrada.Text = "";
                }
            }
        }

        private void soma_Click(object sender, RoutedEventArgs e)
        {
            double valor = calc.Somar();
            textoResposta.Text = valor.ToString();
        }

        private void subtracao_Click(object sender, RoutedEventArgs e)
        {
            double valor = calc.Sub();
            textoResposta.Text = valor.ToString();
        }

        private void multiplicacao_Click(object sender, RoutedEventArgs e)
        {
            double valor = calc.Mult();
            textoResposta.Text = valor.ToString();
        }

        private void botaoDiv_Click(object sender, RoutedEventArgs e)
        {
            double valor = calc.Div();
            textoResposta.Text = valor.ToString();
        }

        private void botaoLimpar_Click(object sender, RoutedEventArgs e)
        {
            calc = new Calculadora();
            campoEntrada.Text = "";
            textoResposta.Text = "";
            textoConteudo.Text = "";
        }
    }
}