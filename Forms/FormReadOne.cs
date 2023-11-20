using Biblivres.Globals;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Biblivres.Forms
{
    public partial class FormReadOne : Form
    {
        // Fields
        private Color MainColor;
        private int BookId;
        private FormMainMenu OpenFrom;
        private MySqlDb mySqlDb = new MySqlDb();

        public FormReadOne(Color mainColor, FormMainMenu openFrom, int bookId)
        {
            MainColor = mainColor;
            OpenFrom = openFrom;
            BookId = bookId;
            mySqlDb.InitConnection();
            InitializeComponent();
            this.BackColor = MainColor;
            RecupLivres();
        }

        private void RecupLivres()
        {
            string query = "select * from Livres join Auteur on Livres.Id_Auteur = Auteur.Id_Auteur join Langue on Livres.Id_Langue = Langue.Id_Langue where Id_livre = @id_livre";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.command.Parameters.AddWithValue("@id_livre", BookId);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            DataTable table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                labelTitre.Text = (string)row["Titre_livre"];

                labelAuthor.Text = "de " + (string)row["Nom"];
                DateTime date = Convert.ToDateTime(row["Date_Publi"]);
                labelDate.Text = date.ToString("dd/MM/yyyy");

                byte[] imgg = (byte[])row["Miniature"];
                MemoryStream ms = new MemoryStream(imgg);
                pictureBox.Image = System.Drawing.Image.FromStream(ms);

                labelIntrigue.Text = (string)row["Intrigue"];

                labelLangue.Text = (string)row["Acronyme"];

                labelPrix.Text = (float)row["Prix"] + "€";

            }

            if (mySqlDb.connection.State == ConnectionState.Open)
            {
                mySqlDb.connection.Close();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenFrom.ActivateButton(OpenFrom.iconBtnRead,MainColor);
            OpenFrom.OpenChildForm(new FormRead(MainColor, OpenFrom));
        }

        private void panelIntrigue_Resize(object sender, EventArgs e)
        {
            labelIntrigue.MaximumSize = new Size(panelIntrigue.Width,0);
        }
    }
}
