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

namespace Av30_PalavrasCruzadas
{
    public partial class MainWindow : Window
    {
        bool terminou1 = false;
        bool terminou2 = false;
        bool terminou3 = false;
        bool terminou4 = false;
        bool terminou5 = false;
        bool terminou6 = false;
        bool terminou7 = false;
        bool terminou8 = false;
        bool terminou9 = false;
        bool terminou10 = false;
        string palavra1 = "";
        string palavra2 = "";
        string palavra3 = "";
        string palavra4 = "";
        string palavra5 = "";
        string palavra6 = "";
        string palavra7 = "";
        string palavra8 = "";
        string palavra9 = "";
        string palavra10 = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(
            "O _________ é uma máquina eletrônica que permite processar dados. Capaz de obedecer a instruções que visam produzir certas transformações nesses dados para alcançar um fim determinado.",
            "Dica 1",
            MessageBoxButton.OK,
            MessageBoxImage.Information);

        }

        private void click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "É um aparelho de comunicação por ondas eletromagnéticas que permite a transmissão bidirecional de voz e dados utilizáveis em uma área geográfica que se encontra dividida em células (de onde provém a nomenclatura _______), cada uma delas servida por um transmissor/receptor.",
            "Dica 2",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "'_________ é um sistema através do qual a sociedade satisfaz as necessidades e desejos de seus membros'.Esse sistema contém equipamentos, programas, pessoas, processos, organização, e finalidade de propósito.",
            "Dica 3",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "'Mamífero australiano da ordem dos marsupiais, com os membros posteriores muito compridos, o que lhes permite a deslocação por saltos.",
            "Dica 4",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Duração relativa das coisas que cria no ser humano a ideia de presente, passado e futuro; período contínuo no qual os eventos se sucedem.",
            "Dica 5",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Conjunto de conhecimentos relativos à manutenção da saúde, bem como à prevenção, tratamento e cura das doenças, traumatismos e afecções.",
            "Dica 6",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Móvel composto por um tampo horizontal de madeira, metal, mármore ou qualquer outro material, sustido por um ou mais pés.",
            "Dica 7",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Estrutura mineralizada implantada nos alvéolos dos maxilares superior e inferior, que realiza a mastigação e auxilia a articulação dos sons e palavras.",
            "Dica 8",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click9(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Veículo que se locomove sobre rodas, para transporte de passageiros ou de cargas.",
            "Dica 9",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void click10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            "Doce de coco ralado e calda de açúcar, em ponto de rapadura, apresentado em losangos, quadrados ou em forma circular.",
            "Dica 10",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void verifica(object sender, KeyEventArgs e)
        {
            palavra1 = txtComputador1.Text + txtComputador2.Text + txtComputador3.Text + txtComputador4.Text + txtComputador5.Text + txtComputador6.Text + txtComputador7.Text + txtComputador8.Text + txtComputador9.Text + txtComputador10.Text;
            palavra1 = palavra1.ToUpper();
            logicaComputador();

            palavra2 = txtComputador1.Text + txtCelular2.Text + txtCelular3.Text + txtCelular4.Text + txtCelular5.Text + txtCelular6.Text + txtCelular7.Text;
            palavra2 = palavra2.ToUpper();
            logicaCelular();
            
            palavra3 = txtTecnologia1.Text+txtTecnologia2.Text +txtTecnologia3.Text+ txtTecnologia4.Text+ txtTecnologia5.Text+ txtTecnologia6.Text+ txtTecnologia7.Text + txtTecnologia8.Text+ txtTecnologia9.Text + txtTecnologia10.Text;
            palavra3 = palavra3.ToUpper();
            logicaTecnologia();
            
            palavra4 = txtCanguru1.Text+txtTecnologia10.Text +txtCanguru3.Text+txtCanguru4.Text +txtCanguru6.Text +txtComputador10.Text+txtCanguru7.Text;
            palavra4 = palavra4.ToUpper();
            logicaCanguru();

            palavra5 = txtComputador6.Text+txtTempo2.Text+txtTempo3.Text+txtTempo4.Text+txtTempo5.Text;
            palavra5 = palavra5.ToUpper();
            logicaTempo();

            palavra6 = txtMedicina1.Text +txtMedicina2.Text +txtMedicina3.Text+txtMedicina4.Text +txtMedicina5.Text +txtMedicina6.Text+txtMedicina7.Text+txtMedicina8.Text;
            palavra6 = palavra6.ToUpper();
            logicaMedicina();

            palavra7 = txtMesa1.Text + txtMesa2.Text + txtMesa3.Text + txtMesa4.Text;
            palavra7 = palavra7.ToUpper();
            logicaMesa();

            palavra8 = txDente1.Text + txDente2.Text + txDente3.Text + txDente4.Text + txDente5.Text;
            palavra8 = palavra8.ToUpper();
            logicaDente();

            palavra9 = txtCarro1.Text + txtCarro2.Text + txtCarro3.Text + txtCarro4.Text + txtCarro5.Text;
            palavra9 = palavra9.ToUpper();
            logicaCarro();

            palavra10 = txtCanguru1.Text+txtCocada2.Text+txtCarro1.Text +txtCocada4.Text +txDente1.Text+txtCocada6.Text;
            palavra10 = palavra10.ToUpper();
            logicaCocada();

            if(terminou9 == true && terminou8 == true && terminou7 == true && terminou6 == true && terminou5 == true && terminou4 == true && terminou3 == true && terminou2 == true && terminou10 == true && terminou1 == true)
            {
                MessageBox.Show(
                "O jogo acabou, você descobriu todas as palavras!",
                "Parabéns!",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
                Close();
            }
        }
        private void logicaComputador()
        {
            if (txtComputador1.Text.ToUpper() == "C" && txtComputador2.Text.ToUpper() == "O" && txtComputador3.Text.ToUpper() == "M" && txtComputador4.Text.ToUpper() == "P" && txtComputador5.Text.ToUpper() == "U" && txtComputador6.Text.ToUpper() == "T" && txtComputador7.Text.ToUpper() == "A" && txtComputador8.Text.ToUpper() == "D" && txtComputador9.Text.ToUpper() == "O" && txtComputador10.Text.ToUpper() == "R")
            {
                if (palavra1 == "COMPUTADOR")
                {
                    txtComputador1.Text = "C";
                    txtComputador2.Text = "O";
                    txtComputador3.Text = "M";
                    txtComputador4.Text = "P";
                    txtComputador5.Text = "U";
                    txtComputador6.Text = "T";
                    txtComputador7.Text = "A";
                    txtComputador8.Text = "D";
                    txtComputador9.Text = "O";
                    txtComputador10.Text = "R";
                    txtComputador1.Background = Brushes.Green;
                    txtComputador2.Background = Brushes.Green;
                    txtComputador3.Background = Brushes.Green;
                    txtComputador4.Background = Brushes.Green;
                    txtComputador5.Background = Brushes.Green;
                    txtComputador6.Background = Brushes.Green;
                    txtComputador7.Background = Brushes.Green;
                    txtComputador8.Background = Brushes.Green;
                    txtComputador9.Background = Brushes.Green;
                    txtComputador10.Background = Brushes.Green;
                    txtComputador1.IsEnabled = false;
                    txtComputador2.IsEnabled = false;
                    txtComputador3.IsEnabled = false;
                    txtComputador4.IsEnabled = false;
                    txtComputador5.IsEnabled = false;
                    txtComputador6.IsEnabled = false;
                    txtComputador7.IsEnabled = false;
                    txtComputador8.IsEnabled = false;
                    txtComputador9.IsEnabled = false;
                    txtComputador10.IsEnabled = false;
                    terminou1 = true;
                }
            }
        }
        private void logicaCelular()
        {
            if (txtComputador1.Text.ToUpper() == "C" && txtCelular2.Text.ToUpper() == "E" && txtCelular3.Text.ToUpper() == "L" && txtCelular4.Text.ToUpper() == "U" && txtCelular5.Text.ToUpper() == "L" && txtCelular6.Text.ToUpper() == "A" && txtCelular7.Text.ToUpper() == "R")
            {
                if (palavra2 == "CELULAR")
                {
                    txtComputador1.Text = "C";
                    txtCelular2.Text = "E";
                    txtCelular3.Text = "L";
                    txtCelular4.Text = "U";
                    txtCelular5.Text = "L";
                    txtCelular6.Text = "A";
                    txtCelular7.Text = "R";
                    txtComputador1.Background = Brushes.Green;
                    txtCelular2.Background = Brushes.Green;
                    txtCelular3.Background = Brushes.Green;
                    txtCelular4.Background = Brushes.Green;
                    txtCelular5.Background = Brushes.Green;
                    txtCelular6.Background = Brushes.Green;
                    txtCelular7.Background = Brushes.Green;
                    txtComputador1.IsEnabled = false;
                    txtCelular2.IsEnabled = false;
                    txtCelular3.IsEnabled = false;
                    txtCelular4.IsEnabled = false;
                    txtCelular5.IsEnabled = false;
                    txtCelular6.IsEnabled = false;
                    txtCelular7.IsEnabled = false;
                    terminou2 = true;
                }
            }
        }
        private void logicaTecnologia()
        {
            if (txtTecnologia1.Text.ToUpper() == "T" && txtTecnologia2.Text.ToUpper() == "E" && txtTecnologia3.Text.ToUpper() == "C" && txtTecnologia4.Text.ToUpper() == "N" && txtTecnologia5.Text.ToUpper() == "O" && txtTecnologia6.Text.ToUpper() == "L" && txtTecnologia7.Text.ToUpper() == "O" && txtTecnologia8.Text.ToUpper() == "G" && txtTecnologia9.Text.ToUpper() == "I" && txtTecnologia10.Text.ToUpper() == "A")
            {
                if (palavra3 == "TECNOLOGIA")
                {
                    txtTecnologia1.Text = "T";
                    txtTecnologia2.Text = "E";
                    txtTecnologia3.Text = "C";
                    txtTecnologia4.Text = "N";
                    txtTecnologia5.Text = "O";
                    txtTecnologia6.Text = "L";
                    txtTecnologia7.Text = "O";
                    txtTecnologia8.Text = "G";
                    txtTecnologia9.Text = "I";
                    txtTecnologia10.Text = "A";
                    txtTecnologia1.Background = Brushes.Green;
                    txtTecnologia2.Background = Brushes.Green;
                    txtTecnologia3.Background = Brushes.Green;
                    txtTecnologia4.Background = Brushes.Green;
                    txtTecnologia5.Background = Brushes.Green;
                    txtTecnologia6.Background = Brushes.Green;
                    txtTecnologia7.Background = Brushes.Green;
                    txtTecnologia8.Background = Brushes.Green;
                    txtTecnologia9.Background = Brushes.Green;
                    txtTecnologia10.Background = Brushes.Green;
                    txtTecnologia1.IsEnabled = false;
                    txtTecnologia2.IsEnabled = false;
                    txtTecnologia3.IsEnabled = false;
                    txtTecnologia4.IsEnabled = false;
                    txtTecnologia5.IsEnabled = false;
                    txtTecnologia6.IsEnabled = false;
                    txtTecnologia7.IsEnabled = false;
                    txtTecnologia8.IsEnabled = false;
                    txtTecnologia9.IsEnabled = false;
                    txtTecnologia10.IsEnabled = false;
                    terminou3 = true;
                }
            }
        }
        private void logicaCanguru()
        {
            if (txtCanguru1.Text.ToUpper() == "C" && txtTecnologia10.Text.ToUpper() == "A" && txtCanguru3.Text.ToUpper() == "N" && txtCanguru4.Text.ToUpper() == "G" && txtComputador10.Text.ToUpper() == "R" && txtCanguru6.Text.ToUpper() == "U" && txtCanguru7.Text.ToUpper() == "U")
            {
                if (palavra4 == "CANGURU")
                {
                    txtCanguru1.Text = "C";
                    txtTecnologia10.Text = "A";
                    txtCanguru3.Text = "N";
                    txtCanguru4.Text = "G";
                    txtCanguru6.Text = "U";
                    txtComputador10.Text = "R";
                    txtCanguru7.Text = "U";
                    txtComputador10.Background = Brushes.Green;
                    txtCanguru1.Background = Brushes.Green;
                    txtCanguru3.Background = Brushes.Green;
                    txtCanguru4.Background = Brushes.Green;
                    txtTecnologia10.Background = Brushes.Green;
                    txtCanguru6.Background = Brushes.Green;
                    txtCanguru7.Background = Brushes.Green;
                    txtComputador10.IsEnabled = false;
                    txtCanguru1.IsEnabled = false;
                    txtCanguru3.IsEnabled = false;
                    txtCanguru4.IsEnabled = false;
                    txtTecnologia10.IsEnabled = false;
                    txtCanguru6.IsEnabled = false;
                    txtCanguru7.IsEnabled = false;
                    terminou4 = true;
                }
            }
        }
        private void logicaTempo()
        {
            if (txtComputador6.Text.ToUpper() == "T" && txtTempo2.Text.ToUpper() == "E" && txtTempo3.Text.ToUpper() == "M" && txtTempo4.Text.ToUpper() == "P" && txtTempo5.Text.ToUpper() == "O")
            {
                if (palavra5 == "TEMPO")
                {
                    txtComputador6.Text = "T";
                    txtTempo2.Text = "E";
                    txtTempo3.Text = "M";
                    txtTempo4.Text = "P";
                    txtTempo5.Text = "O";
                    txtComputador6.Background = Brushes.Green;
                    txtTempo2.Background = Brushes.Green;
                    txtTempo3.Background = Brushes.Green;
                    txtTempo4.Background = Brushes.Green;
                    txtTempo5.Background = Brushes.Green;
                    txtComputador6.IsEnabled = false;
                    txtTempo2.IsEnabled = false;
                    txtTempo3.IsEnabled = false;
                    txtTempo4.IsEnabled = false;
                    txtTempo5.IsEnabled = false;
                    terminou5 = true;
                }
            }
        }
        private void logicaMedicina()
        {
            if (txtMedicina1.Text.ToUpper() == "M" && txtMedicina2.Text.ToUpper() == "E" && txtMedicina3.Text.ToUpper() == "D" && txtMedicina4.Text.ToUpper() == "I" && txtMedicina5.Text.ToUpper() == "C" && txtMedicina6.Text.ToUpper() == "I" && txtMedicina7.Text.ToUpper() == "N" && txtMedicina8.Text.ToUpper() == "A")
            {
                if (palavra6 == "MEDICINA")
                {
                    txtMedicina1.Text = "M";
                    txtMedicina2.Text = "E";
                    txtMedicina3.Text = "D";
                    txtMedicina4.Text = "I";
                    txtMedicina5.Text = "C";
                    txtMedicina6.Text = "I";
                    txtMedicina7.Text = "N";
                    txtMedicina8.Text = "A";
                    txtMedicina1.Background = Brushes.Green;
                    txtMedicina2.Background = Brushes.Green;
                    txtMedicina3.Background = Brushes.Green;
                    txtMedicina4.Background = Brushes.Green;
                    txtMedicina5.Background = Brushes.Green;
                    txtMedicina6.Background = Brushes.Green;
                    txtMedicina7.Background = Brushes.Green;
                    txtMedicina8.Background = Brushes.Green;
                    txtMedicina1.IsEnabled = false;
                    txtMedicina2.IsEnabled = false;
                    txtMedicina3.IsEnabled = false;
                    txtMedicina4.IsEnabled = false;
                    txtMedicina5.IsEnabled = false;
                    txtMedicina6.IsEnabled = false;
                    txtMedicina7.IsEnabled = false;
                    txtMedicina8.IsEnabled = false;
                    terminou6 = true;
                }
            }
        }
        private void logicaMesa()
        {
            if (txtMesa1.Text.ToUpper() == "M" && txtMesa2.Text.ToUpper() == "E" && txtMesa3.Text.ToUpper() == "S" && txtMesa4.Text.ToUpper() == "A")
            {
                if (palavra7 == "MESA")
                {
                    txtMesa1.Text = "M";
                    txtMesa2.Text = "E";
                    txtMesa3.Text = "S";
                    txtMesa4.Text = "A";
                    txtMesa1.Background = Brushes.Green;
                    txtMesa2.Background = Brushes.Green;
                    txtMesa3.Background = Brushes.Green;
                    txtMesa4.Background = Brushes.Green;
                    txtMesa1.IsEnabled = false;
                    txtMesa2.IsEnabled = false;
                    txtMesa3.IsEnabled = false;
                    txtMesa4.IsEnabled = false;
                    terminou7 = true;
                }
            }
        }
        private void logicaDente()
        {
            if (txDente1.Text.ToUpper() == "D" && txDente2.Text.ToUpper() == "E" && txDente3.Text.ToUpper() == "N" && txDente4.Text.ToUpper() == "T" && txDente5.Text.ToUpper() == "E")
            {
                if (palavra8 == "DENTE")
                {
                    txDente1.Text = "D";
                    txDente2.Text = "E";
                    txDente3.Text = "N";
                    txDente4.Text = "T";
                    txDente5.Text = "E";
                    txDente1.Background = Brushes.Green;
                    txDente2.Background = Brushes.Green;
                    txDente3.Background = Brushes.Green;
                    txDente4.Background = Brushes.Green;
                    txDente5.Background = Brushes.Green;
                    txDente1.IsEnabled = false;
                    txDente2.IsEnabled = false;
                    txDente3.IsEnabled = false;
                    txDente4.IsEnabled = false;
                    txDente5.IsEnabled = false;
                    terminou8 = true;
                }
            }
        }
        private void logicaCarro()
        {
            if (txtCarro1.Text.ToUpper() == "C" && txtCarro2.Text.ToUpper() == "A" && txtCarro3.Text.ToUpper() == "R" && txtCarro4.Text.ToUpper() == "R" && txtCarro5.Text.ToUpper() == "O")
            {
                if (palavra9 == "CARRO")
                {
                    txtCarro1.Text = "C";
                    txtCarro2.Text = "A";
                    txtCarro3.Text = "R";
                    txtCarro4.Text = "R";
                    txtCarro5.Text = "O";
                    txtCarro1.Background = Brushes.Green;
                    txtCarro2.Background = Brushes.Green;
                    txtCarro3.Background = Brushes.Green;
                    txtCarro4.Background = Brushes.Green;
                    txtCarro5.Background = Brushes.Green;
                    txtCarro1.IsEnabled = false;
                    txtCarro2.IsEnabled = false;
                    txtCarro3.IsEnabled = false;
                    txtCarro4.IsEnabled = false;
                    txtCarro5.IsEnabled = false;
                    terminou9 = true;
                }
            }
        }
        private void logicaCocada()
        {
            if (txtCanguru1.Text.ToUpper() == "C" && txtCocada2.Text.ToUpper() == "O" && txtCarro1.Text.ToUpper() == "C" && txtCocada4.Text.ToUpper() == "A" && txDente1.Text.ToUpper() == "D" && txtCocada6.Text.ToUpper()=="A")
            {
                if (palavra10 == "COCADA")
                {
                    txtCanguru1.Text = "C";
                    txtCocada2.Text = "O";
                    txtCarro1.Text = "C";
                    txtCocada4.Text = "A";
                    txDente1.Text = "D";
                    txtCocada6.Text = "A";
                    txtCanguru1.Background = Brushes.Green;
                    txtCocada2.Background = Brushes.Green;
                    txtCarro1.Background = Brushes.Green;
                    txtCocada4.Background = Brushes.Green;
                    txDente1.Background = Brushes.Green;
                    txtCocada6.Background = Brushes.Green;
                    txtCanguru1.IsEnabled = false;
                    txtCocada2.IsEnabled = false;
                    txtCarro1.IsEnabled = false;
                    txtCocada4.IsEnabled = false;
                    txDente1.IsEnabled = false;
                    txtCocada6.IsEnabled = false;
                    terminou10 = true;
                }
            }
        }
    }
}
