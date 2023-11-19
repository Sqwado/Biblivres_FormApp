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

    public partial class FormChange : Form
    {
        // Fields
        private Color MainColor;
        private int BookId;
        private FormMainMenu OpenFrom;
        private MySqlConnection connection;
        private MySqlCommand command;
        private byte[] MiniatureFile;
        private MySqlDataAdapter data;

        private ComboItem[] Langues = new ComboItem[] { };
        private ComboItem[] Auteurs = new ComboItem[] { };
        private ComboItem[] Genres = new ComboItem[] { };
        private ComboItem[] Types = new ComboItem[] { };

        public FormChange(Color mainColor, FormMainMenu openFrom, int bookId)
        {
            MainColor = mainColor;
            OpenFrom = openFrom;
            BookId = bookId;
            InitConnection();
            InitializeComponent();
            this.BackColor = MainColor;
            GetLangue();
            GetAuteur();
            GetGenre();
            GetTypes();
            GetLivre();

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
                ComboItem langue = new ComboItem { ID = (int)row["Id_Langue"], Text = (string)row["Language"] };
                Console.WriteLine("test");
                Console.WriteLine(Langues);
                Langues = Langues.Append(langue).ToArray();
                comboBoxLangue.Items.Add(langue);
            }
            comboBoxLangue.SelectedIndex = 0;
        }

        private void GetAuteur()
        {
            string query = "select * from Auteur";
            command = new MySqlCommand(query, connection);
            data = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                ComboItem auteur = new ComboItem { ID = (int)row["Id_Auteur"], Text = (string)row["Nom"] };
                Auteurs = Auteurs.Append(auteur).ToArray();
                comboBoxAuteur.Items.Add(auteur);
            }
            comboBoxAuteur.SelectedIndex = 0;
        }

        private void GetGenre()
        {
            string query = "select * from Genre";
            command = new MySqlCommand(query, connection);
            data = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                ComboItem genre = new ComboItem { ID = (int)row["Id_Genre"], Text = (string)row["Titre_Genre"] };
                Genres = Genres.Append(genre).ToArray();
                comboBoxGenre.Items.Add(genre);
            }
            comboBoxGenre.SelectedIndex = 0;
        }

        private void GetTypes()
        {
            string query = "select * from Types";
            command = new MySqlCommand(query, connection);
            data = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                ComboItem type = new ComboItem { ID = (int)row["Id_Types"], Text = (string)row["Types"] };
                Types = Types.Append(type).ToArray();
                comboBoxType.Items.Add(type);
            }
            comboBoxType.SelectedIndex = 0;
        }

        private ComboItem GetComboById(ComboItem[] comboItems, int id)
        {
            foreach (ComboItem item in comboItems)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        private void GetLivre()
        {
            string query = "select * from Livres where Id_Livre = @Id_Livre";
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id_Livre", BookId);
            data = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            data.Fill(table);

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
                comboBoxLangue.SelectedItem = GetComboById(Langues,(int)row["Id_Langue"]);
                comboBoxAuteur.SelectedItem = GetComboById(Auteurs, (int)row["Id_Auteur"]);
                comboBoxGenre.SelectedItem = GetComboById(Genres, (int)row["Id_Genre"]);
                comboBoxType.SelectedItem = GetComboById(Types, (int)row["Id_Types"]);
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxTitre.Text != "" && MiniatureFile != null && textBoxIntrigue.Text != "" && textBoxEditeur.Text != "")
            {
                var confirmResult = MessageBox.Show("Are you sure to modify this livre ??", "Confirm Add!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    ChangeLivre();
                }
                else
                {
                    MessageBox.Show("Change canceled!!");
                }
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
                string query = "update Livres SET Titre_Livre = @Titre_Livre, Miniature = @Miniature, Intrigue = @Intrigue, Id_Langue = @Id_Langue, Date_Publi = @Date_Publi, Id_Auteur = @Id_Auteur, Id_Genre = @Id_Genre, Id_Types = @Id_Types, Prix = @Prix, Nb_Pages = @Nb_Pages, Editeur = @Editeur, Quantity = @Quantity where Id_Livre = @Id_Livre;";
                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Titre_Livre", textBoxTitre.Text);
                command.Parameters.AddWithValue("@Miniature", MiniatureFile);
                command.Parameters.AddWithValue("@Intrigue", textBoxIntrigue.Text);
                command.Parameters.AddWithValue("@Id_Langue", ((ComboItem)comboBoxLangue.SelectedItem).ID);
                command.Parameters.AddWithValue("@Date_Publi", dateTimePickerDate.Value);
                command.Parameters.AddWithValue("@Id_Auteur", ((ComboItem)comboBoxAuteur.SelectedItem).ID);
                command.Parameters.AddWithValue("@Id_Genre", ((ComboItem)comboBoxGenre.SelectedItem).ID);
                command.Parameters.AddWithValue("@Id_Types", ((ComboItem)comboBoxType.SelectedItem).ID);
                command.Parameters.AddWithValue("@Prix", numericUpDownPrix.Value);
                command.Parameters.AddWithValue("@Nb_Pages", numericUpDownPage.Value);
                command.Parameters.AddWithValue("@Editeur", textBoxEditeur.Text);
                command.Parameters.AddWithValue("@Quantity", numericUpDownQuantity.Value);
                command.Parameters.AddWithValue("@Id_Livre", BookId);
                command.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Livre Modify Successfully!!");
                OpenFrom.ActivateButton(OpenFrom.iconBtnRead, MainColor);
                OpenFrom.OpenChildForm(new FormRead(MainColor, OpenFrom));

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erraor sending data to database: " + ex.Message);
            }

        }


    }
}
