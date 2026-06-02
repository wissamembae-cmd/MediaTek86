using MediaTek86.Controleur;
using MediaTek86.Modele;
using System;
using System.Windows.Forms;
using MediaTek86.Modele;

namespace MediaTek86.Vue
{
    public partial class FrmGestionPersonnel : Form
    {
        private ControlePersonnel controle;
        public FrmGestionPersonnel()
        {
            InitializeComponent();
            controle = new ControlePersonnel();
            dataGridView1.DataSource = controle.GetLesPersonnels();
            cbService.DataSource = controle.GetLesServices();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            Service service = (Service)cbService.SelectedItem;

            controle.AjouterPersonnel(
                txtNom.Text,
                txtPrenom.Text,
                txtTel.Text,
                txtMail.Text,
                service.GetIdservice()
            );

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controle.GetLesPersonnels();

            MessageBox.Show("Personnel ajouté");
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Personnel personnel = (Personnel)dataGridView1.CurrentRow.DataBoundItem;

                DialogResult reponse = MessageBox.Show(
                    "Voulez-vous supprimer ce personnel ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo
                );

                if (reponse == DialogResult.Yes)
                {
                    controle.SupprimerPersonnel(personnel.Idpersonnel);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = controle.GetLesPersonnels();

                    MessageBox.Show("Personnel supprimé");
                }
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Personnel personnelSelectionne = (Personnel)dataGridView1.CurrentRow.DataBoundItem;
                Service service = (Service)cbService.SelectedItem;

                Personnel personnel = new Personnel(
                    personnelSelectionne.Idpersonnel,
                    txtNom.Text,
                    txtPrenom.Text,
                    txtTel.Text,
                    txtMail.Text,
                    service
                );

                controle.ModifierPersonnel(personnel);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = controle.GetLesPersonnels();

                MessageBox.Show("Personnel modifié");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Personnel personnel = (Personnel)dataGridView1.CurrentRow.DataBoundItem;

                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cbService.SelectedItem = personnel.Service;
            }
        }

        private void btGerer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Personnel personnel = (Personnel)dataGridView1.CurrentRow.DataBoundItem;

                FrmGestionAbsences frm = new FrmGestionAbsences(personnel);
                frm.ShowDialog();
            }
        }
    }
}
