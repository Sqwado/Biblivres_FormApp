namespace Biblivres
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelAdmin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(69, 9);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(376, 96);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Biblivres Connection \r\nAdmin";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPass
            // 
            this.labelPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.Location = new System.Drawing.Point(12, 284);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(132, 29);
            this.labelPass.TabIndex = 2;
            this.labelPass.Text = "Password :";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(34, 170);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(86, 29);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email :";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(156, 283);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(289, 30);
            this.textBoxPass.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(156, 170);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(289, 30);
            this.textBoxEmail.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonLog);
            this.panel1.Controls.Add(this.checkBoxPass);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.labelAdmin);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.labelPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 648);
            this.panel1.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Black;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.buttonClear.Location = new System.Drawing.Point(60, 516);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(370, 70);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(33)))), ((int)(((byte)(122)))));
            this.buttonLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLog.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.Color.Black;
            this.buttonLog.Location = new System.Drawing.Point(60, 409);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(370, 70);
            this.buttonLog.TabIndex = 5;
            this.buttonLog.Text = "Login";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(282, 344);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(148, 24);
            this.checkBoxPass.TabIndex = 4;
            this.checkBoxPass.Text = "Show Password";
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 648);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(522, 704);
            this.MinimumSize = new System.Drawing.Size(522, 704);
            this.Name = "FormLogin";
            this.Text = "Login To Biblivres";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonClear;
    }
}