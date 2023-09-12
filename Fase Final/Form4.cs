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
    public partial class editFunc : Form
    {
        public editFunc()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancodDadosDataSet.Funcionários' table. You can move, or remove it, as needed.
            this.funcionáriosTableAdapter.Fill(this.bancodDadosDataSet.Funcionários);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            funcionáriosBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            funcionáriosBindingSource.MoveNext();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            funcionáriosBindingSource.RemoveCurrent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            funcionáriosBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                funcionáriosBindingSource.EndEdit();
                funcionáriosTableAdapter.Update(bancodDadosDataSet);
                MessageBox.Show("Dados Salvos com Sucesso!", "Informação:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Os Dados não foram Salvos" + ex.Message);
            }
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            seletorED retorno2 = new seletorED();
            retorno2.Show();
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            fPrincipal retorno = new fPrincipal();
            retorno.Show();
            this.Close();
        }
    }
}
