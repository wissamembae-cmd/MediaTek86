using MediaTek86.dal;
using MediaTek86.Modele;
using System.Collections.Generic;

namespace MediaTek86.Controleur
{
    public class ControlePersonnel
    {

        private PersonnelAccess personnelAccess;
        private ServiceAccess serviceAccess;

        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        public ControlePersonnel()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
        }
        public void AjouterPersonnel(string nom, string prenom, string tel, string mail, int idservice)
        {
            personnelAccess.AjouterPersonnel(nom, prenom, tel, mail, idservice);
        }
        public void SupprimerPersonnel(int idpersonnel)
        {
            personnelAccess.SupprimerPersonnel(idpersonnel);
        }
        public void ModifierPersonnel(Personnel personnel)
        {
            personnelAccess.ModifierPersonnel(personnel);
        }
    }

}