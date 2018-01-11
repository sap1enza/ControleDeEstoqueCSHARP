namespace stoqqi_GUI
{
    partial class frmModeloDeFormularioDeCadastro
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
            this.pnDados = new System.Windows.Forms.Panel();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btInserir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Location = new System.Drawing.Point(12, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(760, 424);
            this.pnDados.TabIndex = 0;
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btInserir);
            this.pnBotoes.Controls.Add(this.btCancelar);
            this.pnBotoes.Controls.Add(this.btSalvar);
            this.pnBotoes.Controls.Add(this.btExcluir);
            this.pnBotoes.Controls.Add(this.btAlterar);
            this.pnBotoes.Controls.Add(this.btLocalizar);
            this.pnBotoes.Location = new System.Drawing.Point(12, 457);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(760, 92);
            this.pnBotoes.TabIndex = 1;
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Image = global::stoqqi_GUI.Properties.Resources.Novo;
            this.btInserir.Location = new System.Drawing.Point(18, 10);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(70, 70);
            this.btInserir.TabIndex = 5;
            this.btInserir.Text = "Inserir";
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInserir.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Image = global::stoqqi_GUI.Properties.Resources.Cancelar;
            this.btCancelar.Location = new System.Drawing.Point(663, 10);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(70, 70);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Image = global::stoqqi_GUI.Properties.Resources.Salvar1_fw;
            this.btSalvar.Location = new System.Drawing.Point(534, 10);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(70, 70);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = global::stoqqi_GUI.Properties.Resources.Excluir;
            this.btExcluir.Location = new System.Drawing.Point(405, 10);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(70, 70);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.Image = global::stoqqi_GUI.Properties.Resources.Alterar;
            this.btAlterar.Location = new System.Drawing.Point(276, 10);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(70, 70);
            this.btAlterar.TabIndex = 1;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizar.Image = global::stoqqi_GUI.Properties.Resources.localizar_fw;
            this.btLocalizar.Location = new System.Drawing.Point(147, 10);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(70, 70);
            this.btLocalizar.TabIndex = 0;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // frmModeloDeFormularioDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.KeyPreview = true;
            this.Name = "frmModeloDeFormularioDeCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stoqqi";
            this.Load += new System.EventHandler(this.frmModeloDeFormularioDeCadastro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmModeloDeFormularioDeCadastro_KeyDown);
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnDados;
        protected System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btInserir;
        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btLocalizar;
    }
}