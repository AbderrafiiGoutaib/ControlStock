namespace GestionStock.PL
{
    partial class User_List_Product
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_List_Product));
            this.dgvprodect = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.recherche_prodect = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.supprimer_product = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Modifier_prodect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ajouter_prodect = new Bunifu.Framework.UI.BunifuThinButton2();
            this.afficher_photo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Imprimer_product = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodect)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvprodect
            // 
            this.dgvprodect.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvprodect.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvprodect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvprodect.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvprodect.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvprodect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvprodect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvprodect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(101)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprodect.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvprodect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Id,
            this.Nom,
            this.Quantité,
            this.Prix_Produit,
            this.Categorie});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvprodect.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvprodect.DoubleBuffered = true;
            this.dgvprodect.EnableHeadersVisualStyles = false;
            this.dgvprodect.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(101)))), ((int)(((byte)(151)))));
            this.dgvprodect.HeaderForeColor = System.Drawing.Color.White;
            this.dgvprodect.Location = new System.Drawing.Point(3, 172);
            this.dgvprodect.Name = "dgvprodect";
            this.dgvprodect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprodect.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvprodect.RowHeadersVisible = false;
            this.dgvprodect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvprodect.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvprodect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprodect.Size = new System.Drawing.Size(941, 307);
            this.dgvprodect.TabIndex = 27;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.Name = "Quantité";
            // 
            // Prix_Produit
            // 
            this.Prix_Produit.HeaderText = "Prix";
            this.Prix_Produit.Name = "Prix_Produit";
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.Name = "Categorie";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(275, 111);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(366, 21);
            this.bunifuSeparator2.TabIndex = 25;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // recherche_prodect
            // 
            this.recherche_prodect.BackColor = System.Drawing.SystemColors.Control;
            this.recherche_prodect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recherche_prodect.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic);
            this.recherche_prodect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.recherche_prodect.Location = new System.Drawing.Point(275, 92);
            this.recherche_prodect.Multiline = true;
            this.recherche_prodect.Name = "recherche_prodect";
            this.recherche_prodect.Size = new System.Drawing.Size(366, 30);
            this.recherche_prodect.TabIndex = 24;
            this.recherche_prodect.Text = "Recherche";
            this.recherche_prodect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recherche_prodect.TextChanged += new System.EventHandler(this.Recherche_prodect_TextChanged);
            this.recherche_prodect.Enter += new System.EventHandler(this.Recherche_prodect_Enter);
            this.recherche_prodect.Leave += new System.EventHandler(this.Recherche_prodect_Leave);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 137);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(941, 27);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(3, 68);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(941, 27);
            this.bunifuSeparator4.TabIndex = 22;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 30;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = " Supprimer";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 30;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(915, 16);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(29, 44);
            this.bunifuThinButton21.TabIndex = 28;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supprimer_product
            // 
            this.supprimer_product.ActiveBorderThickness = 1;
            this.supprimer_product.ActiveCornerRadius = 30;
            this.supprimer_product.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.supprimer_product.ActiveForecolor = System.Drawing.Color.White;
            this.supprimer_product.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.supprimer_product.BackColor = System.Drawing.SystemColors.Control;
            this.supprimer_product.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("supprimer_product.BackgroundImage")));
            this.supprimer_product.ButtonText = "        Supprimer";
            this.supprimer_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supprimer_product.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.supprimer_product.IdleBorderThickness = 1;
            this.supprimer_product.IdleCornerRadius = 30;
            this.supprimer_product.IdleFillColor = System.Drawing.Color.White;
            this.supprimer_product.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.supprimer_product.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.supprimer_product.Location = new System.Drawing.Point(490, 5);
            this.supprimer_product.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.supprimer_product.Name = "supprimer_product";
            this.supprimer_product.Size = new System.Drawing.Size(191, 65);
            this.supprimer_product.TabIndex = 21;
            this.supprimer_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.supprimer_product.Click += new System.EventHandler(this.Supprimer_product_Click);
            // 
            // Modifier_prodect
            // 
            this.Modifier_prodect.ActiveBorderThickness = 1;
            this.Modifier_prodect.ActiveCornerRadius = 30;
            this.Modifier_prodect.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Modifier_prodect.ActiveForecolor = System.Drawing.Color.White;
            this.Modifier_prodect.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Modifier_prodect.BackColor = System.Drawing.SystemColors.Control;
            this.Modifier_prodect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Modifier_prodect.BackgroundImage")));
            this.Modifier_prodect.ButtonText = "Modifier";
            this.Modifier_prodect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modifier_prodect.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier_prodect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Modifier_prodect.IdleBorderThickness = 1;
            this.Modifier_prodect.IdleCornerRadius = 30;
            this.Modifier_prodect.IdleFillColor = System.Drawing.Color.White;
            this.Modifier_prodect.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Modifier_prodect.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Modifier_prodect.Location = new System.Drawing.Point(275, 5);
            this.Modifier_prodect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Modifier_prodect.Name = "Modifier_prodect";
            this.Modifier_prodect.Size = new System.Drawing.Size(191, 65);
            this.Modifier_prodect.TabIndex = 20;
            this.Modifier_prodect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Modifier_prodect.Click += new System.EventHandler(this.Modifier_prodect_Click);
            // 
            // ajouter_prodect
            // 
            this.ajouter_prodect.ActiveBorderThickness = 1;
            this.ajouter_prodect.ActiveCornerRadius = 30;
            this.ajouter_prodect.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.ajouter_prodect.ActiveForecolor = System.Drawing.Color.White;
            this.ajouter_prodect.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.ajouter_prodect.BackColor = System.Drawing.SystemColors.Control;
            this.ajouter_prodect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ajouter_prodect.BackgroundImage")));
            this.ajouter_prodect.ButtonText = "Ajouter";
            this.ajouter_prodect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ajouter_prodect.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_prodect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.ajouter_prodect.IdleBorderThickness = 1;
            this.ajouter_prodect.IdleCornerRadius = 30;
            this.ajouter_prodect.IdleFillColor = System.Drawing.Color.White;
            this.ajouter_prodect.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.ajouter_prodect.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.ajouter_prodect.Location = new System.Drawing.Point(62, 5);
            this.ajouter_prodect.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ajouter_prodect.Name = "ajouter_prodect";
            this.ajouter_prodect.Size = new System.Drawing.Size(191, 65);
            this.ajouter_prodect.TabIndex = 19;
            this.ajouter_prodect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ajouter_prodect.Click += new System.EventHandler(this.Ajouter_prodect_Click);
            // 
            // afficher_photo
            // 
            this.afficher_photo.ActiveBorderThickness = 1;
            this.afficher_photo.ActiveCornerRadius = 30;
            this.afficher_photo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.afficher_photo.ActiveForecolor = System.Drawing.Color.White;
            this.afficher_photo.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.afficher_photo.BackColor = System.Drawing.SystemColors.Control;
            this.afficher_photo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("afficher_photo.BackgroundImage")));
            this.afficher_photo.ButtonText = "       Afficher Photo";
            this.afficher_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.afficher_photo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher_photo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.afficher_photo.IdleBorderThickness = 1;
            this.afficher_photo.IdleCornerRadius = 30;
            this.afficher_photo.IdleFillColor = System.Drawing.Color.White;
            this.afficher_photo.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.afficher_photo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.afficher_photo.Location = new System.Drawing.Point(703, 5);
            this.afficher_photo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.afficher_photo.Name = "afficher_photo";
            this.afficher_photo.Size = new System.Drawing.Size(191, 65);
            this.afficher_photo.TabIndex = 29;
            this.afficher_photo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.afficher_photo.Click += new System.EventHandler(this.Afficher_photo_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 30;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Sauvegarder En Excel";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 30;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(643, 487);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(251, 65);
            this.bunifuThinButton22.TabIndex = 32;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 30;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Imprimer toutes les PR";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 30;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuThinButton23.Location = new System.Drawing.Point(340, 487);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(256, 65);
            this.bunifuThinButton23.TabIndex = 31;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Imprimer_product
            // 
            this.Imprimer_product.ActiveBorderThickness = 1;
            this.Imprimer_product.ActiveCornerRadius = 30;
            this.Imprimer_product.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Imprimer_product.ActiveForecolor = System.Drawing.Color.White;
            this.Imprimer_product.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Imprimer_product.BackColor = System.Drawing.SystemColors.Control;
            this.Imprimer_product.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Imprimer_product.BackgroundImage")));
            this.Imprimer_product.ButtonText = "Imprimer PR Cocher";
            this.Imprimer_product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Imprimer_product.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imprimer_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Imprimer_product.IdleBorderThickness = 1;
            this.Imprimer_product.IdleCornerRadius = 30;
            this.Imprimer_product.IdleFillColor = System.Drawing.Color.White;
            this.Imprimer_product.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Imprimer_product.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.Imprimer_product.Location = new System.Drawing.Point(62, 487);
            this.Imprimer_product.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Imprimer_product.Name = "Imprimer_product";
            this.Imprimer_product.Size = new System.Drawing.Size(230, 65);
            this.Imprimer_product.TabIndex = 30;
            this.Imprimer_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Imprimer_product.Click += new System.EventHandler(this.Imprimer_product_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(3, 471);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(941, 19);
            this.bunifuSeparator3.TabIndex = 33;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // User_List_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.Imprimer_product);
            this.Controls.Add(this.afficher_photo);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.dgvprodect);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.recherche_prodect);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.supprimer_product);
            this.Controls.Add(this.Modifier_prodect);
            this.Controls.Add(this.ajouter_prodect);
            this.Name = "User_List_Product";
            this.Size = new System.Drawing.Size(947, 569);
            this.Load += new System.EventHandler(this.User_List_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprodect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvprodect;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.TextBox recherche_prodect;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuThinButton2 supprimer_product;
        private Bunifu.Framework.UI.BunifuThinButton2 Modifier_prodect;
        private Bunifu.Framework.UI.BunifuThinButton2 ajouter_prodect;
        private Bunifu.Framework.UI.BunifuThinButton2 afficher_photo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categorie;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 Imprimer_product;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
    }
}
