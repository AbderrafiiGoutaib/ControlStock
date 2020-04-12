using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace GestionStock.PL
{
    public partial class User_List_Product : UserControl
    {
        private static User_List_Product ulc;
        private dbStockContext db;
        public static User_List_Product instance
        {
            get
            {
                if (ulc == null)
                {
                    ulc = new User_List_Product();

                }
                return ulc;
            }
        }
        public string verifSelect()
        {
            int nombreDeLigne = 0;
            for (int i = 0; i < dgvprodect.Rows.Count; i++)
            {
                if ((bool)dgvprodect.Rows[i].Cells[0].Value == true)
                {
                    nombreDeLigne++;
                }
            }
            if (nombreDeLigne == 0)
            {
                return "selectionner le Produit";
            }
            if (nombreDeLigne > 1)
            {
                return "Selectionner seulement un seul Produit";
            }
            return null;
        }
        public User_List_Product()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        public void actualiserdgvproduit()
        {
            db = new dbStockContext();
            dgvprodect.Rows.Clear();
            Categorie cat = new Categorie();
            foreach(var lis in db.Produits)
            {
                cat = db.Categories.SingleOrDefault(a => a.Id_Categorie == lis.Id_Categorie);
                if (cat != null)
                {
                    dgvprodect.Rows.Add(false, lis.Nom_Produit, lis.Nom_Produit, lis.Quantite_Produit, lis.Prix_Produit, cat.Nom_Categorie);
                }
            }
        }
        private void User_List_Product_Load(object sender, EventArgs e)
        {
            actualiserdgvproduit();
        }

        private void Recherche_prodect_Enter(object sender, EventArgs e)
        {
            if (recherche_prodect.Text == "Recherche")
            {
                recherche_prodect.Text = "";
                recherche_prodect.ForeColor = Color.Black;
            }
        }

        private void Recherche_prodect_Leave(object sender, EventArgs e)
        {
            if (recherche_prodect.Text == "")
            {
                recherche_prodect.Text = "";
            }
        }

        private void Comrecherche_prodect_SelectedIndexChanged(object sender, EventArgs e)
        {
            recherche_prodect.Enabled = true;
            recherche_prodect.Text = "";
            if (recherche_prodect.Text == "Toutes les produits")
            {
                recherche_prodect.Enabled = false;
            }
        }

        private void Ajouter_prodect_Click(object sender, EventArgs e)
        {
            PL.Ajouter_Produit frmproduit = new PL.Ajouter_Produit(this);
            frmproduit.ShowDialog();
        }

        private void Modifier_prodect_Click(object sender, EventArgs e)
        {
            Produit pr = new Produit();
            if (verifSelect() != null)
            {
                MessageBox.Show(verifSelect(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PL.Ajouter_Produit frmprd = new PL.Ajouter_Produit(this);
                frmprd.labelProduit.Text = "Modifier Produit";
                frmprd.Actualiser_frm_produit.Visible = false;
                for(int i = 0; i < dgvprodect.Rows.Count; i++)
                {
                    if ((bool)dgvprodect.Rows[i].Cells[0].Value == true)
                    {
                        string myid = dgvprodect.Rows[i].Cells[2].Value.ToString();
                        pr = db.Produits.SingleOrDefault(s => s.Nom_Produit == myid);
                        if (pr != null)
                        {
                            frmprd.comboCategorie.Text = dgvprodect.Rows[i].Cells[5].Value.ToString();
                            frmprd.Nomproduit.Text = dgvprodect.Rows[i].Cells[2].Value.ToString();
                            frmprd.quantiteProduit.Text = dgvprodect.Rows[i].Cells[3].Value.ToString();
                            frmprd.prixProduit.Text = dgvprodect.Rows[i].Cells[4].Value.ToString();
                            
                            MemoryStream ms = new MemoryStream(pr.Image_Produit);
                            frmprd.pictureProduct.Image = Image.FromStream(ms);
                        }
                            

                    }
                }
                frmprd.ShowDialog();
            }
           

        }

        private void Afficher_photo_Click(object sender, EventArgs e)
        {
            Produit pr = new Produit();
            
            if (verifSelect() != null)
            {
                MessageBox.Show(verifSelect(), "selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i < dgvprodect.Rows.Count; i++)
                {
                    if((bool)dgvprodect.Rows[i].Cells[0].Value == true)
                    {
                          string myid =dgvprodect.Rows[i].Cells[2].Value.ToString();
                        pr = db.Produits.SingleOrDefault(s => s.Nom_Produit == myid);
                        if (pr != null)
                        {
                            frm_photo frmP = new frm_photo();
                            MemoryStream ms = new MemoryStream(pr.Image_Produit);
                            frmP.imageproduit.Image = Image.FromStream(ms);
                            frmP.labelphotoproduit.Text = dgvprodect.Rows[i].Cells[2].Value.ToString();
                            frmP.ShowDialog();
                            
                        }
                    }
                }
            }
        }

        private void Supprimer_product_Click(object sender, EventArgs e)
        {
            if(verifSelect()=="selectionner le Produit")
            {
                MessageBox.Show(verifSelect(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("voulez-vous vraiment supprimer ce produit","Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    for (int i = 0; i < dgvprodect.Rows.Count; i++)
                    {
                        if ((bool)dgvprodect.Rows[i].Cells[0].Value == true)
                        {
                            BL.cls_Produit clproduit = new BL.cls_Produit();
                            string nomprod = dgvprodect.Rows[i].Cells[1].Value.ToString();
                            clproduit.supprimer_produit(nomprod);
                        }
                    }
                    actualiserdgvproduit();
                    MessageBox.Show("Le produit est supprimé avec succes","Suppression",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Le produit n'est supprimé ", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        private void Recherche_prodect_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
           
            
            var listeRecherche = db.Produits.ToList();
            
            listeRecherche = listeRecherche.Where(s => s.Nom_Produit.IndexOf(recherche_prodect.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();

            dgvprodect.Rows.Clear();
            Categorie cat = new Categorie();
            foreach (var l in listeRecherche)
            {
                cat = db.Categories.SingleOrDefault(s => s.Id_Categorie == l.Id_Categorie);
                dgvprodect.Rows.Add(false, l.Id_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit,cat.Nom_Categorie);

            }
        }

        private void Imprimer_product_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            string NomCategorie=null;
            Raport.frm_rapport frm_rpt = new Raport.frm_rapport();
            Produit pr = new Produit();
            if (verifSelect() != null)
            {
                MessageBox.Show(verifSelect(), "Imprimer Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nomselect=null;
                for (int i = 0; i < dgvprodect.Rows.Count; i++)
                {
                    if ((bool)dgvprodect.Rows[i].Cells[0].Value == true)
                    {
                        BL.cls_Produit clproduit = new BL.cls_Produit();
                         nomselect = dgvprodect.Rows[i].Cells[1].Value.ToString();
                        NomCategorie = dgvprodect.Rows[i].Cells[5].Value.ToString();

                    }
                }
                pr = db.Produits.SingleOrDefault(s => s.Nom_Produit == nomselect);
                if (pr != null)
                {
                    frm_rpt.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionStock.Raport.RPT_Produit.rdlc";
                    ReportParameter Pcate = new ReportParameter("RP_Categorie", NomCategorie);
                    ReportParameter Pnom = new ReportParameter("RP_Nom", pr.Nom_Produit);
                    ReportParameter Pquantite = new ReportParameter("RP_Quantite", pr.Quantite_Produit.ToString());
                    ReportParameter Pprix = new ReportParameter("RP_Prix", pr.Prix_Produit);
                    string ImageString = Convert.ToBase64String(pr.Image_Produit);
                    ReportParameter pimage = new ReportParameter("RP_Image", ImageString);
                    frm_rpt.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Pcate, Pnom, Pquantite, Pprix, pimage });
                    frm_rpt.reportViewer1.RefreshReport();
                    frm_rpt.ShowDialog();
                }
            }
        }
    }
}
