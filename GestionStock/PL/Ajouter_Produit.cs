using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionStock.PL
{
    public partial class Ajouter_Produit : Form
    {
        private dbStockContext db;
        private UserControl userProduit;
        public Ajouter_Produit(UserControl user)
        {
            InitializeComponent();
            db = new dbStockContext();
            this.userProduit = user;
            comboCategorie.DataSource = db.Categories.ToList();
            comboCategorie.DisplayMember = "Nom_Categorie";
            comboCategorie.ValueMember = "id_Categorie";
        }
        string testobligatoire()
        {
            if (Nomproduit.Text == "" || Nomproduit.Text == "Nom Produit")
            {
                return "Entrez  Nom Produit";
            }
            if (quantiteProduit.Text == "" || quantiteProduit.Text == "Quantité Produit")
            {
                return "Entrez  Quantité ";
            }
            if (prixProduit.Text == "" || prixProduit.Text == "Prix Produit")
            {
                return "Entrez Prix Produit";
            }
            
            if(pictureProduct.Image == null)
            {
                return "Entrez l'image du Produit";
            }
            if (comboCategorie.Text == "")
            {
                return "Entrez Categorie";
            }
            return null;



        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nomproduit_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Nomproduit_Leave(object sender, EventArgs e)
        {
            if (Nomproduit.Text == "")
            {
                Nomproduit.Text = "Nom Produit";
                Nomproduit.ForeColor = Color.White;
            }
        }

        private void Nomproduit_Enter(object sender, EventArgs e)
        {
            if (Nomproduit.Text == "Nom Produit")
            {
                Nomproduit.Text = "";
                Nomproduit.ForeColor = Color.White;
            }
        }

        private void QuantiteProduit_Leave(object sender, EventArgs e)
        {
            if (quantiteProduit.Text == "")
            {
                quantiteProduit.Text = "Quantité Produit";
                quantiteProduit.ForeColor = Color.White;
            }
        }

        private void QuantiteProduit_Enter(object sender, EventArgs e)
        {
            if (quantiteProduit.Text == "Quantité Produit")
            {
                quantiteProduit.Text = "";
                quantiteProduit.ForeColor = Color.White;
            }
        }

        private void BunifuSeparator6_Enter(object sender, EventArgs e)
        {
           
        }

        private void BunifuSeparator6_Leave(object sender, EventArgs e)
        {
           
        }

        private void Parcourir_photo_product_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureProduct.Image = Image.FromFile(op.FileName);
            }
        }

        private void Actualiser_frm_produit_Click(object sender, EventArgs e)
        {
            Nomproduit.Text = "Nom Produit";Nomproduit.ForeColor = Color.White;
            quantiteProduit.Text = "Quantité Produit"; quantiteProduit.ForeColor = Color.White;
            prixProduit.Text = "Prix Produit"; prixProduit.ForeColor = Color.White;
            comboCategorie.Text = "";
            pictureProduct.Image = null;
        }

        private void QuantiteProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void PrixProduit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void Ajouter_Produit_Load(object sender, EventArgs e)
        {

        }
        public int idproduit;
        private void Produit_enregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if(labelProduit.Text=="Ajouter Produit")
                {
                    BL.cls_Produit clproduit = new BL.cls_Produit();
                    MemoryStream mr = new MemoryStream();
                    pictureProduct.Image.Save(mr, pictureProduct.Image.RawFormat);
                    byte[] byteimageP = mr.ToArray();
                    if (clproduit.ajouter_produit(Nomproduit.Text, int.Parse(quantiteProduit.Text), prixProduit.Text, byteimageP, Convert.ToInt32(comboCategorie.SelectedValue)) == true)
                    {
                        MessageBox.Show("Produit Ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as User_List_Product).actualiserdgvproduit();
                    }
                    else
                    {
                        MessageBox.Show("Produit existe déja", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    
                    MemoryStream mr = new MemoryStream();
                    pictureProduct.Image.Save(mr, pictureProduct.Image.RawFormat);
                    byte[] byteimageP = mr.ToArray();
                    BL.cls_Produit clsproduit = new BL.cls_Produit();
                    DialogResult dr = MessageBox.Show("voulez-vous vraiment modifier ce produit", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (dr == DialogResult.Yes)
                    {   clsproduit.modifier_produit(idproduit, Nomproduit.Text, int.Parse(quantiteProduit.Text), prixProduit.Text, byteimageP, Convert.ToInt32(comboCategorie.SelectedValue));
                        MessageBox.Show("Le produit est modifier avec succes", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as User_List_Product).actualiserdgvproduit();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Le produit n'est pas modifier", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }

        private void PrixProduit_Leave(object sender, EventArgs e)
        {
            if (prixProduit.Text == "")
            {
                prixProduit.Text = "Prix Produit";
                prixProduit.ForeColor = Color.White;
            }
        }

        private void BunifuSeparator6_Load(object sender, EventArgs e)
        {

        }

        private void PrixProduit_Enter(object sender, EventArgs e)
        {
            if (prixProduit.Text == "Prix Produit")
            {
                prixProduit.Text = "";
                prixProduit.ForeColor = Color.White;
            }
        }

        private void Btnoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
