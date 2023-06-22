using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using TelasWpf.Helpers;
using TelasWpf.Models;

namespace TelasWpf.TelasCadastro
{
    /// <summary>
    /// Lógica interna para cadastrarFornecedor.xaml
    /// </summary>
    public partial class cadastrarFornecedor : Window
    {
        private int _id;

        private Fornecedor _fornecedor;
        public cadastrarFornecedor()
        {
            InitializeComponent();
        }
        private void btnVoltar_Click (object sender, RoutedEventArgs e)
        {
            var newWindow = new MenuPrincipal();
            newWindow.Show();
            Close();
        }

        private void btnSalvar_Click()
        {
            try
            {
                Fornecedor forn = new Fornecedor();
                txtNomForn.Text = _fornecedor.NomeFantasia;
                txtCnpjForn.Text = _fornecedor.Cnpj;
                txtRazaoSocial.Text = _fornecedor.RazaoSocial;
                txtEstadoForn.Text = _fornecedor.Estado;
                txtCidadeForn.Text = _fornecedor.Cidade;

                FornecedorDAO fornecedorDAO = new FornecedorDAO();
                fornecedorDAO.Insert(forn);
            }
        }

    }
}
