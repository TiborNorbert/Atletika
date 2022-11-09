using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atletika
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "atletikavb2017";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {

                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT DISTINCT versenyekszamok.Versenyszam FROM `versenyekszamok`";

                using (MySqlDataReader dr = command.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        Versenyszámok.Items.Add(dr.GetString("Versenyszam"));

                    }

                }
                connection.Close();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);

            }
        }

        private void aranyos(object sender, EventArgs e)
        {
            connection.Open();
            command.CommandText = "SELECT DISTINCT nemzetek.NemzetID, nemzetek.Nemzet FROM nemzetek, versenyekszamok WHERE nemzetek.NemzetId = versenyekszamok.NemzetKod AND versenyekszamok.Helyezes=1 AND versenyekszamok.Nem = 'F';";
            aranyosnemzetek.Items.Clear();

            using (MySqlDataReader dr1 = command.ExecuteReader())
            {

                while (dr1.Read())
                {

                    nemzet hozaadverseny = new nemzet(dr1.GetInt32("NemzetID"), dr1.GetString("Nemzet"));
                    aranyosnemzetek.Items.Add(hozaadverseny);
                }

            }
            connection.Close();
        }

        private void kereses_Click(object sender, EventArgs e)
        {

            if (Versenyszámok.SelectedIndex < 0)
            {

                MessageBox.Show("Nem választott ki versenyszámot!");
                return;

            }
            connection.Open();
            command.CommandText = $"SELECT versenyekszamok.VersenyzoNev, versenyekszamok.Eredmeny, nemzetek.Nemzet FROM versenyekszamok JOIN nemzetek ON versenyekszamok.NemzetKod = nemzetek.NemzetId WHERE versenyekszamok.Versenyszam = '{Versenyszámok.SelectedItem.ToString()}' AND versenyekszamok.Helyezes = '{num.Value.ToString()}' AND versenyekszamok.Nem = 'F';";
            using (MySqlDataReader dr1 = command.ExecuteReader())
            {

                while (dr1.Read())
                {

                    nevlab.Text = dr1.GetString("VersenyzoNev");
                    eredmnylab.Text = dr1.GetString("Eredmeny");
                    nemzetlab.Text = dr1.GetString("Nemzet");

                }

            }

            connection.Close();
        }
    }
}

