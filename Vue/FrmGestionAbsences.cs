using MediaTek86.Controleur;
using MediaTek86.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.Vue
{
    public partial class FrmGestionAbsences : Form
    {
        private ControleAbsence controle;
        private Personnel personnel;
        public FrmGestionAbsences(Personnel personnel)
        {
            InitializeComponent();
            this.personnel = personnel;
            controle = new ControleAbsence();

            this.Text = "Absences de " + personnel.Nom + " " + personnel.Prenom;

            dataGridView1.DataSource = controle.GetLesAbsences(personnel);
        }
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Absence absence = (Absence)dataGridView1.CurrentRow.DataBoundItem;

                DialogResult reponse = MessageBox.Show(
                    "Voulez-vous supprimer cette absence ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo
                );

                if (reponse == DialogResult.Yes)
                {
                    controle.SupprimerAbsence(absence);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = controle.GetLesAbsences(personnel);

                    MessageBox.Show("Absence supprimée");
                }
            }
        }
        private void btModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Absence absence = (Absence)dataGridView1.CurrentRow.DataBoundItem;

                FrmModifAbsence frm = new FrmModifAbsence(absence);
                frm.ShowDialog();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = controle.GetLesAbsences(personnel);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
