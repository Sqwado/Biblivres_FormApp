using System;
using System.Data;
using System.Windows.Forms;
using Biblivres.Globals;
using MySql.Data.MySqlClient;

namespace Biblivres
{
    public partial class FormLogin : Form
    {
        private readonly MySqlDb mySqlDb = new MySqlDb();

        public FormLogin()
        {
            mySqlDb.InitConnection();
            InitializeComponent();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
                textBoxPass.PasswordChar = '\0';
            else
                textBoxPass.PasswordChar = '*';
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            var query = "select * from Admin where email = @email";
            mySqlDb.command = new MySqlCommand(query, mySqlDb.connection);
            mySqlDb.command.Parameters.AddWithValue("@email", textBoxEmail.Text);
            mySqlDb.data = new MySqlDataAdapter(mySqlDb.command);
            var table = new DataTable();
            mySqlDb.data.Fill(table);
            if (table.Rows.Count > 0)
            {
                if (BCrypt.Net.BCrypt.Verify(textBoxPass.Text, (string)table.Rows[0]["password"]))
                {
                    MessageBox.Show("Connexion réussie");
                    var mainForm = new FormMainMenu();
                    mainForm.Show();
                    mainForm.FormClosed += (s, args) => Close();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }
            }
            else
            {
                MessageBox.Show("Email incorrect");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = string.Empty;
            textBoxPass.Text = string.Empty;
        }
    }
}