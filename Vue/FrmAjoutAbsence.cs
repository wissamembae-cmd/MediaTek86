using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.Controleur;
using MediaTek86.Modele;

namespace MediaTek86.Vue
{
    public partial class FrmAjoutAbsence : Form
    {
        private ControleMotif controleMotif;
        private ControleAbsence controleAbsence;
        private Personnel personnel;
        public FrmAjoutAbsence(Personnel personnel)
        {
            InitializeComponent();

            this.personnel = personnel;
            controleMotif = new ControleMotif();
            controleAbsence = new ControleAbsence();

            cbMotif.DataSource = controleMotif.GetLesMotifs();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void btValider_Click(object sender, EventArgs e)
        {
            Motif motif = (Motif)cbMotif.SelectedItem;

            Absence absence = new Absence(
                dtpDateDebut.Value,
                dtpDateFin.Value,
                personnel,
                motif
            );

            if (dtpDateDebut.Value > dtpDateFin.Value)
            {
                MessageBox.Show("La date de début doit être avant la date de fin");
            }
            else if (controleAbsence.ChevauchementAbsence(absence))
            {
                MessageBox.Show("Cette absence chevauche une absence existante");
            }
            else
            {
                controleAbsence.AjouterAbsence(absence);
                MessageBox.Show("Absence ajoutée");
                this.Close();
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
