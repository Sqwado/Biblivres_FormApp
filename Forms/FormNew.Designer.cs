namespace Biblivres.Forms
{
    partial class FormNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNew));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMiniature = new System.Windows.Forms.Panel();
            this.pictureBoxMiniature = new System.Windows.Forms.PictureBox();
            this.panelLeftMinia = new System.Windows.Forms.Panel();
            this.buttonMiniature = new System.Windows.Forms.Button();
            this.labelMiniature = new System.Windows.Forms.Label();
            this.panelIntrigue = new System.Windows.Forms.Panel();
            this.textBoxIntrigue = new System.Windows.Forms.TextBox();
            this.labelIntrigue = new System.Windows.Forms.Label();
            this.panelLangue = new System.Windows.Forms.Panel();
            this.comboBoxLangue = new System.Windows.Forms.ComboBox();
            this.labelLangue = new System.Windows.Forms.Label();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.comboBoxAuteur = new System.Windows.Forms.ComboBox();
            this.labelAuteur = new System.Windows.Forms.Label();
            this.Auteur = new System.Windows.Forms.Panel();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.panelGenre = new System.Windows.Forms.Panel();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.panelType = new System.Windows.Forms.Panel();
            this.labelPrix = new System.Windows.Forms.Label();
            this.panelPrix = new System.Windows.Forms.Panel();
            this.numericUpDownPrix = new System.Windows.Forms.NumericUpDown();
            this.labelEuro = new System.Windows.Forms.Label();
            this.numericUpDownPage = new System.Windows.Forms.NumericUpDown();
            this.labelPage = new System.Windows.Forms.Label();
            this.panelPage = new System.Windows.Forms.Panel();
            this.textBoxEditeur = new System.Windows.Forms.TextBox();
            this.labelEditeur = new System.Windows.Forms.Label();
            this.panelEditeur = new System.Windows.Forms.Panel();
            this.panelDate = new System.Windows.Forms.Panel();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.panelQuantity = new System.Windows.Forms.Panel();
            this.labelAdd = new System.Windows.Forms.Label();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelMiniature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniature)).BeginInit();
            this.panelLeftMinia.SuspendLayout();
            this.panelIntrigue.SuspendLayout();
            this.panelLangue.SuspendLayout();
            this.panelTitre.SuspendLayout();
            this.Auteur.SuspendLayout();
            this.panelGenre.SuspendLayout();
            this.panelType.SuspendLayout();
            this.panelPrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).BeginInit();
            this.panelPage.SuspendLayout();
            this.panelEditeur.SuspendLayout();
            this.panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panelQuantity.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelRight);
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 520);
            this.panel1.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelAdd);
            this.panelRight.Controls.Add(this.panelQuantity);
            this.panelRight.Controls.Add(this.panelEditeur);
            this.panelRight.Controls.Add(this.panelPage);
            this.panelRight.Controls.Add(this.panelPrix);
            this.panelRight.Controls.Add(this.panelType);
            this.panelRight.Controls.Add(this.panelGenre);
            this.panelRight.Controls.Add(this.Auteur);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(405, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(444, 520);
            this.panelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLeft.Controls.Add(this.panelMiniature);
            this.panelLeft.Controls.Add(this.panelIntrigue);
            this.panelLeft.Controls.Add(this.panelLangue);
            this.panelLeft.Controls.Add(this.panelDate);
            this.panelLeft.Controls.Add(this.panelTitre);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(405, 520);
            this.panelLeft.TabIndex = 0;
            // 
            // panelMiniature
            // 
            this.panelMiniature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMiniature.Controls.Add(this.pictureBoxMiniature);
            this.panelMiniature.Controls.Add(this.panelLeftMinia);
            this.panelMiniature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiniature.Location = new System.Drawing.Point(0, 60);
            this.panelMiniature.Name = "panelMiniature";
            this.panelMiniature.Size = new System.Drawing.Size(405, 220);
            this.panelMiniature.TabIndex = 1;
            // 
            // pictureBoxMiniature
            // 
            this.pictureBoxMiniature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMiniature.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMiniature.Image")));
            this.pictureBoxMiniature.Location = new System.Drawing.Point(177, 0);
            this.pictureBoxMiniature.Name = "pictureBoxMiniature";
            this.pictureBoxMiniature.Size = new System.Drawing.Size(228, 220);
            this.pictureBoxMiniature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMiniature.TabIndex = 3;
            this.pictureBoxMiniature.TabStop = false;
            // 
            // panelLeftMinia
            // 
            this.panelLeftMinia.Controls.Add(this.buttonMiniature);
            this.panelLeftMinia.Controls.Add(this.labelMiniature);
            this.panelLeftMinia.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMinia.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMinia.Name = "panelLeftMinia";
            this.panelLeftMinia.Size = new System.Drawing.Size(177, 220);
            this.panelLeftMinia.TabIndex = 2;
            // 
            // buttonMiniature
            // 
            this.buttonMiniature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMiniature.Location = new System.Drawing.Point(0, 50);
            this.buttonMiniature.Name = "buttonMiniature";
            this.buttonMiniature.Size = new System.Drawing.Size(177, 170);
            this.buttonMiniature.TabIndex = 2;
            this.buttonMiniature.Text = "Choose a file";
            this.buttonMiniature.UseVisualStyleBackColor = true;
            this.buttonMiniature.Click += new System.EventHandler(this.buttonMiniature_Click);
            // 
            // labelMiniature
            // 
            this.labelMiniature.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMiniature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiniature.Location = new System.Drawing.Point(0, 0);
            this.labelMiniature.MinimumSize = new System.Drawing.Size(95, 50);
            this.labelMiniature.Name = "labelMiniature";
            this.labelMiniature.Size = new System.Drawing.Size(177, 50);
            this.labelMiniature.TabIndex = 1;
            this.labelMiniature.Text = "Miniature";
            this.labelMiniature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIntrigue
            // 
            this.panelIntrigue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelIntrigue.Controls.Add(this.textBoxIntrigue);
            this.panelIntrigue.Controls.Add(this.labelIntrigue);
            this.panelIntrigue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIntrigue.Location = new System.Drawing.Point(0, 280);
            this.panelIntrigue.Name = "panelIntrigue";
            this.panelIntrigue.Size = new System.Drawing.Size(405, 120);
            this.panelIntrigue.TabIndex = 2;
            // 
            // textBoxIntrigue
            // 
            this.textBoxIntrigue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIntrigue.Location = new System.Drawing.Point(80, 0);
            this.textBoxIntrigue.Multiline = true;
            this.textBoxIntrigue.Name = "textBoxIntrigue";
            this.textBoxIntrigue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIntrigue.Size = new System.Drawing.Size(325, 120);
            this.textBoxIntrigue.TabIndex = 1;
            // 
            // labelIntrigue
            // 
            this.labelIntrigue.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelIntrigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntrigue.Location = new System.Drawing.Point(0, 0);
            this.labelIntrigue.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelIntrigue.Name = "labelIntrigue";
            this.labelIntrigue.Size = new System.Drawing.Size(80, 120);
            this.labelIntrigue.TabIndex = 0;
            this.labelIntrigue.Text = "Intrigue";
            this.labelIntrigue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLangue
            // 
            this.panelLangue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLangue.Controls.Add(this.comboBoxLangue);
            this.panelLangue.Controls.Add(this.labelLangue);
            this.panelLangue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLangue.Location = new System.Drawing.Point(0, 400);
            this.panelLangue.Name = "panelLangue";
            this.panelLangue.Size = new System.Drawing.Size(405, 60);
            this.panelLangue.TabIndex = 3;
            // 
            // comboBoxLangue
            // 
            this.comboBoxLangue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLangue.DisplayMember = "Text";
            this.comboBoxLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLangue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLangue.FormattingEnabled = true;
            this.comboBoxLangue.Location = new System.Drawing.Point(80, 10);
            this.comboBoxLangue.MaxDropDownItems = 100;
            this.comboBoxLangue.Name = "comboBoxLangue";
            this.comboBoxLangue.Size = new System.Drawing.Size(325, 40);
            this.comboBoxLangue.Sorted = true;
            this.comboBoxLangue.TabIndex = 1;
            this.comboBoxLangue.ValueMember = "ID";
            // 
            // labelLangue
            // 
            this.labelLangue.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLangue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLangue.Location = new System.Drawing.Point(0, 0);
            this.labelLangue.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelLangue.Name = "labelLangue";
            this.labelLangue.Size = new System.Drawing.Size(80, 60);
            this.labelLangue.TabIndex = 0;
            this.labelLangue.Text = "Langue";
            this.labelLangue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTitre.Controls.Add(this.textBoxTitre);
            this.panelTitre.Controls.Add(this.labelTitre);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(405, 60);
            this.panelTitre.TabIndex = 0;
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitre.Location = new System.Drawing.Point(117, 10);
            this.textBoxTitre.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(285, 39);
            this.textBoxTitre.TabIndex = 1;
            // 
            // labelTitre
            // 
            this.labelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTitre.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(0, 0);
            this.labelTitre.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(120, 60);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Titre du livre";
            this.labelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAuteur
            // 
            this.comboBoxAuteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAuteur.DisplayMember = "Text";
            this.comboBoxAuteur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuteur.FormattingEnabled = true;
            this.comboBoxAuteur.Location = new System.Drawing.Point(80, 10);
            this.comboBoxAuteur.MaxDropDownItems = 100;
            this.comboBoxAuteur.Name = "comboBoxAuteur";
            this.comboBoxAuteur.Size = new System.Drawing.Size(364, 40);
            this.comboBoxAuteur.Sorted = true;
            this.comboBoxAuteur.TabIndex = 1;
            this.comboBoxAuteur.ValueMember = "ID";
            // 
            // labelAuteur
            // 
            this.labelAuteur.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuteur.Location = new System.Drawing.Point(0, 0);
            this.labelAuteur.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelAuteur.Name = "labelAuteur";
            this.labelAuteur.Size = new System.Drawing.Size(80, 60);
            this.labelAuteur.TabIndex = 0;
            this.labelAuteur.Text = "Auteur";
            this.labelAuteur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Auteur
            // 
            this.Auteur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Auteur.Controls.Add(this.comboBoxAuteur);
            this.Auteur.Controls.Add(this.labelAuteur);
            this.Auteur.Dock = System.Windows.Forms.DockStyle.Top;
            this.Auteur.Location = new System.Drawing.Point(0, 0);
            this.Auteur.Name = "Auteur";
            this.Auteur.Size = new System.Drawing.Size(444, 60);
            this.Auteur.TabIndex = 4;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGenre.DisplayMember = "Text";
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(80, 10);
            this.comboBoxGenre.MaxDropDownItems = 100;
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(364, 40);
            this.comboBoxGenre.Sorted = true;
            this.comboBoxGenre.TabIndex = 1;
            this.comboBoxGenre.ValueMember = "ID";
            // 
            // labelGenre
            // 
            this.labelGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(0, 0);
            this.labelGenre.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(80, 60);
            this.labelGenre.TabIndex = 0;
            this.labelGenre.Text = "Genre";
            this.labelGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGenre
            // 
            this.panelGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelGenre.Controls.Add(this.comboBoxGenre);
            this.panelGenre.Controls.Add(this.labelGenre);
            this.panelGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGenre.Location = new System.Drawing.Point(0, 60);
            this.panelGenre.Name = "panelGenre";
            this.panelGenre.Size = new System.Drawing.Size(444, 60);
            this.panelGenre.TabIndex = 5;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.DisplayMember = "Text";
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(80, 10);
            this.comboBoxType.MaxDropDownItems = 100;
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(364, 40);
            this.comboBoxType.Sorted = true;
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.ValueMember = "ID";
            // 
            // labelType
            // 
            this.labelType.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(0, 0);
            this.labelType.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(80, 60);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "Type";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelType
            // 
            this.panelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelType.Controls.Add(this.comboBoxType);
            this.panelType.Controls.Add(this.labelType);
            this.panelType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelType.Location = new System.Drawing.Point(0, 120);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(444, 60);
            this.panelType.TabIndex = 6;
            // 
            // labelPrix
            // 
            this.labelPrix.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(0, 0);
            this.labelPrix.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(80, 60);
            this.labelPrix.TabIndex = 0;
            this.labelPrix.Text = "Prix";
            this.labelPrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPrix
            // 
            this.panelPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelPrix.Controls.Add(this.labelEuro);
            this.panelPrix.Controls.Add(this.numericUpDownPrix);
            this.panelPrix.Controls.Add(this.labelPrix);
            this.panelPrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrix.Location = new System.Drawing.Point(0, 180);
            this.panelPrix.Name = "panelPrix";
            this.panelPrix.Size = new System.Drawing.Size(444, 60);
            this.panelPrix.TabIndex = 7;
            // 
            // numericUpDownPrix
            // 
            this.numericUpDownPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPrix.DecimalPlaces = 2;
            this.numericUpDownPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPrix.Location = new System.Drawing.Point(80, 10);
            this.numericUpDownPrix.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPrix.Name = "numericUpDownPrix";
            this.numericUpDownPrix.Size = new System.Drawing.Size(315, 35);
            this.numericUpDownPrix.TabIndex = 1;
            this.numericUpDownPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPrix.ThousandsSeparator = true;
            this.numericUpDownPrix.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelEuro
            // 
            this.labelEuro.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuro.Location = new System.Drawing.Point(401, 0);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(43, 60);
            this.labelEuro.TabIndex = 2;
            this.labelEuro.Text = "€";
            this.labelEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownPage
            // 
            this.numericUpDownPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPage.Location = new System.Drawing.Point(80, 13);
            this.numericUpDownPage.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPage.Name = "numericUpDownPage";
            this.numericUpDownPage.Size = new System.Drawing.Size(315, 35);
            this.numericUpDownPage.TabIndex = 1;
            this.numericUpDownPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownPage.ThousandsSeparator = true;
            this.numericUpDownPage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelPage
            // 
            this.labelPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPage.Location = new System.Drawing.Point(0, 0);
            this.labelPage.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(80, 60);
            this.labelPage.TabIndex = 0;
            this.labelPage.Text = "Page";
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPage
            // 
            this.panelPage.AutoSize = true;
            this.panelPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelPage.Controls.Add(this.numericUpDownPage);
            this.panelPage.Controls.Add(this.labelPage);
            this.panelPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPage.Location = new System.Drawing.Point(0, 240);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(444, 60);
            this.panelPage.TabIndex = 8;
            // 
            // textBoxEditeur
            // 
            this.textBoxEditeur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditeur.Location = new System.Drawing.Point(117, 10);
            this.textBoxEditeur.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.textBoxEditeur.Name = "textBoxEditeur";
            this.textBoxEditeur.Size = new System.Drawing.Size(324, 39);
            this.textBoxEditeur.TabIndex = 1;
            // 
            // labelEditeur
            // 
            this.labelEditeur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEditeur.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEditeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditeur.Location = new System.Drawing.Point(0, 0);
            this.labelEditeur.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelEditeur.Name = "labelEditeur";
            this.labelEditeur.Size = new System.Drawing.Size(120, 60);
            this.labelEditeur.TabIndex = 0;
            this.labelEditeur.Text = "Editeur";
            this.labelEditeur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEditeur
            // 
            this.panelEditeur.AutoSize = true;
            this.panelEditeur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelEditeur.Controls.Add(this.textBoxEditeur);
            this.panelEditeur.Controls.Add(this.labelEditeur);
            this.panelEditeur.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEditeur.Location = new System.Drawing.Point(0, 300);
            this.panelEditeur.Name = "panelEditeur";
            this.panelEditeur.Size = new System.Drawing.Size(444, 60);
            this.panelEditeur.TabIndex = 9;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDate.Controls.Add(this.dateTimePickerDate);
            this.panelDate.Controls.Add(this.labelDate);
            this.panelDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDate.Location = new System.Drawing.Point(0, 460);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(405, 60);
            this.panelDate.TabIndex = 4;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(183, 17);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(219, 26);
            this.dateTimePickerDate.TabIndex = 2;
            this.dateTimePickerDate.Value = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(0, 0);
            this.labelDate.MinimumSize = new System.Drawing.Size(120, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(186, 60);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date de publication";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(117, 10);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(278, 35);
            this.numericUpDownQuantity.TabIndex = 1;
            this.numericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQuantity.ThousandsSeparator = true;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantity
            // 
            this.labelQuantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(0, 0);
            this.labelQuantity.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(120, 60);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Quantity";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelQuantity
            // 
            this.panelQuantity.AutoSize = true;
            this.panelQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelQuantity.Controls.Add(this.numericUpDownQuantity);
            this.panelQuantity.Controls.Add(this.labelQuantity);
            this.panelQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuantity.Location = new System.Drawing.Point(0, 360);
            this.panelQuantity.Name = "panelQuantity";
            this.panelQuantity.Size = new System.Drawing.Size(444, 60);
            this.panelQuantity.TabIndex = 10;
            // 
            // labelAdd
            // 
            this.labelAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdd.Location = new System.Drawing.Point(0, 0);
            this.labelAdd.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(178, 100);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "Add new livre";
            this.labelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAdd
            // 
            this.panelAdd.AutoSize = true;
            this.panelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Controls.Add(this.labelAdd);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdd.Location = new System.Drawing.Point(0, 420);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(444, 100);
            this.panelAdd.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(178, 0);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(266, 100);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Upload";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNew";
            this.Text = "FormNew";
            this.Resize += new System.EventHandler(this.FormNew_Resize);
            this.panel1.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelMiniature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniature)).EndInit();
            this.panelLeftMinia.ResumeLayout(false);
            this.panelIntrigue.ResumeLayout(false);
            this.panelIntrigue.PerformLayout();
            this.panelLangue.ResumeLayout(false);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            this.Auteur.ResumeLayout(false);
            this.panelGenre.ResumeLayout(false);
            this.panelType.ResumeLayout(false);
            this.panelPrix.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPage)).EndInit();
            this.panelPage.ResumeLayout(false);
            this.panelEditeur.ResumeLayout(false);
            this.panelEditeur.PerformLayout();
            this.panelDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panelQuantity.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.Panel panelMiniature;
        private System.Windows.Forms.Panel panelIntrigue;
        private System.Windows.Forms.TextBox textBoxIntrigue;
        private System.Windows.Forms.Label labelIntrigue;
        private System.Windows.Forms.PictureBox pictureBoxMiniature;
        private System.Windows.Forms.Panel panelLeftMinia;
        private System.Windows.Forms.Label labelMiniature;
        private System.Windows.Forms.Button buttonMiniature;
        private System.Windows.Forms.Panel panelLangue;
        private System.Windows.Forms.Label labelLangue;
        private System.Windows.Forms.ComboBox comboBoxLangue;
        private System.Windows.Forms.Panel Auteur;
        private System.Windows.Forms.ComboBox comboBoxAuteur;
        private System.Windows.Forms.Label labelAuteur;
        private System.Windows.Forms.Panel panelGenre;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Panel panelPrix;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.NumericUpDown numericUpDownPrix;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.NumericUpDown numericUpDownPage;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Panel panelEditeur;
        private System.Windows.Forms.TextBox textBoxEditeur;
        private System.Windows.Forms.Label labelEditeur;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panelQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAdd;
    }
}