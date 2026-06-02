using MediaTek86.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediaTek86.Modele
{

    /// <summary>
    /// Classe métier représentant un personnel.
    /// </summary>
    public class Personnel
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private Service service;
        public int Idpersonnel { get { return idpersonnel; } }
        public string Nom { get { return nom; } }
        public string Prenom { get { return prenom; } }
        public string Tel { get { return tel; } }
        public string Mail { get { return mail; } }
        public Service Service { get { return service; } }
        public string NomService { get { return service.GetNom(); } }

        /// <summary>
        /// Constructeur de la classe Personnel.
        /// </summary>
        /// <param name="idpersonnel">Identifiant du personnel.</param>
        /// <param name="nom">Nom du personnel.</param>
        /// <param name="prenom">Prénom du personnel.</param>
        /// <param name="tel">Téléphone du personnel.</param>
        /// <param name="mail">Mail du personnel.</param>
        /// <param name="service">Service du personnel.</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.service = service;
        }

        public int GetIdpersonnel()
        {
            return idpersonnel;
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetPrenom()
        {
            return prenom;
        }

        public string GetTel()
        {
            return tel;
        }

        public string GetMail()
        {
            return mail;
        }

        public Service GetService()
        {
            return service;
        }

    }
}
