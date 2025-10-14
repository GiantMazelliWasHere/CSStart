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

namespace CalcAtividade
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
private void adicionar_Click(object sender, RoutedEventArgs e)
        {
            double valor;
            if (double.TryParse(campoEntrada.Text, out valor))
            {
                if (calc.adicionaBuffer(valor))
                {
                    campoConteudo.Text += valor.ToString() + "\n";
                    campoEntrada.Clear();
                }
            }

        }

        private void soma_Click(object sender, RoutedEventArgs e)
        {
            double valor = calc.soma();
            campoResultado.Text = valor.ToString();
        }

        private void subtracao_Click(object sender, RoutedEventArgs e)
        {
            double valor = calc.subtrai();
            campoResultado.Text = valor.ToString();
        }

        private void multiplicacao_Click(object sender, RoutedEventArgs e)
        {
            double valor = calc.multiplica();
            campoResultado.Text = valor.ToString();
        }

        private void divisao_Click(object sender, RoutedEventArgs e)
        {
            double valor = calc.divide();
            campoResultado.Text = valor.ToString();
        }

        private void limpar_Click(object sender, RoutedEventArgs e)
        {
            calc = new Calculadora();
            campoConteudo.Clear();
            campoResultado.Clear();
            campoEntrada.Clear();
        }
    }
}