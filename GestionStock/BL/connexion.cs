using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.BL
{
    class connexion
    {
        public bool verifconnexion(dbStockContext db , string nom , string motdepasse)
        {
            Utulisateur user = new Utulisateur();
            user.Nom_Utilisateur = nom;
            user.Mot_de_passe = motdepasse;
            if(db.Utulisateurs.SingleOrDefault(s=>s.Nom_Utilisateur==nom && s.Mot_de_passe == motdepasse) != null)
            {
                return  true;
            }
            else
            {
                return false;
            }
        } 
    }
}
