using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.PL
{
    public partial class frm_photo : Form
    {
        public frm_photo()
        {
            InitializeComponent();
        }

        private void Btnoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
