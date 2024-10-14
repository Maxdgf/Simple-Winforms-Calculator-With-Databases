using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class Form3 : Form
    {
        private System.Timers.Timer timer;
        public Form3()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //Settings data updater
            timer = new System.Timers.Timer(1000); //or smaller count(500, 100...)
            timer.Elapsed += DataUpdater;
            timer.AutoReset = true;
            timer.Enabled = true;

            string connectionString = "Data Source=SolutionsData.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string fetchSolutionsDataQuery = "SELECT * FROM SolutionsTable";
                using (SQLiteCommand command = new SQLiteCommand(fetchSolutionsDataQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            solvesView.Items.Add($"{reader["Solution"]}");
                        }
                    }
                }
            }
        }

        private void searchEvent(object sender, EventArgs e)
        {
            try
            {
                string searchData = searchString.Text;
                int stringsCount = solvesView.Items.Count;
                for (int i = 0; i < stringsCount; i++)
                {
                    string searchResult = solvesView.Items[i].ToString();
                    if (searchResult == searchData)
                    {
                        string index = i.ToString();
                        string result = solvesView.Items[i].ToString();
                        //resBox.Items.Clear();
                        resBox.Items.Add("string -> " + index + " " + result);
                    }
                }
            }
            catch
            {
                searchString.Text = "error! please, try again.";
            }
        }

        private void ClearResultBox(object sender, EventArgs e)
        {
            resBox.Items.Clear();
        }

        private async void DataUpdater(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ParamsSettingsValues.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string fetchSettingsData = "SELECT * FROM ParamsValuesTable WHERE rowid = 1";
                using (SQLiteCommand command = new SQLiteCommand(fetchSettingsData, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string appCol = $"{reader["AppCol"]}";
                            Color appcolor = ColorTranslator.FromHtml(appCol);
                            //this.BackColor = appcolor;
                            if (this.InvokeRequired)
                            {
                                this.Invoke(new Action(() => { this.BackColor = appcolor; }));
                            }
                            else
                            {
                                this.BackColor = appcolor;
                            }
                        }
                            
                    }
                }
            }
        }
    }
}
