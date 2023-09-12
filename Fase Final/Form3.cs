using Fase_Final.BancodDadosDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase_Final
{
    public partial class EquiBD : Form
    {
        public EquiBD()
        {
            InitializeComponent();
        }

        private void EquiBD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancodDadosDataSet.Equipamentos' table. You can move, or remove it, as needed.
            this.equipamentosTableAdapter.Fill(this.bancodDadosDataSet.Equipamentos);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            equipamentosBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            equipamentosBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            equipamentosBindingSource.RemoveCurrent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            equipamentosBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                equipamentosBindingSource.EndEdit();
                equipamentosTableAdapter.Update(bancodDadosDataSet);
                MessageBox.Show("Dados Salvos com Sucesso!", "Informação:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Os Dados não foram Salvos" + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            seletorED retornar = new seletorED();
            retornar.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            fPrincipal fechar = new fPrincipal();
            fechar.Show();
            this.Close();
        }
    }
}
