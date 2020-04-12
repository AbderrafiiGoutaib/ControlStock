using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GestionStock.PL
{
    public partial class login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );

        private  dbStockContext db;
        private Form frmmenu;
         BL.connexion c = new BL.connexion();
       
        public login(Form Menu)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.frmmenu = Menu;
            db = new dbStockContext();
            
        }
        string testobli()
        {
            if (textBox1.Text == "" || textBox1.Text == "Utilisateur")
            {
                return "Entrez votre nom";
            }
            if (textBox2.Text == "" || textBox2.Text == "Mot de passe")
            {
                return "Entrez votre mot de passe";
            }
            return null;
        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Utilisateur";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Mot de passe";
                textBox2.ForeColor = Color.Silver;
            }
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Utilisateur")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.WhiteSmoke;
            }
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mot de passe")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = false;
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = Color.WhiteSmoke;
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (testobli() == null)
            {
                if (c.verifconnexion(db, textBox1.Text, textBox2.Text)==true)
                {
                    (frmmenu as Menu).activermenu();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("la connecxion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(testobli(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Btnoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

