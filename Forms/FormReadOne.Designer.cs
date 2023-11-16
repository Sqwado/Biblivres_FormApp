namespace Biblivres.Forms
{
    partial class FormReadOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReadOne));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panelIntrigue = new System.Windows.Forms.Panel();
            this.labelIntrigue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelLangue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelIntrigue.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(629, 538);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox);
            this.panel4.Controls.Add(this.labelAuthor);
            this.panel4.Controls.Add(this.labelTitre);
            this.panel4.Controls.Add(this.panelIntrigue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(140, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 528);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 75);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 303);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // labelAuthor
            // 
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAuthor.Location = new System.Drawing.Point(0, 36);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(400, 39);
            this.labelAuthor.TabIndex = 1;
            this.labelAuthor.Text = "Author";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitre
            // 
            this.labelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(0, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(400, 36);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Titre";
            this.labelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIntrigue
            // 
            this.panelIntrigue.AutoScroll = true;
            this.panelIntrigue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelIntrigue.Controls.Add(this.labelIntrigue);
            this.panelIntrigue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIntrigue.Location = new System.Drawing.Point(0, 378);
            this.panelIntrigue.MinimumSize = new System.Drawing.Size(200, 150);
            this.panelIntrigue.Name = "panelIntrigue";
            this.panelIntrigue.Size = new System.Drawing.Size(400, 150);
            this.panelIntrigue.TabIndex = 3;
            this.panelIntrigue.Resize += new System.EventHandler(this.panelIntrigue_Resize);
            // 
            // labelIntrigue
            // 
            this.labelIntrigue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIntrigue.Location = new System.Drawing.Point(0, 0);
            this.labelIntrigue.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelIntrigue.Name = "labelIntrigue";
            this.labelIntrigue.Size = new System.Drawing.Size(400, 150);
            this.labelIntrigue.TabIndex = 0;
            this.labelIntrigue.Text = resources.GetString("labelIntrigue.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel2.Size = new System.Drawing.Size(135, 528);
            this.panel2.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDate.Location = new System.Drawing.Point(0, 50);
            this.labelDate.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.labelDate.MinimumSize = new System.Drawing.Size(50, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.labelDate.Size = new System.Drawing.Size(135, 81);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "01/01/0100";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.InitialImage = null;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 50);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 2;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelPrix);
            this.panel3.Controls.Add(this.labelLangue);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(540, 5);
            this.panel3.MinimumSize = new System.Drawing.Size(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 528);
            this.panel3.TabIndex = 2;
            // 
            // labelPrix
            // 
            this.labelPrix.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(0, 505);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(84, 23);
            this.labelPrix.TabIndex = 1;
            this.labelPrix.Text = "10€";
            this.labelPrix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLangue
            // 
            this.labelLangue.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLangue.Location = new System.Drawing.Point(0, 0);
            this.labelLangue.Name = "labelLangue";
            this.labelLangue.Size = new System.Drawing.Size(84, 23);
            this.labelLangue.TabIndex = 0;
            this.labelLangue.Text = "LANG";
            this.labelLangue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormReadOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(629, 538);
            this.Controls.Add(this.panel1);
            this.Name = "FormReadOne";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelIntrigue.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelLangue;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelIntrigue;
        private System.Windows.Forms.Label labelIntrigue;
    }
}