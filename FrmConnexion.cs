using MediaTek86.Controleur;
using MediaTek86.Vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
{
    public partial class FrmConnexion : Form
    {
        private ControleConnexion controle;
        public FrmConnexion()
        {
            InitializeComponent();
            controle = new ControleConnexion();
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string pwd = txtPwd.Text;

            if (controle.ControleAuthentification(login, pwd))
            {
                FrmGestionPersonnel frm = new FrmGestionPersonnel();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect");
            }
        }
    }
}
