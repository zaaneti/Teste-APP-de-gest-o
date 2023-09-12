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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Faz com que o campo da senha fique com caracter especial
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.PasswordChar = '•';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtSenha.Text == "admin")
            {
                fPrincipal pagina1 = new fPrincipal();
                pagina1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = null;
                txtSenha.Text = null;
                txtUser.Focus();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
