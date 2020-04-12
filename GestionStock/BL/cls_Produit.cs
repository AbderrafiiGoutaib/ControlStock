using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.BL
{
    class cls_Produit
    {
        private dbStockContext db = new dbStockContext();
        private Produit pr ;
        public bool ajouter_produit(string Nom_produit,int quatité_produit,string prix_produit,byte[] imagep,int idcategorie)
        {
            pr = new Produit();
            pr.Nom_Produit = Nom_produit;
            pr.Quantite_Produit = quatité_produit;
            pr.Image_Produit = imagep;
            pr.Prix_Produit = prix_produit;
           
            pr.Id_Categorie = idcategorie;
            if (db.Produits.SingleOrDefault(a => a.Nom_Produit == Nom_produit) == null)
            {
                db.Produits.Add(pr);
                db.SaveChanges();
                return true;

            }
            else
            {
                return false; 
            }
        }
        public void modifier_produit(int idp,string nomp,int quantitep,string prixp,byte[]imagep,int idcategorie)
        {
            pr = new Produit();
            pr = db.Produits.SingleOrDefault(s => s.Id_Produit == idp);
            if (pr != null)
            {
                pr.Nom_Produit = nomp;
                pr.Quantite_Produit = quantitep;
                pr.Prix_Produit = prixp;
                pr.Image_Produit = imagep;
                pr.Id_Categorie = idcategorie;
                db.SaveChanges();
            }
        }
        public void supprimer_produit(string nom)
        {

            pr = new Produit();
            pr = db.Produits.SingleOrDefault(s => s.Nom_Produit == nom);
            if (pr != null)
            {
                db.Produits.Remove(pr);
                db.SaveChanges();
            }
        }
    }
}
