using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.BL
{
    class crc_Client
    {

        private dbStockContext db = new dbStockContext();
        private Client C = new Client();
        public bool ajouter_cli( string nom , string prenom , string adresse , string telephone , string email , string ville , string pays)
        {
            C.Nom_Client = nom;
            C.Prenom_Client = prenom;
            C.Adresse_Client = adresse;
            C.Telephone_Client = telephone;
            C.Email_client = email;
            C.Ville_Client = ville;
            C.Pays_Client = pays;
            if(db.Clients.SingleOrDefault(s=>s.Nom_Client == nom && s.Prenom_Client ==prenom)== null)
            {
                db.Clients.Add(C);
                db.SaveChanges();
                return true;

            }
            else
            {
                return false;
            }
        }
        public void modifier_cli(int id, string nom, string prenom, string adresse, string telephone, string email, string ville, string pays)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if (C != null)
            {
                C.Nom_Client = nom;
                C.Prenom_Client = prenom;
                C.Adresse_Client = adresse;
                C.Telephone_Client = telephone;
                C.Email_client = email;
                C.Ville_Client = ville;
                C.Pays_Client = pays;
                db.SaveChanges();

            }

        }
        public void supprimer_client(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if (C != null)
            {
                db.Clients.Remove(C);
                db.SaveChanges();
            }










        }

    }
}
