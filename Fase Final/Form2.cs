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
    public partial class fPrincipal : Form
    {
        public fPrincipal()
        {
            InitializeComponent();
        }
        //Abrir o Editor de Banco de Dados
        private void btnEdit_Click(object sender, EventArgs e)
        {
            seletorED editor = new seletorED();
            editor.Show();
            this.Close();
        }
        //Fechar a Janela Atual
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
