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
using TelasWpf.Models;

namespace TelasWpf.TelasCadastro
{
    /// <summary>
    /// Lógica interna para cadastrarMovel.xaml
    /// </summary>
    public partial class cadastrarMovel : Window
    {
        private int _id;

        private  Movel _movel;
        public cadastrarMovel()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new MenuPrincipal();
            newWindow.Show();
            Close();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Movel movel = new Movel();
                txtNomeMovel.Text = movel.Nome;
                txtMaterial.Text = movel.Material;
                txtDescriMovel.Text = movel.Descricao;
                txtPesoMovel.Text = movel.Peso;
                txtCompriMovel.Text = movel.Comprimento;
                txtCor.Text = movel.Cor;
                txtAltura.Text = movel.Altura;
                txtLargura.Text = movel.Largura;
                txtCustoMovel.Text = movel.ValorCusto;
                txtValorMovel.Text = movel.ValorTotal;

                MovelDAO movelDAO = new MovelDAO();
                movelDAO.Insert(movel);
                MessageBox.Show("O fornecedor foi adicionado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                var result = MessageBox.Show("Deseja continuar?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.No)
                {
                    this.Close();
                }
                else
                {
                    txtNomeMovel.Text = "";
                    txtMaterial.Text = "";
                    txtDescriMovel.Text = ""; 
                    txtPesoMovel.Text = "";
                    txtCompriMovel.Text = "";
                    txtCor.Text = "";        
                    txtAltura.Text = "";
                    txtLargura.Text = "";
                    txtCustoMovel.Text = "";
                    txtValorMovel.Text = "";
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Não Executado", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
