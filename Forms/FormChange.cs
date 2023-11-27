using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Biblivres.Globals;
using MySql.Data.MySqlClient;

namespace Biblivres.Forms
{
    public partial class FormChange : Form
    {
        private ComboItem[] Auteurs = { };
        private readonly int BookId;
        private ComboItem[] Genres = { };

        private ComboItem[] Langues = { };

        // Fields
        private readonly Color MainColor;
        private byte[] MiniatureFile;
        private readonly MySqlDb mySqlDb = new MySqlDb();
        private readonly FormMainMenu OpenFrom;
        private ComboItem[] Types = { };

        public FormChange(Color mainColor, FormMainMenu openFrom, int bookId)
        {
            MainColor = mainColor;
            OpenFrom = openFrom;
            BookId = bookId;
            mySqlDb.InitConnection();
            InitializeComponent();
            BackColor = MainColor;
            GetLangue();
            GetAuteur();
            GetGenre();
            GetTypes();
            GetLivre();
        }

        private void GetLangue()
        {
            var query = "select * from Langue";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            var table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                var langue = new ComboItem { ID = (int)row["Id_Langue"], Text = (string)row["Language"] };
                Console.WriteLine("test");
                Console.WriteLine(Langues);
                Langues = Langues.Append(langue).ToArray();
                comboBoxLangue.Items.Add(langue);
            }

            comboBoxLangue.SelectedIndex = 0;
        }

        private void GetAuteur()
        {
            var query = "select * from Auteur";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            var table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                var auteur = new ComboItem { ID = (int)row["Id_Auteur"], Text = (string)row["Nom"] };
                Auteurs = Auteurs.Append(auteur).ToArray();
                comboBoxAuteur.Items.Add(auteur);
            }

            comboBoxAuteur.SelectedIndex = 0;
        }

        private void GetGenre()
        {
            var query = "select * from Genre";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            var table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                var genre = new ComboItem { ID = (int)row["Id_Genre"], Text = (string)row["Titre_Genre"] };
                Genres = Genres.Append(genre).ToArray();
                comboBoxGenre.Items.Add(genre);
            }

            comboBoxGenre.SelectedIndex = 0;
        }

        private void GetTypes()
        {
            var query = "select * from Types";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            var table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                var type = new ComboItem { ID = (int)row["Id_Types"], Text = (string)row["Types"] };
                Types = Types.Append(type).ToArray();
                comboBoxType.Items.Add(type);
            }

            comboBoxType.SelectedIndex = 0;
        }

        private ComboItem GetComboById(ComboItem[] comboItems, int id)
        {
            foreach (var item in comboItems)
                if (item.ID == id)
                    return item;

            return null;
        }

        private void GetLivre()
        {
            var query = "select * from Livres where Id_Livre = @Id_Livre";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.command.Parameters.AddWithValue("@Id_Livre", BookId);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            var table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                textBoxTitre.Text = (string)row["Titre_Livre"];
                textBoxIntrigue.Text = (string)row["Intrigue"];
                textBoxEditeur.Text = (string)row["Editeur"];
                numericUpDownPrix.Value = Convert.ToDecimal(row["Prix"]);
                numericUpDownPage.Value = (int)row["Nb_Pages"];
                numericUpDownQuantity.Value = (int)row["Quantity"];
                dateTimePickerDate.Value = (DateTime)row["Date_Publi"];
                MiniatureFile = (byte[])row["Miniature"];
                pictureBoxMiniature.Image = Image.FromStream(new MemoryStream(MiniatureFile));
                buttonMiniature.Text = "Miniature";
                comboBoxLangue.SelectedItem = GetComboById(Langues, (int)row["Id_Langue"]);
                comboBoxAuteur.SelectedItem = GetComboById(Auteurs, (int)row["Id_Auteur"]);
                comboBoxGenre.SelectedItem = GetComboById(Genres, (int)row["Id_Genre"]);
                comboBoxType.SelectedItem = GetComboById(Types, (int)row["Id_Types"]);
            }
        }

        private void buttonMiniature_Click(object sender, EventArgs e)
        {
            var opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMiniature.Image = new Bitmap(opnfd.FileName);
                buttonMiniature.Text = Path.GetFileName(opnfd.FileName);
                MiniatureFile = File.ReadAllBytes(opnfd.FileName);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxTitre.Text != "" && MiniatureFile != null && textBoxIntrigue.Text != "" &&
                textBoxEditeur.Text != "")
            {
                var confirmResult = MessageBox.Show("Are you sure to modify this livre ??", "Confirm Add!!",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                    ChangeLivre();
                else
                    MessageBox.Show("Change canceled!!");
            }
            else
            {
                MessageBox.Show("Please fill all the fields!!");
            }
        }

        private void ChangeLivre()
        {
            try
            {
                var query =
                    "update Livres SET Titre_Livre = @Titre_Livre, Miniature = @Miniature, Intrigue = @Intrigue, Id_Langue = @Id_Langue, Date_Publi = @Date_Publi, Id_Auteur = @Id_Auteur, Id_Genre = @Id_Genre, Id_Types = @Id_Types, Prix = @Prix, Nb_Pages = @Nb_Pages, Editeur = @Editeur, Quantity = @Quantity where Id_Livre = @Id_Livre;";
                mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
                mySqlDb.command.Parameters.AddWithValue("@Titre_Livre", textBoxTitre.Text);
                mySqlDb.command.Parameters.AddWithValue("@Miniature", MiniatureFile);
                mySqlDb.command.Parameters.AddWithValue("@Intrigue", textBoxIntrigue.Text);
                mySqlDb.command.Parameters.AddWithValue("@Id_Langue", ((ComboItem)comboBoxLangue.SelectedItem).ID);
                mySqlDb.command.Parameters.AddWithValue("@Date_Publi", dateTimePickerDate.Value);
                mySqlDb.command.Parameters.AddWithValue("@Id_Auteur", ((ComboItem)comboBoxAuteur.SelectedItem).ID);
                mySqlDb.command.Parameters.AddWithValue("@Id_Genre", ((ComboItem)comboBoxGenre.SelectedItem).ID);
                mySqlDb.command.Parameters.AddWithValue("@Id_Types", ((ComboItem)comboBoxType.SelectedItem).ID);
                mySqlDb.command.Parameters.AddWithValue("@Prix", numericUpDownPrix.Value);
                mySqlDb.command.Parameters.AddWithValue("@Nb_Pages", numericUpDownPage.Value);
                mySqlDb.command.Parameters.AddWithValue("@Editeur", textBoxEditeur.Text);
                mySqlDb.command.Parameters.AddWithValue("@Quantity", numericUpDownQuantity.Value);
                mySqlDb.command.Parameters.AddWithValue("@Id_Livre", BookId);
                mySqlDb.command.ExecuteReader(); // Here our query will be executed and data saved into the database.
                MessageBox.Show("Livre Modify Successfully!!");
                OpenFrom.ActivateButton(OpenFrom.iconBtnRead, MainColor);
                OpenFrom.OpenChildForm(new FormRead(MainColor, OpenFrom));

                if (mySqlDb.connection.State == ConnectionState.Open) mySqlDb.connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erraor sending data to database: " + ex.Message);
            }
        }
    }
}