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
using System.Windows.Shapes;

namespace TelasWpf.TelasCadastro
{
    /// <summary>
    /// Lógica interna para MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new cadastrarServico();
            newWindow.Show();
            Close();
        }
        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new cadastroCliente();
            newWindow.Show();
            Close();
        }
        private void btnFuncionario_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new cadastrarFuncionario();
            newWindow.Show();
            Close();
        }
        private void btnMovel_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new cadastrarMovel();
            newWindow.Show();
            Close();
        }

        private void btnFornecedor_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new cadastrarFornecedor();
            newWindow.Show();
            Close();
        }

    }
}
