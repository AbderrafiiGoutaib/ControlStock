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
    public partial class Menu : Form
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
        public Menu()
        {
            InitializeComponent();
            bunifuGradientPanel2.Visible = false;
             pan1.Size = new Size(212, 463);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void desactivermenu()
        {
            btnprofil.Enabled = false;
            btnproduit.Enabled = false;
            btncommende.Enabled = false;
            btncategorie.Enabled = false;
            deconnecter.Enabled = false;
            copie.Enabled = false;
            connecter.Enabled = true;
            btnutilisateur.Enabled = false;
            
        }
        public void activermenu()
        {

            btnprofil.Enabled = true;
            btnproduit.Enabled = true;
            btncommende.Enabled = true;
            btncategorie.Enabled = true;
            deconnecter.Enabled = true;
            copie.Enabled = true;
            connecter.Enabled = false;
            btnutilisateur.Enabled = true;
           bunifuGradientPanel2.Visible = false;
            
        }
        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
           /* panelbut.Top = btnprofil.Top;*/
        }

      

        private void Menu_Load(object sender, EventArgs e)
        {
            desactivermenu();
        }

     

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Size = new Size(164, 178);
            bunifuGradientPanel2.Visible = !bunifuGradientPanel2.Visible;
        }

        private void Btnoff_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuFlatButton2_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Connecter_Click(object sender, EventArgs e)
        {
            login log = new login(this);
            log.ShowDialog();
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btnprofil_Click(object sender, EventArgs e)
        {
            panel3.Top = btnprofil.Top;
            if (!pnlfichier.Controls.Contains(user_list_client.instance))
            {
                pnlfichier.Controls.Add(user_list_client.instance);
                user_list_client.instance.Dock = DockStyle.Fill;
                user_list_client.instance.BringToFront();
            }
            else
            {
                user_list_client.instance.BringToFront();
            }
        }

        private void Btnproduit_Click_1(object sender, EventArgs e)
        {
            panel3.Top = btnproduit.Top;
            if (!pnlfichier.Controls.Contains(User_List_Product.instance))
            {
                pnlfichier.Controls.Add(User_List_Product.instance);
                User_List_Product.instance.Dock = DockStyle.Fill;
                User_List_Product.instance.BringToFront();
            }
            else
            {
                User_List_Product.instance.BringToFront();
            }
        }

        private void Btncommende_Click_1(object sender, EventArgs e)
        {
            panel3.Top = btncommende.Top;
        }

        private void Btncategorie_Click_1(object sender, EventArgs e)
        {
            panel3.Top = btncategorie.Top;
        }

        private void Reduit_Click(object sender, EventArgs e)
        {
          
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            if (pan1.Width == 212)
            {
                pan1.Size = new Size(77, 463);
            }
            else
            {
                pan1.Size = new Size(212, 463);
            }
        }

        private void Deconnecter_Click(object sender, EventArgs e)
        {
            desactivermenu();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel3.Top = btnutilisateur.Top;
        }
    }
}
