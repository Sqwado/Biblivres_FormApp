using Biblivres.Globals;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblivres.Forms
{

    public partial class FormNew : Form
    {
        // Fields
        private Color MainColor;
        private FormMainMenu OpenFrom;
        private MySqlConnection connection;
        private MySqlCommand command;
        private byte[] MiniatureFile;
        private MySqlDataAdapter data;

        public FormNew(Color mainColor, FormMainMenu openFrom)
        {
            MainColor = mainColor;
            OpenFrom = openFrom;
            InitConnection();
            InitializeComponent();
            this.BackColor = MainColor;
            GetLangue();

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

        private void GetLangue()
        {
            string query = "select * from Langue";
            command = new MySqlCommand(query, connection);
            data = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                comboBoxLangue.Items.Add(new ComboItem { ID = (int)row["Id_Langue"], Text = (string)row["Language"] });
            }
            comboBoxLangue.SelectedIndex = 0;

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void FormNew_Resize(object sender, EventArgs e)
        {
            panelLeft.Width = this.Width / 2;
            panelLeftMinia.Width = panelMiniature.Width / 2;
        }

        private void buttonMiniature_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMiniature.Image = new Bitmap(opnfd.FileName);
                buttonMiniature.Text = System.IO.Path.GetFileName(opnfd.FileName);
                MiniatureFile = File.ReadAllBytes(opnfd.FileName);
            }
        }
    }
}
