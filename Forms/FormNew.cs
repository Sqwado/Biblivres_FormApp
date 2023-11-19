﻿using Biblivres.Globals;
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
            GetAuteur();
            GetGenre();
            GetTypes();

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
                comboBoxAuteur.Items.Add(new ComboItem { ID = (int)row["Id_Auteur"], Text = (string)row["Nom"] });
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
                comboBoxGenre.Items.Add(new ComboItem { ID = (int)row["Id_Genre"], Text = (string)row["Titre_Genre"] });
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
                comboBoxType.Items.Add(new ComboItem { ID = (int)row["Id_Types"], Text = (string)row["Types"] });
            }
            comboBoxType.SelectedIndex = 0;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitre.Text != "" && MiniatureFile != null && textBoxIntrigue.Text != "" && textBoxEditeur.Text != "")
            {
                var confirmResult = MessageBox.Show("Are you sure to add this livre ??", "Confirm Add!!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    AddLivre();
                }
                else
                {
                    MessageBox.Show("Add canceled!!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!!");
            }

        }

        private void AddLivre()
        {
            try
            {
                string query = "insert into Livres (Titre_Livre, Miniature, Intrigue, Id_Langue, Date_Publi, Id_Auteur, Id_Genre, Id_Types, Prix, Nb_Pages, Editeur, Quantity) values(@Titre_Livre, @Miniature, @Intrigue, @Id_Langue, @Date_Publi, @Id_Auteur, @Id_Genre, @Id_Types, @Prix, @Nb_Pages, @Editeur, @Quantity);";
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
                command.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("New Livre Added Successfully!!");
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
