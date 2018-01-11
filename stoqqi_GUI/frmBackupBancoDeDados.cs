﻿using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferramentas;

namespace stoqqi_GUI
{
    public partial class frmBackupBancoDeDados : Form
    {
        public frmBackupBancoDeDados()
        {
            InitializeComponent();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User=" +
                        DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.BackupDataBase(conexao, nomeBanco, localBackup);
                    MessageBox.Show("Backup Realizado com Sucesso");
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User=" +
                        DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.RestauraDatabase(conexao, nomeBanco, localBackup);
                    MessageBox.Show("Backup restaurado com Sucesso");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
