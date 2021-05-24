/**********************************************************************************************/
/*                          PROJETO CHEPASOFT
/*  AUTOR: DESENVOLVIMENTO DE SISTEMAS - ETEC PAULISTANO
/*  DATA CRIAÇÃO    : 20210301
/*  DATA ALTERAÇÃO  : 20210518 20:11
/**********************************************************************************************/
using System;
using System.Windows.Forms;
using WFRestaurante.Control;

namespace WFRestaurante
{
    public partial class FormCliente : Form
    {   
        Cliente cliente = null;
        public Boolean Novo { get; set; }
        
        public FormCliente()
        {
            InitializeComponent(); // Inicio dos componentes no formulario
            cliente = new Cliente();
            this.Novo = false;            
            dataGridViewPessoas.DataSource = cliente.Consultar("");
            this.AtualizarDados(0);
            this.ControleComponentes(false);

        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonShow.Text.Equals("Editar"))
                {
                    this.ControleComponentes(true);
                }
                else
                {
                    if (!textBoxNome.Text.Equals(""))
                    {
                        cliente.Nome = textBoxNome.Text;
                        cliente.Nascimento = dateTimePickerNascimento.Value;
                        if (this.Novo)
                        {
                            cliente.Adicionar(cliente);
                            MessageBox.Show("Cliente cadastrado com sucesso!");
                        }
                        else
                        {
                            cliente.Atualizar(cliente);
                            MessageBox.Show("Cliente alterado com sucesso!");
                        }
                                               
                        this.ControleComponentes(false);
                    }
                    else
                    {
                        MessageBox.Show("Campo Nome em branco!!!");
                    }
                    this.AtualizarDados(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: 0x2875401. Detalhe"+ex.Message);
            }
          
        }

        private void ControleComponentes(Boolean controle)
        {
            if (controle)
            {
                textBoxNome.Enabled = true;
                dateTimePickerNascimento.Enabled = true;
                buttonShow.Text = "Gravar";
                if (this.Novo)
                {
                    textBoxNome.Text = "";
                    dateTimePickerNascimento.Value = DateTime.Now;
                }
            }
            else
            {
                textBoxNome.Enabled = false;
                dateTimePickerNascimento.Enabled = false;
                dataGridViewPessoas.Columns["ID"].ReadOnly = true;
                dataGridViewPessoas.Columns["NOME"].ReadOnly = true;
                dataGridViewPessoas.Columns["TELEFONE"].ReadOnly = true;
                dataGridViewPessoas.Columns["NASCIMENTO"].ReadOnly = true;
                dataGridViewPessoas.Columns["ENDEREÇO"].ReadOnly = true;
                buttonShow.Text = "Editar";
            }
            
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                dataGridViewPessoas.DataSource = cliente.Consultar(textBoxPesquisa.Text);
                this.AtualizarDados(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Caro usuario, caso o erro persista. Entre em contato com o administrador do sistema. Erro: 0x24128. Detalhes:" + ex.Message);
            }
        }

        public void Inserir(Cliente cliente)
        {
            // Salvar dados na tabela Pessoas(Nome, DataNascimento)
                
        }
        
        private void dataGridViewPessoas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        //    MessageBox.Show("A");
            // Cada linha tem 3 colunas - id = [0], Nome = [1] e Datanascimento = [2]

       //     textBoxNome.Text = dataGridViewPessoas.CurrentRow.Cells[1].Value.ToString()                ;
        }

        private void dataGridViewPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Atribuição dos valores selecionado na Grid
            Int32 linha = Int32.Parse(dataGridViewPessoas.CurrentRow.Index.ToString());
            AtualizarDados(linha);    
        }
        public void AtualizarDados(int linha)
        {
            try
            {
                /*****************************************************************/
                /*  ATRIBUINDO VALORES PARA OS ATRIBUTOS DO OBJETO               */
                /*  CLIENTE SELECIONADOS NO DATAGRIDVIEW                         */
                /*  ALTERADO EM 20210518 20:11 - SOLICITADO POR VINICIUS MESSIAS */
                /*****************************************************************/
                cliente.Id          = (Int32)   dataGridViewPessoas.Rows[linha].Cells["ID"].Value;
                cliente.Nome        = (String)  dataGridViewPessoas.Rows[linha].Cells["NOME"].Value;
                cliente.Nascimento  = (DateTime)dataGridViewPessoas.Rows[linha].Cells["NASCIMENTO"].Value;

                /****************************************************/
                /*   ATRIBUINDO VALORES DO OBJETO CLIENTE PARA      */
                /*   OS COMPONENTES DO FORMULARIO FRMCLIENTE        */
                /****************************************************/
                textBoxNome.Text                = cliente.Nome;
                dateTimePickerNascimento.Value  = cliente.Nascimento;

                dataGridViewPessoas.Columns["ID"].DisplayIndex          = 0;
                dataGridViewPessoas.Columns["NOME"].DisplayIndex        = 1;
                dataGridViewPessoas.Columns["NASCIMENTO"].DisplayIndex  = 2;
                dataGridViewPessoas.Columns["TELEFONE"].DisplayIndex    = 3;
                dataGridViewPessoas.Columns["ENDEREÇO"].DisplayIndex    = 4;
                //.Columns[1].Width = 40;

                // dataGridViewPessoas.Columns["ID"].DisplayIndex = 0;
                //dataGridViewPessoas.Columns["ID"].DisplayIndex = 0;
                //dataGridViewPessoas.Columns["ID"].DisplayIndex = 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void labelNome_Click(object sender, EventArgs e)
        {

        }


        private void labelDataNascimento_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            try
            {
                this.Novo = true;
                this.ControleComponentes(true);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
 