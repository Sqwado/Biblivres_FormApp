using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblivres.Forms
{
    public partial class FormManage : Form
    {
        // Fields
        private Color MainColor;
        private FormMainMenu OpenFrom;
        private MySqlConnection connection;
        private MySqlCommand command;

        public FormManage(Color mainColor, FormMainMenu openFrom)
        {
            MainColor = mainColor;
            OpenFrom = openFrom;
            InitConnection();
            InitializeComponent();
            this.BackColor = MainColor;

            RecupLivres();
        }

        private void InitConnection()
        {
            try
            {
                connection = new MySqlConnection(Globals.Globals.connectionString);
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(1);
            }
        }

        private void RecupLivres()
        {
            string query = "select * from Livres order by Titre_Livre";
            command = new MySqlCommand(query, connection);
            MySqlDataAdapter data = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);
            flowLayoutPanel.Controls.Clear();
            foreach (DataRow row in table.Rows)
            {
                byte[] imgg = (byte[])row["Miniature"];
                MemoryStream ms = new MemoryStream(imgg);

                Panel panel = new Panel();

                Button btn = new Button();
                btn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btn.Location = new Point(15, 357);
                btn.Name = "sup_" + row["Id_Livre"].ToString();
                btn.Size = new Size(220, 34);
                btn.Text = "Supprimer";
                btn.UseVisualStyleBackColor = true;
                btn.Click += buttonSup_Click;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.Location = new Point(15, 60);
                pictureBox.Size = new Size(220, 290);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Enabled = false;

                Label label = new Label();
                label.Dock = DockStyle.Top;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Size = new Size(250, 60);
                label.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel panel = (sender as Panel);
            Console.WriteLine(panel.Name);
            OpenFrom.DisableButton();
            OpenFrom.OpenChildForm(new FormChange(MainColor, OpenFrom, int.Parse(panel.Name)));
        }

        private void buttonSup_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Console.WriteLine(button.Name.Replace("sup_",""));
            OpenFrom.DisableButton();

        }

    }
}
