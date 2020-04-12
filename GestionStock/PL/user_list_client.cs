using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.PL
{
    public partial class user_list_client : UserControl
    {
        private static user_list_client ulc;
        private dbStockContext db ;
        public static user_list_client instance
        {
            get
            {
                if(ulc == null)
                {
                    ulc = new user_list_client();

                }
                return ulc;
            }
        }
        public void actualiserdata()
        {
            db = new dbStockContext();
            dgvclient.Rows.Clear();
            foreach(var s in db.Clients)
            {
                dgvclient.Rows.Add(false, s.ID_Client, s.Nom_Client, s.Prenom_Client, s.Adresse_Client, s.Email_client, s.Telephone_Client, s.Ville_Client, s.Pays_Client);
            }
        }
        public string verifSelect()
        {
            int nombreDeLigne = 0;
            for(int i=0; i < dgvclient.Rows.Count; i++)
            {
                if((bool)dgvclient.Rows[i].Cells[0].Value == true)
                {
                    nombreDeLigne++;
                }
            }if(nombreDeLigne == 0)
            {
                return "selectionner le client que vous voulez";
            }
            if (nombreDeLigne >1)
            {
                return "Selectionner seulement un seul client pour modifier ";
            }
            return null;
        }
        public user_list_client()
        {
            InitializeComponent();
            db = new dbStockContext();
            txtecherche.Enabled = false; 
        }

        private void Txtecherche_Enter(object sender, EventArgs e)
        {
            if (txtecherche.Text == "Recherche")
            {
                txtecherche.Text = "";
                txtecherche.ForeColor = Color.Black;
            }
        }

        private void User_list_client_Load(object sender, EventArgs e)
        {
            actualiserdata();

        }

        private void Btnajouter_Click(object sender, EventArgs e)
        {
            PL.ajouter_modifier_client frmclient = new ajouter_modifier_client(this);
            frmclient.ShowDialog();
        }
        
        private void Btnmodifier_Click(object sender, EventArgs e)
        {
            
            PL.ajouter_modifier_client frmclient = new ajouter_modifier_client(this);
            if (verifSelect() == null)
            {
                for (int i = 0; i < dgvclient.RowCount; i++)
                {
                    if ((bool)dgvclient.Rows[i].Cells[0].Value == true)
                    {
                        frmclient.idSelect = (int)dgvclient.Rows[i].Cells[1].Value;
                        frmclient.nomClient.Text = dgvclient.Rows[i].Cells[2].Value.ToString();
                        frmclient.PrenomCli.Text = dgvclient.Rows[i].Cells[3].Value.ToString();
                        frmclient.AdresseCLI.Text = dgvclient.Rows[i].Cells[4].Value.ToString();
                        frmclient.EmailCli.Text = dgvclient.Rows[i].Cells[5].Value.ToString();
                        frmclient.telephoncli.Text = dgvclient.Rows[i].Cells[6].Value.ToString();
                        frmclient.VilleCli.Text = dgvclient.Rows[i].Cells[7].Value.ToString();
                        frmclient.PaysCli.Text= dgvclient.Rows[i].Cells[8].Value.ToString();

                    }
                }

                frmclient.label1.Text = "Modifier Client";
                frmclient.btnActualiserCli.Visible = false;
                frmclient.ShowDialog();
            }
            else
            {
                MessageBox.Show(verifSelect(), "Modifications", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Comrecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtecherche.Enabled = true;
            txtecherche.Text = "";
            if(comrecherche.Text=="Toutes les clients")
            {
                txtecherche.Enabled = false;
            }
        }

        private void Txtecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();

            var listeRecherche = db.Clients.ToList();
            if(txtecherche.Text != "")
            {
                switch (comrecherche.Text)
                {
                    case "Nom":
                        listeRecherche = listeRecherche.Where(s => s.Nom_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase)!=-1).ToList();
                        break;
                    case "Prenom":
                        listeRecherche = listeRecherche.Where(s => s.Prenom_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listeRecherche = listeRecherche.Where(s => s.Email_client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Telephone":
                        listeRecherche = listeRecherche.Where(s => s.Telephone_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listeRecherche = listeRecherche.Where(s => s.Ville_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listeRecherche = listeRecherche.Where(s => s.Pays_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Toutes les clients":
                        listeRecherche = listeRecherche.Where(s => s.Nom_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        listeRecherche = listeRecherche.Where(s => s.Prenom_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        listeRecherche = listeRecherche.Where(s => s.Email_client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        listeRecherche = listeRecherche.Where(s => s.Telephone_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        listeRecherche = listeRecherche.Where(s => s.Ville_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        listeRecherche = listeRecherche.Where(s => s.Pays_Client.IndexOf(txtecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
           
            dgvclient.Rows.Clear();
            foreach(var l in listeRecherche)
            {
                dgvclient.Rows.Add(false, l.ID_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Email_client, l.Telephone_Client, l.Ville_Client, l.Pays_Client);

            }
        }

        private void Btnsupprimer_Click(object sender, EventArgs e)
        {
            BL.crc_Client clientcli = new BL.crc_Client();
            int select = 0;
            for (int i = 0; i < dgvclient.Rows.Count; i++)
            {
                if ((bool)dgvclient.Rows[i].Cells[0].Value == true)
                {
                    
                        select++;
                    
                }

            }
            if (select == 0)
            {
                MessageBox.Show("aucun client selectionner ", "Suppression ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer", "Suppression ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvclient.Rows.Count; i++)
                    {
                        if ((bool)dgvclient.Rows[i].Cells[0].Value == true)
                        {
                            
                                clientcli.supprimer_client(int.Parse(dgvclient.Rows[i].Cells[1].Value.ToString()));
                            
                        }

                    }
                    actualiserdata();
                    MessageBox.Show("La suppression a été faite ", "Suppression ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("La suppression a été annuler", "Suppression ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            actualiserdata();
        }

        private void Txtecherche_Leave(object sender, EventArgs e)
        {
            if (txtecherche.Text == "")
            {
                txtecherche.Text = "Recherche";
                txtecherche.ForeColor = Color.Black;
            }
        }
    }
}
