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
    public partial class FrmModifAbsence : Form
    {
        private Absence ancienneAbsence;
        private ControleAbsence controleAbsence;
        private ControleMotif controleMotif;
        public FrmModifAbsence(Absence absence)
        {
            InitializeComponent();

            ancienneAbsence = absence;
            controleAbsence = new ControleAbsence();
            controleMotif = new ControleMotif();

            cbMotif.DataSource = controleMotif.GetLesMotifs();

            dtpDateDebut.Value = absence.Datedebut;
            dtpDateFin.Value = absence.Datefin;
            cbMotif.SelectedItem = absence.LeMotif;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btValider_Click(object sender, EventArgs e)
        {
            Motif motif = (Motif)cbMotif.SelectedItem;

            Absence nouvelleAbsence = new Absence(
                dtpDateDebut.Value,
                dtpDateFin.Value,
                ancienneAbsence.GetPersonnel(),
                motif
            );

            if (dtpDateDebut.Value > dtpDateFin.Value)
            {
                MessageBox.Show("La date de début doit être avant la date de fin");
            }
            else if (controleAbsence.ChevauchementModification(ancienneAbsence, nouvelleAbsence))
            {
                MessageBox.Show("Cette absence chevauche une absence existante");
            }
            else
            {
                controleAbsence.ModifierAbsence(ancienneAbsence, nouvelleAbsence);
                MessageBox.Show("Absence modifiée");
                this.Close();
            }


        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
