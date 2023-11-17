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
            this.panelLangue = new System.Windows.Forms.Panel();
            this.comboBoxLangue = new System.Windows.Forms.ComboBox();
            this.labelLangue = new System.Windows.Forms.Label();
            this.panelIntrigue = new System.Windows.Forms.Panel();
            this.textBoxIntrigue = new System.Windows.Forms.TextBox();
            this.labelIntrigue = new System.Windows.Forms.Label();
            this.panelMiniature = new System.Windows.Forms.Panel();
            this.pictureBoxMiniature = new System.Windows.Forms.PictureBox();
            this.panelLeftMinia = new System.Windows.Forms.Panel();
            this.buttonMiniature = new System.Windows.Forms.Button();
            this.labelMiniature = new System.Windows.Forms.Label();
            this.panelTitre = new System.Windows.Forms.Panel();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelLangue.SuspendLayout();
            this.panelIntrigue.SuspendLayout();
            this.panelMiniature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniature)).BeginInit();
            this.panelLeftMinia.SuspendLayout();
            this.panelTitre.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(405, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(395, 450);
            this.panelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLeft.Controls.Add(this.panelMiniature);
            this.panelLeft.Controls.Add(this.panelIntrigue);
            this.panelLeft.Controls.Add(this.panelLangue);
            this.panelLeft.Controls.Add(this.panelTitre);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(405, 450);
            this.panelLeft.TabIndex = 0;
            // 
            // panelLangue
            // 
            this.panelLangue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLangue.Controls.Add(this.comboBoxLangue);
            this.panelLangue.Controls.Add(this.labelLangue);
            this.panelLangue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLangue.Location = new System.Drawing.Point(0, 390);
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
            // panelIntrigue
            // 
            this.panelIntrigue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelIntrigue.Controls.Add(this.textBoxIntrigue);
            this.panelIntrigue.Controls.Add(this.labelIntrigue);
            this.panelIntrigue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIntrigue.Location = new System.Drawing.Point(0, 270);
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
            // panelMiniature
            // 
            this.panelMiniature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMiniature.Controls.Add(this.pictureBoxMiniature);
            this.panelMiniature.Controls.Add(this.panelLeftMinia);
            this.panelMiniature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiniature.Location = new System.Drawing.Point(0, 60);
            this.panelMiniature.Name = "panelMiniature";
            this.panelMiniature.Size = new System.Drawing.Size(405, 210);
            this.panelMiniature.TabIndex = 1;
            // 
            // pictureBoxMiniature
            // 
            this.pictureBoxMiniature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMiniature.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMiniature.Image")));
            this.pictureBoxMiniature.Location = new System.Drawing.Point(177, 0);
            this.pictureBoxMiniature.Name = "pictureBoxMiniature";
            this.pictureBoxMiniature.Size = new System.Drawing.Size(228, 210);
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
            this.panelLeftMinia.Size = new System.Drawing.Size(177, 210);
            this.panelLeftMinia.TabIndex = 2;
            // 
            // buttonMiniature
            // 
            this.buttonMiniature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMiniature.Location = new System.Drawing.Point(0, 50);
            this.buttonMiniature.Name = "buttonMiniature";
            this.buttonMiniature.Size = new System.Drawing.Size(177, 160);
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
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNew";
            this.Text = "FormNew";
            this.Resize += new System.EventHandler(this.FormNew_Resize);
            this.panel1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLangue.ResumeLayout(false);
            this.panelIntrigue.ResumeLayout(false);
            this.panelIntrigue.PerformLayout();
            this.panelMiniature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiniature)).EndInit();
            this.panelLeftMinia.ResumeLayout(false);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
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
    }
}