﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace stoqqi_GUI
{
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;

        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Produto";
            dgvDados.Columns[1].Width = 100;
            dgvDados.Columns[2].HeaderText = "Descrição";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Valor Pago";
            dgvDados.Columns[3].Width = 50;
            dgvDados.Columns[3].DefaultCellStyle.Format = "c";
            dgvDados.Columns[4].HeaderText = "Valor de Venda";
            dgvDados.Columns[4].Width = 50;
            dgvDados.Columns[4].DefaultCellStyle.Format = "c";
            dgvDados.Columns[5].HeaderText = "Quantidade";
            dgvDados.Columns[5].Width = 50;
            dgvDados.Columns[9].HeaderText = "Unidade de Medida";
            dgvDados.Columns[9].Width = 50;
            dgvDados.Columns[10].HeaderText = "Categoria";
            dgvDados.Columns[10].Width = 50;
            dgvDados.Columns[11].HeaderText = "SubCategoria";
            dgvDados.Columns[11].Width = 50;
            dgvDados.RowHeadersVisible = false;

            //ocultar dados
            dgvDados.Columns["cat_cod"].Visible = false;
            dgvDados.Columns["scat_cod"].Visible = false;
            dgvDados.Columns["umed_cod"].Visible = false;
            //dgvDados.Columns["pro_valorpago"].Visible = false;

        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
