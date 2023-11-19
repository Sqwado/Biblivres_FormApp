using System.Windows.Forms;

namespace Biblivres
{
    partial class FormMainMenu
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.sideBar = new System.Windows.Forms.Panel();
            this.iconBtnManage = new FontAwesome.Sharp.IconButton();
            this.iconBtnNew = new FontAwesome.Sharp.IconButton();
            this.iconBtnRead = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.topBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.labelCurrentChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.sideBar.Controls.Add(this.iconBtnManage);
            this.sideBar.Controls.Add(this.iconBtnNew);
            this.sideBar.Controls.Add(this.iconBtnRead);
            this.sideBar.Controls.Add(this.panelLogo);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Margin = new System.Windows.Forms.Padding(0);
            this.sideBar.MinimumSize = new System.Drawing.Size(150, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(200, 900);
            this.sideBar.TabIndex = 2;
            // 
            // iconBtnManage
            // 
            this.iconBtnManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnManage.FlatAppearance.BorderSize = 0;
            this.iconBtnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnManage.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconBtnManage.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnManage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnManage.Location = new System.Drawing.Point(0, 300);
            this.iconBtnManage.Name = "iconBtnManage";
            this.iconBtnManage.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iconBtnManage.Size = new System.Drawing.Size(200, 100);
            this.iconBtnManage.TabIndex = 7;
            this.iconBtnManage.Text = "Manage Livre";
            this.iconBtnManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnManage.UseVisualStyleBackColor = true;
            this.iconBtnManage.Click += new System.EventHandler(this.iconBtnManage_Click);
            // 
            // iconBtnNew
            // 
            this.iconBtnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnNew.FlatAppearance.BorderSize = 0;
            this.iconBtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnNew.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconBtnNew.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnNew.Location = new System.Drawing.Point(0, 200);
            this.iconBtnNew.Name = "iconBtnNew";
            this.iconBtnNew.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iconBtnNew.Size = new System.Drawing.Size(200, 100);
            this.iconBtnNew.TabIndex = 6;
            this.iconBtnNew.Text = "New Livre";
            this.iconBtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnNew.UseVisualStyleBackColor = true;
            this.iconBtnNew.Click += new System.EventHandler(this.iconBtnNew_Click);
            // 
            // iconBtnRead
            // 
            this.iconBtnRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnRead.FlatAppearance.BorderSize = 0;
            this.iconBtnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnRead.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnRead.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconBtnRead.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnRead.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnRead.Location = new System.Drawing.Point(0, 100);
            this.iconBtnRead.Name = "iconBtnRead";
            this.iconBtnRead.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iconBtnRead.Size = new System.Drawing.Size(200, 100);
            this.iconBtnRead.TabIndex = 5;
            this.iconBtnRead.Text = "Read Livre";
            this.iconBtnRead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnRead.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnRead.UseVisualStyleBackColor = true;
            this.iconBtnRead.Click += new System.EventHandler(this.iconBtnRead_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(192, 90);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(1425, 25);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 49);
            this.closeButton.TabIndex = 0;
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.topBar.Controls.Add(this.buttonMinimize);
            this.topBar.Controls.Add(this.buttonMax);
            this.topBar.Controls.Add(this.labelCurrentChildForm);
            this.topBar.Controls.Add(this.iconCurrentChildForm);
            this.topBar.Controls.Add(this.closeButton);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(200, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(0);
            this.topBar.MinimumSize = new System.Drawing.Size(0, 100);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1500, 100);
            this.topBar.TabIndex = 2;
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Location = new System.Drawing.Point(1313, 25);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(50, 49);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMax.BackColor = System.Drawing.Color.Transparent;
            this.buttonMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMax.BackgroundImage")));
            this.buttonMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMax.Location = new System.Drawing.Point(1369, 28);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(50, 49);
            this.buttonMax.TabIndex = 3;
            this.buttonMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMax.UseVisualStyleBackColor = false;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // labelCurrentChildForm
            // 
            this.labelCurrentChildForm.AutoSize = true;
            this.labelCurrentChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelCurrentChildForm.Location = new System.Drawing.Point(80, 35);
            this.labelCurrentChildForm.Name = "labelCurrentChildForm";
            this.labelCurrentChildForm.Size = new System.Drawing.Size(78, 29);
            this.labelCurrentChildForm.TabIndex = 2;
            this.labelCurrentChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 60;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 20);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(60, 60);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1500, 800);
            this.panelMain.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 900);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.sideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(810, 570);
            this.Name = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.sideBar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel topBar;
        public FontAwesome.Sharp.IconButton iconBtnRead;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconBtnManage;
        private FontAwesome.Sharp.IconButton iconBtnNew;
        private PictureBox btnHome;
        private Panel panelMain;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        public Label labelCurrentChildForm;
        private Button buttonMax;
        private Button buttonMinimize;
    }
}

