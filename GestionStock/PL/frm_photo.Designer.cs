namespace GestionStock.PL
{
    partial class frm_photo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageproduit = new System.Windows.Forms.PictureBox();
            this.labelphotoproduit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnoff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.imageproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // imageproduit
            // 
            this.imageproduit.BackColor = System.Drawing.Color.White;
            this.imageproduit.Location = new System.Drawing.Point(12, 77);
            this.imageproduit.Name = "imageproduit";
            this.imageproduit.Size = new System.Drawing.Size(332, 299);
            this.imageproduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageproduit.TabIndex = 33;
            this.imageproduit.TabStop = false;
            // 
            // labelphotoproduit
            // 
            this.labelphotoproduit.AutoSize = true;
            this.labelphotoproduit.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphotoproduit.ForeColor = System.Drawing.Color.Snow;
            this.labelphotoproduit.Location = new System.Drawing.Point(121, 9);
            this.labelphotoproduit.Name = "labelphotoproduit";
            this.labelphotoproduit.Size = new System.Drawing.Size(107, 45);
            this.labelphotoproduit.TabIndex = 34;
            this.labelphotoproduit.Text = "Photo";
            // 
            // btnoff
            // 
            this.btnoff.Activecolor = System.Drawing.Color.Empty;
            this.btnoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnoff.BackgroundImage = global::GestionStock.Properties.Resources.fermer;
            this.btnoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoff.BorderRadius = 0;
            this.btnoff.ButtonText = "";
            this.btnoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnoff.DisabledColor = System.Drawing.Color.Gray;
            this.btnoff.Iconcolor = System.Drawing.Color.Transparent;
            this.btnoff.Iconimage = null;
            this.btnoff.Iconimage_right = null;
            this.btnoff.Iconimage_right_Selected = null;
            this.btnoff.Iconimage_Selected = null;
            this.btnoff.IconMarginLeft = 0;
            this.btnoff.IconMarginRight = 0;
            this.btnoff.IconRightVisible = true;
            this.btnoff.IconRightZoom = 0D;
            this.btnoff.IconVisible = true;
            this.btnoff.IconZoom = 90D;
            this.btnoff.IsTab = false;
            this.btnoff.Location = new System.Drawing.Point(334, 0);
            this.btnoff.Name = "btnoff";
            this.btnoff.Normalcolor = System.Drawing.Color.Empty;
            this.btnoff.OnHovercolor = System.Drawing.Color.Empty;
            this.btnoff.OnHoverTextColor = System.Drawing.Color.White;
            this.btnoff.selected = false;
            this.btnoff.Size = new System.Drawing.Size(20, 20);
            this.btnoff.TabIndex = 35;
            this.btnoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnoff.Textcolor = System.Drawing.Color.White;
            this.btnoff.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff.Click += new System.EventHandler(this.Btnoff_Click);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(129, 57);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(88, 10);
            this.bunifuSeparator4.TabIndex = 36;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // frm_photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(101)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(356, 389);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.btnoff);
            this.Controls.Add(this.labelphotoproduit);
            this.Controls.Add(this.imageproduit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_photo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_photo";
            ((System.ComponentModel.ISupportInitialize)(this.imageproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imageproduit;
        private Bunifu.Framework.UI.BunifuFlatButton btnoff;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        public Bunifu.Framework.UI.BunifuCustomLabel labelphotoproduit;
    }
}