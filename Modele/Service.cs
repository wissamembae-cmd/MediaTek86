using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.Modele
{
    /// <summary>
    /// Classe métier représentant un service.
    /// </summary>
    public class Service
    {
        private int idservice;
        private string nom;

        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        public int GetIdservice()
        {
            return idservice;
        }

        public string GetNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
