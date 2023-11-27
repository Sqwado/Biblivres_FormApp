using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Biblivres.Globals;
using MySql.Data.MySqlClient;

namespace Biblivres.Forms
{
    public partial class FormReadOne : Form
    {
        private readonly int BookId;

        // Fields
        private readonly Color MainColor;
        private readonly MySqlDb mySqlDb = new MySqlDb();
        private readonly FormMainMenu OpenFrom;

        public FormReadOne(Color mainColor, FormMainMenu openFrom, int bookId)
        {
            MainColor = mainColor;
            OpenFrom = openFrom;
            BookId = bookId;
            mySqlDb.InitConnection();
            InitializeComponent();
            BackColor = MainColor;
            RecupLivres();
        }

        private void RecupLivres()
        {
            var query =
                "select * from Livres join Auteur on Livres.Id_Auteur = Auteur.Id_Auteur join Langue on Livres.Id_Langue = Langue.Id_Langue where Id_livre = @id_livre";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.command.Parameters.AddWithValue("@id_livre", BookId);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            var table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                labelTitre.Text = (string)row["Titre_livre"];

                labelAuthor.Text = "de " + (string)row["Nom"];
                var date = Convert.ToDateTime(row["Date_Publi"]);
                labelDate.Text = date.ToString("dd/MM/yyyy");

                var imgg = (byte[])row["Miniature"];
                var ms = new MemoryStream(imgg);
                pictureBox.Image = Image.FromStream(ms);

                labelIntrigue.Text = (string)row["Intrigue"];

                labelLangue.Text = (string)row["Acronyme"];

                labelPrix.Text = (float)row["Prix"] + "€";
            }

            if (mySqlDb.connection.State == ConnectionState.Open) mySqlDb.connection.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            OpenFrom.ActivateButton(OpenFrom.iconBtnRead, MainColor);
            OpenFrom.OpenChildForm(new FormRead(MainColor, OpenFrom));
        }

        private void panelIntrigue_Resize(object sender, EventArgs e)
        {
            labelIntrigue.MaximumSize = new Size(panelIntrigue.Width, 0);
        }
    }
}