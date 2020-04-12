using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestionStock.PL
{
    public partial class ajouter_modifier_client : Form
    {
        private UserControl usercli;
        public ajouter_modifier_client( UserControl userc)
        {
            InitializeComponent();
            this.usercli = userc;
        }
        string testobligatoire()
        {
            if(nomClient.Text== "" || nomClient.Text=="Nom Client")
            {
                return "Entrez  nom";
            }
            if (PrenomCli.Text == "" || PrenomCli.Text == "Prenom Client")
            {
                return "Entrez  Prenom";
            }
            if (AdresseCLI.Text == "" || AdresseCLI.Text == "Adresse Client")
            {
                return "Entrez Adresse Client";
            }
            if (EmailCli.Text == "" || EmailCli.Text == "Email Client")
            {
                return "Entrez Email Client";
            }
            if (VilleCli.Text == "" || VilleCli.Text == "Ville Client")
            {
                return "Entrez Ville Client";
            }
            if (PaysCli.Text == "" || PaysCli.Text == "Pays Client ")
            {
                return "Entrez Pays Client";
            }
            if (telephoncli.Text == "" || telephoncli.Text == "Telephone Client")
            {
                return "Entrez Telephone Client";
            }
            if (EmailCli.Text != "" || EmailCli.Text != "Email Client")
            {
                try
                {
                    new MailAddress(EmailCli.Text);
                }
                catch(Exception e)
                {
                    return "Email invalid";
                }
                
            }
            return null;
            
           

        }
        private void NomClient_Enter(object sender, EventArgs e)
        {
            if (nomClient.Text == "Nom Client")
            {
                nomClient.Text = "";
                nomClient.ForeColor = Color.White;
            }
        }

        private void PrenomCli_Enter(object sender, EventArgs e)
        {
            if (PrenomCli.Text == "Prenom Client")
            {
                PrenomCli.Text = "";
                PrenomCli.ForeColor = Color.White;
            }
        }

        private void AdresseCLI_Enter(object sender, EventArgs e)
        {
            if (AdresseCLI.Text == "Adresse Client")
            {
                AdresseCLI.Text = "";
                AdresseCLI.ForeColor = Color.White;
            }
        }

        private void Telephoncli_Enter(object sender, EventArgs e)
        {
            if (telephoncli .Text == "Telephone Client")
            {
                telephoncli.Text = "";
                telephoncli.ForeColor = Color.White;
            }
        }

        private void EmailCli_Enter(object sender, EventArgs e)
        {
            if (EmailCli.Text == "Email Client")
            {
                EmailCli.Text = "";
                EmailCli.ForeColor = Color.White;
            }
        }

        private void VilleCli_Enter(object sender, EventArgs e)
        {
            if (VilleCli.Text == "Ville Client")
            {
                VilleCli.Text = "";
                VilleCli.ForeColor = Color.White;
            }
        }

        private void PaysCli_Enter(object sender, EventArgs e)
        {
            if (PaysCli.Text == "Pays Client ")
            {
                PaysCli.Text = "";
                PaysCli.ForeColor = Color.White;
            }
        }

        private void Telephoncli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8){
                e.Handled = false;
            }
        }

        private void NomClient_Leave(object sender, EventArgs e)
        {
            if (nomClient.Text == "")
            {
                nomClient.Text = "Nom Client";
                nomClient.ForeColor = Color.White;
            }
        }

        private void PrenomCli_Leave(object sender, EventArgs e)
        {
            if (PrenomCli.Text == "")
            {
                PrenomCli.Text = "Prenom Client";
                PrenomCli.ForeColor = Color.White;
            }
        }

        private void AdresseCLI_Leave(object sender, EventArgs e)
        {
            if (AdresseCLI.Text == "")
            {
                AdresseCLI.Text = "Adresse Client";
                AdresseCLI.ForeColor = Color.White;
            }
        }

        private void Telephoncli_Leave(object sender, EventArgs e)
        {
            if (telephoncli.Text == "")
            {
                telephoncli.Text = "Telephone Client";
                telephoncli.ForeColor = Color.White;
            }
        }

        private void EmailCli_Leave(object sender, EventArgs e)
        {
            if (EmailCli.Text == "")
            {
                EmailCli.Text = "Email Client";
                EmailCli.ForeColor = Color.White;
            }
        }

        private void VilleCli_Leave(object sender, EventArgs e)
        {
            if (VilleCli.Text == "")
            {
                VilleCli.Text = "Ville Client";
                VilleCli.ForeColor = Color.White;
            }
        }

        private void PaysCli_Leave(object sender, EventArgs e)
        {
            if (PaysCli.Text == "")
            {
                PaysCli.Text = "Pays Client ";
                PaysCli.ForeColor = Color.White;
            }
        }
        public int idSelect;
        private void Btnenregitrerclient_Click(object sender, EventArgs e)
        {
            if (testobligatoire()!= null)
            {
                MessageBox.Show(testobligatoire(), " obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(label1.Text =="Ajouter Client")
            {
                BL.crc_Client crc_client = new BL.crc_Client();
                if (crc_client.ajouter_cli(nomClient.Text, PrenomCli.Text, AdresseCLI.Text, telephoncli.Text, EmailCli.Text, VilleCli.Text, PaysCli.Text) == true)
                {
                    MessageBox.Show("Client ajouter avec succés", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ( usercli as user_list_client).actualiserdata();
                }
                else
                {
                    MessageBox.Show("Nom et Prenom deja existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.crc_Client cli_cli = new BL.crc_Client();
                DialogResult R = MessageBox.Show("voulez-vous vraiment modifier ce client ", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    cli_cli.modifier_cli(idSelect, nomClient.Text, PrenomCli.Text, AdresseCLI.Text, telephoncli.Text, EmailCli.Text, VilleCli.Text, PaysCli.Text);
                    (usercli as user_list_client).actualiserdata();
                    MessageBox.Show("Client bien modifier", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Client n'a pas été modifier", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
           
        }

        private void BtnActualiserCli_Click(object sender, EventArgs e)
        {
            nomClient.Text = "Nom Client"; nomClient.ForeColor = Color.White;
            PrenomCli.Text = "Prenom Client"; PrenomCli.ForeColor = Color.White;
            AdresseCLI.Text = "Adresse Client"; AdresseCLI.ForeColor = Color.White;
            EmailCli.Text = "Email Client"; EmailCli.ForeColor = Color.White;
            PaysCli.Text = "Pays Client "; PaysCli.ForeColor = Color.White;
            VilleCli.Text = "Ville Client"; VilleCli.ForeColor = Color.White;
            telephoncli.Text = "Telephone Client"; telephoncli.ForeColor = Color.White;
        }

        private void Btnoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Telephoncli_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
