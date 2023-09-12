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
    public partial class seletorED : Form
    {
        public seletorED()
        {
            InitializeComponent();
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
           editFunc editorFNC = new editFunc();
           editorFNC.Show(); 
           this.Close();
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            EquiBD equiBD = new EquiBD();
            equiBD.Show();
            this.Close();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fPrincipal home = new fPrincipal();
            home.Show();
            this.Close();
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            veiBD veiculos = new veiBD();
            veiculos.Show();
            this.Close();
        }
    }
}
