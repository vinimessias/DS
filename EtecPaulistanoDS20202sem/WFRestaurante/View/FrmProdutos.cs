using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFRestaurante
{
    public partial class FrmProdutos : Form
    {
        Produto produto;
        PrivateFontCollection pfc = new PrivateFontCollection();
        Boolean imagemCapturada = false;
        public FrmProdutos()
        {
            InitializeComponent();
            produto = new Produto();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            try
            {
                imagemCapturada = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|TODOS|*.*";
                ofd.Title = "Inserir Foto";


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagemCapturada = true;
                    pictureBoxProduto.Image = Image.FromFile(ofd.FileName);
                    
             
                   

                    //produto.Categoria = (comboBoxCategoria.SelectedValue;
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            


        }

        private Byte[] TransformarImagem()
        {
            Byte[] imagem = null;
            try
            {
                      
                
                if (imagemCapturada.Equals(true))
                {
                    try
                    {
                        if (pictureBoxProduto.Image != null)
                        {
                            /********************************************************
                             * TRANSFORMANDO A IMAGEM CAPTURADA NO FORMULARIO       *
                             * PARA SER ARMAZENADA NO BANCO DE DADOS SQL            *
                             *******************************************************/
                            imagem = TransformarImagemByte(pictureBoxProduto.Image);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return imagem;
        }
        public byte[] TransformarImagemByte(Image imagem)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                imagem.Save(mStream, imagem.RawFormat);
                return mStream.ToArray();
            }
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            try
            {
                produto.Imagem = TransformarImagem();
                produto.Descrição = textBoxDescricao.Text;
                produto.Codigo = textBoxCodigo.Text;
                produto.Categoria.ID = (Int32)comboBoxCategoria.SelectedValue;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
