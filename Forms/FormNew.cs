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
        private byte[] MiniatureFile;
        private MySqlDb mySqlDb = new MySqlDb();

        public FormNew(Color mainColor, FormMainMenu openFrom)
        {
            MainColor = mainColor;
            OpenFrom = openFrom;
            mySqlDb.InitConnection();
            InitializeComponent();
            this.BackColor = MainColor;
            GetLangue();
            GetAuteur();
            GetGenre();
            GetTypes();

        }

        private void GetLangue()
        {
            string query = "select * from Langue";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            DataTable table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                comboBoxLangue.Items.Add(new ComboItem { ID = (int)row["Id_Langue"], Text = (string)row["Language"] });
            }
            comboBoxLangue.SelectedIndex = 0;
        }

        private void GetAuteur()
        {
            string query = "select * from Auteur";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            DataTable table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                comboBoxAuteur.Items.Add(new ComboItem { ID = (int)row["Id_Auteur"], Text = (string)row["Nom"] });
            }
            comboBoxAuteur.SelectedIndex = 0;
        }

        private void GetGenre()
        {
            string query = "select * from Genre";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            DataTable table = new DataTable();
            mySqlDb.data.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                comboBoxGenre.Items.Add(new ComboItem { ID = (int)row["Id_Genre"], Text = (string)row["Titre_Genre"] });
            }
            comboBoxGenre.SelectedIndex = 0;
        }

        private void GetTypes()
        {
            string query = "select * from Types";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            DataTable table = new DataTable();
            mySqlDb.data.Fill(table);

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
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
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
                mySqlDb.command.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("New Livre Added Successfully!!");
                OpenFrom.ActivateButton(OpenFrom.iconBtnRead, MainColor);
                OpenFrom.OpenChildForm(new FormRead(MainColor, OpenFrom));

                if (mySqlDb.connection.State == ConnectionState.Open)
                {
                    mySqlDb.connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erraor sending data to database: " + ex.Message);
            }

        }


    }
}
