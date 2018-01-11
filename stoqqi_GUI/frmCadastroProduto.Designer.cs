namespace stoqqi_GUI
{
    partial class frmCadastroProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.cbUnd = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbSubCategoria = new System.Windows.Forms.ComboBox();
            this.btAddCategoria = new System.Windows.Forms.Button();
            this.btAddSubCategoria = new System.Windows.Forms.Button();
            this.btAddUnidadeMedida = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btAddUnidadeMedida);
            this.pnDados.Controls.Add(this.btAddSubCategoria);
            this.pnDados.Controls.Add(this.btAddCategoria);
            this.pnDados.Controls.Add(this.cbSubCategoria);
            this.pnDados.Controls.Add(this.cbCategoria);
            this.pnDados.Controls.Add(this.cbUnd);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.txtQtde);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(27, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(27, 143);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(129, 48);
            this.txtDescricao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor de Venda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Unidade de Medida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "SubCategoria";
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(27, 231);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 12;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(27, 279);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(100, 20);
            this.txtValorPago.TabIndex = 13;
            this.txtValorPago.TextChanged += new System.EventHandler(this.txtValorPago_TextChanged);
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(162, 279);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 14;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // cbUnd
            // 
            this.cbUnd.FormattingEnabled = true;
            this.cbUnd.Location = new System.Drawing.Point(332, 162);
            this.cbUnd.Name = "cbUnd";
            this.cbUnd.Size = new System.Drawing.Size(121, 21);
            this.cbUnd.TabIndex = 15;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(332, 223);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 16;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.Location = new System.Drawing.Point(332, 279);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbSubCategoria.TabIndex = 17;
            // 
            // btAddCategoria
            // 
            this.btAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddCategoria.Location = new System.Drawing.Point(459, 215);
            this.btAddCategoria.Name = "btAddCategoria";
            this.btAddCategoria.Size = new System.Drawing.Size(30, 31);
            this.btAddCategoria.TabIndex = 18;
            this.btAddCategoria.Text = "+";
            this.btAddCategoria.UseVisualStyleBackColor = true;
            this.btAddCategoria.Click += new System.EventHandler(this.btAddCategoria_Click);
            // 
            // btAddSubCategoria
            // 
            this.btAddSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddSubCategoria.Location = new System.Drawing.Point(459, 279);
            this.btAddSubCategoria.Name = "btAddSubCategoria";
            this.btAddSubCategoria.Size = new System.Drawing.Size(30, 31);
            this.btAddSubCategoria.TabIndex = 19;
            this.btAddSubCategoria.Text = "+";
            this.btAddSubCategoria.UseVisualStyleBackColor = true;
            this.btAddSubCategoria.Click += new System.EventHandler(this.btAddSubCategoria_Click);
            // 
            // btAddUnidadeMedida
            // 
            this.btAddUnidadeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddUnidadeMedida.Location = new System.Drawing.Point(459, 154);
            this.btAddUnidadeMedida.Name = "btAddUnidadeMedida";
            this.btAddUnidadeMedida.Size = new System.Drawing.Size(30, 31);
            this.btAddUnidadeMedida.TabIndex = 20;
            this.btAddUnidadeMedida.Text = "+";
            this.btAddUnidadeMedida.UseVisualStyleBackColor = true;
            this.btAddUnidadeMedida.Click += new System.EventHandler(this.btAddUnidadeMedida_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroProduto";
            this.Text = "Stoqqi - Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSubCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbUnd;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddCategoria;
        private System.Windows.Forms.Button btAddSubCategoria;
        private System.Windows.Forms.Button btAddUnidadeMedida;
    }
}
