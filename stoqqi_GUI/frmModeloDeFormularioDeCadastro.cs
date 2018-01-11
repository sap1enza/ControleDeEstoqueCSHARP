using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoqqi_GUI
{
    public partial class frmModeloDeFormularioDeCadastro : Form
    {

        public String operacao;

        public frmModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            // op = operações que serão feitas com os botões
            // 1 = Preparar os botoes para inserir e localizar
            // 2 = preparar os botoes para inserir/alterar um registro
            // 3 = preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }

            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }

            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }


        private void frmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void frmModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // |- avança para o próximo botão, entretanto, não realiza a ação do botão.
                //this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
                btSalvar.PerformClick();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
