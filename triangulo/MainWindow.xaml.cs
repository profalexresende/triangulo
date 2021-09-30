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

namespace triangulo
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

        private void btnVerificar_Click(object sender, RoutedEventArgs e)
        {
            int lado1, lado2, lado3;
            string tipoTriangulo;

            lado1 = Convert.ToInt32(txtLado1.Text);
            lado2 = Convert.ToInt32(txtLado2.Text);
            lado3 = Convert.ToInt32(txtLado3.Text);

            //VERIFICAR SE OS VALORES FORMAM UM TRIANGULO
            if(lado1<lado2+lado3 && lado2<lado1+lado3 && lado3 < lado1 + lado2)
            {
                //BLOCO VERDADEIRO: OS LADOS FORMAM UM TRIÂNGULO
                //CHECAR O TIPO DE TRIANGULO FORMADO
                if(lado1==lado2 && lado2 == lado3)
                {
                    tipoTriangulo = "Equilátero";
                }
                else if (lado1 != lado2 && lado2 != lado3 && lado1!= lado3)
                {
                    tipoTriangulo = "Escaleno";
                }
                else
                {
                    tipoTriangulo = "Isósceles";
                }
                MessageBox.Show("Os lados informados formam um triângulo " + tipoTriangulo, "Atenção",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }

            else
            {
                //BLOCO FALSO: OS LADOS NÃO FORMAM UM TRIANGULO
                MessageBox.Show("Os lados informados não formam um triângulo!", "Atenção",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
