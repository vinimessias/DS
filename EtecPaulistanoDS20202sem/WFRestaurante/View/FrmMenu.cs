using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFRestaurante.Properties;

namespace WFRestaurante
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            
           
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            if (!Settings.Default.autenticado)
            {
                this.Close();
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProdutos frmProdutos = new FrmProdutos();
                frmProdutos.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error ao abrir o formulario de Produtos. Contacte o administrador do sistema. Erro :" + ex.Message);
            }
        }
    }
}
 