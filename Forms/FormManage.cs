using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Biblivres.Globals;
using MySql.Data.MySqlClient;

namespace Biblivres.Forms
{
    public partial class FormManage : Form
    {
        // Fields
        private readonly Color MainColor;
        private readonly MySqlDb mySqlDb = new MySqlDb();
        private readonly FormMainMenu OpenFrom;

        public FormManage(Color mainColor, FormMainMenu openFrom)
        {
            MainColor = mainColor;
            OpenFrom = openFrom;
            mySqlDb.InitConnection();
            InitializeComponent();
            BackColor = MainColor;

            RecupLivres();
        }

        private void RecupLivres()
        {
            var query = "select * from Livres order by Titre_Livre";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            var table = new DataTable();
            mySqlDb.data.Fill(table);
            flowLayoutPanel.Controls.Clear();
            foreach (DataRow row in table.Rows)
            {
                var imgg = (byte[])row["Miniature"];
                var ms = new MemoryStream(imgg);

                var panel = new Panel();

                var btn = new Button();
                btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                btn.Location = new Point(15, 357);
                btn.Name = "sup_" + row["Id_Livre"];
                btn.Size = new Size(220, 34);
                btn.Text = "Supprimer";
                btn.UseVisualStyleBackColor = true;
                btn.Click += buttonSup_Click;

                var pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.Location = new Point(15, 60);
                pictureBox.Size = new Size(220, 290);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Enabled = false;

                var label = new Label();
                label.Dock = DockStyle.Top;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(250, 60);
                label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
                label.Text = (string)row["Titre_Livre"];
                label.Enabled = false;

                panel.BackColor = SystemColors.ActiveCaption;
                panel.Controls.Add(btn);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);
                panel.Size = new Size(250, 400);
                panel.Margin = new Padding(10);
                panel.Name = row["Id_Livre"].ToString();
                panel.Click += panel_Click;

                flowLayoutPanel.Controls.Add(panel);
            }

            if (mySqlDb.connection.State == ConnectionState.Open) mySqlDb.connection.Close();
        }

        private void panel_Click(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            Console.WriteLine(panel.Name);
            OpenFrom.DisableButton();
            OpenFrom.OpenChildForm(new FormChange(MainColor, OpenFrom, int.Parse(panel.Name)));
        }

        private void buttonSup_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Console.WriteLine(button.Name.Replace("sup_", ""));
            OpenFrom.DisableButton();
        }
    }
}