
namespace WFRestaurante
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxPreço = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelPreço = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.pictureBoxProduto = new System.Windows.Forms.PictureBox();
            this.buttonFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(516, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(26, 298);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(130, 26);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(188, 298);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(417, 26);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // textBoxPreço
            // 
            this.textBoxPreço.Location = new System.Drawing.Point(637, 298);
            this.textBoxPreço.Name = "textBoxPreço";
            this.textBoxPreço.Size = new System.Drawing.Size(130, 26);
            this.textBoxPreço.TabIndex = 3;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(26, 359);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(271, 28);
            this.comboBoxCategoria.TabIndex = 4;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(503, 386);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(132, 30);
            this.buttonGravar.TabIndex = 5;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(645, 386);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(132, 30);
            this.buttonFechar.TabIndex = 6;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(303, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(457, 26);
            this.textBox4.TabIndex = 7;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(22, 276);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(59, 20);
            this.labelCodigo.TabIndex = 8;
            this.labelCodigo.Text = "Código";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(181, 275);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(80, 20);
            this.labelDescricao.TabIndex = 9;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelPreço
            // 
            this.labelPreço.AutoSize = true;
            this.labelPreço.Location = new System.Drawing.Point(634, 276);
            this.labelPreço.Name = "labelPreço";
            this.labelPreço.Size = new System.Drawing.Size(50, 20);
            this.labelPreço.TabIndex = 10;
            this.labelPreço.Text = "Preço";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(22, 336);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(78, 20);
            this.labelCategoria.TabIndex = 11;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(223, 25);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(74, 20);
            this.labelPesquisa.TabIndex = 12;
            this.labelPesquisa.Text = "Pesquisa";
            // 
            // pictureBoxProduto
            // 
            this.pictureBoxProduto.Location = new System.Drawing.Point(567, 60);
            this.pictureBoxProduto.Name = "pictureBoxProduto";
            this.pictureBoxProduto.Size = new System.Drawing.Size(193, 174);
            this.pictureBoxProduto.TabIndex = 13;
            this.pictureBoxProduto.TabStop = false;
            // 
            // buttonFoto
            // 
            this.buttonFoto.Location = new System.Drawing.Point(690, 204);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(70, 30);
            this.buttonFoto.TabIndex = 14;
            this.buttonFoto.Text = "Foto";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFoto);
            this.Controls.Add(this.pictureBoxProduto);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelPreço);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textBoxPreço);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxPreço;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelPreço;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.PictureBox pictureBoxProduto;
        private System.Windows.Forms.Button buttonFoto;
    }
}