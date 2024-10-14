using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SuperCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            fontstylebox.SetSelected(5, true);

            //Default settings
            string selectedFont = "Normal";
            int final_numSize = 18;
            string selectedcol = "#ffffff";

            string connectionString = "Data Source=ParamsSettingsValues.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS ParamsValuesTable (NumCol TEXT, ActionCol TEXT, AppCol TEXT, TextCol TEXT, AnsBoxCol TEXT, Font TEXT, FontSize INTEGER)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "INSERT INTO ParamsValuesTable (Font, FontSize) VALUES (@font, @fontsize)";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@font", selectedFont);
                    command.Parameters.AddWithValue("@fontsize", final_numSize);

                    command.ExecuteNonQuery();
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string insertNumColQuery = "INSERT INTO ParamsValuesTable (NumCol, ActionCol, AppCol, TextCol, AnsBoxCol) VALUES (@numcol, @actioncol, @appcol, @textcol, @ansboxcol)";
                using (SQLiteCommand command = new SQLiteCommand(insertNumColQuery, connection))
                {
                    command.Parameters.AddWithValue("@numcol", selectedcol);
                    command.Parameters.AddWithValue("@actioncol", selectedcol);
                    command.Parameters.AddWithValue("@appcol", selectedcol);
                    command.Parameters.AddWithValue("@textcol", selectedcol);
                    command.Parameters.AddWithValue("@ansboxcol", selectedcol);

                    command.ExecuteNonQuery();
                }
            }

            //Deleting extra lines
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteOnlyOne = "DELETE FROM ParamsValuesTable WHERE rowid > 1";
                using (SQLiteCommand command = new SQLiteCommand(deleteOnlyOne, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string fetchData = "SELECT * FROM ParamsValuesTable WHERE rowid = 1";
                using (SQLiteCommand command = new SQLiteCommand(fetchData, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string numCol = $"{reader["NumCol"]}";
                            string actionCol = $"{reader["ActionCol"]}";
                            string appCol = $"{reader["AppCol"]}";
                            string textCol = $"{reader["TextCol"]}";
                            string ansBoxCol = $"{reader["AnsBoxCol"]}";
                            string fontData = $"{reader["Font"]}";
                            string fontsizeData = $"{reader["FontSize"]}";
                            int fontSize = Convert.ToInt32(fontsizeData);
                            Color numcolor = ColorTranslator.FromHtml(numCol);
                            Color actioncolor = ColorTranslator.FromHtml(actionCol);
                            Color appcolor = ColorTranslator.FromHtml(appCol);
                            Color textcolor = ColorTranslator.FromHtml(textCol);
                            Color ansBoxcolor = ColorTranslator.FromHtml(ansBoxCol);
                            Font fontView = new Font(fontData, fontSize);
                            numbtncol.BackColor = numcolor;
                            actionbtncol.BackColor = actioncolor;
                            appbackcol.BackColor = appcolor;
                            txtcol.BackColor = textcolor;
                            ansboxbackcol.BackColor = ansBoxcolor;
                            answerboxview.BackColor = ansBoxcolor;
                            answerboxview.Font = fontView;
                            fontdataView.Text = "text font: " + fontData;
                            symbolssize.Value = fontSize;
                            this.BackColor = appcolor;
                        }
                    }
                }
            }
        }

        private void Choose_Num_Col(object sender, EventArgs e)
        {
            ColorDialog numdlg = new ColorDialog();
            numdlg.ShowDialog();
            numbtncol.BackColor = numdlg.Color;
            Color selectedColor = numdlg.Color;
            string colorString = ColorTranslator.ToHtml(selectedColor);

            string connectionString = "Data Source=ParamsSettingsValues.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE ParamsValuesTable SET NumCol = @numcol WHERE rowid = 1";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@numcol", colorString);

                    command.ExecuteNonQuery();
                }
            }

        }

        private void Choose_Action_Col(object sender, EventArgs e)
        {
            ColorDialog actiondlg = new ColorDialog();
            actiondlg.ShowDialog();
            actionbtncol.BackColor = actiondlg.Color;
            Color selectedColor = actiondlg.Color;
            string colorString = ColorTranslator.ToHtml(selectedColor);

            string connectionString = "Data Source=ParamsSettingsValues.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE ParamsValuesTable SET ActionCol = @actioncol WHERE rowid = 1";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@actioncol", colorString);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void Choose_App_Col(object sender, EventArgs e)
        {
            ColorDialog appdlg = new ColorDialog();
            appdlg.ShowDialog();
            appbackcol.BackColor = appdlg.Color;
            this.BackColor = appdlg.Color;
            Color selectedColor = appdlg.Color;
            string colorString = ColorTranslator.ToHtml(selectedColor);

            string connectionString = "Data Source=ParamsSettingsValues.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE ParamsValuesTable SET AppCol = @appcol WHERE rowid = 1";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@appcol", colorString);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void Choose_Text_Col(object sender, EventArgs e)
        {
            ColorDialog txtdlg = new ColorDialog();
            txtdlg.ShowDialog();
            txtcol.BackColor = txtdlg.Color;
            Color selectedColor = txtdlg.Color;
            string colorString = ColorTranslator.ToHtml(selectedColor);

            string connectionString = "Data Source=ParamsSettingsValues.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE ParamsValuesTable SET TextCol = @textcol WHERE rowid = 1";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@textcol", colorString);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void Choose_AnsBox_Col(object sender, EventArgs e)
        {
            ColorDialog ansdlg = new ColorDialog();
            ansdlg.ShowDialog();
            ansboxbackcol.BackColor = ansdlg.Color;
            answerboxview.BackColor = ansdlg.Color;
            Color selectedColor = ansdlg.Color;
            string colorString = ColorTranslator.ToHtml(selectedColor);

            string connectionString = "Data Source=ParamsSettingsValues.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE ParamsValuesTable SET AnsBoxCol = @ansboxcol WHERE rowid = 1";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@ansboxcol", colorString);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void Choose_Font_AnsBox(object sender, EventArgs e)
        {
            try
            {
                string selectedFont = fontstylebox.SelectedItem.ToString();
                decimal numSize = symbolssize.Value;
                int final_numSize = int.Parse(numSize.ToString());
                fontdataView.Text = "text font: " + selectedFont;

                if (selectedFont == null || final_numSize == 0)
                {
                    selectedFont = "Normal";
                    final_numSize = 5;
                }

                Font ansboxFont = new Font(selectedFont, final_numSize);

                answerboxview.Font = ansboxFont;

                string connectionString = "Data Source=ParamsSettingsValues.db;Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE ParamsValuesTable SET Font = @font, FontSize = @fontsize WHERE rowid = 1";
                    using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@font", selectedFont);
                        command.Parameters.AddWithValue("@fontsize", final_numSize);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                error.Text = "Error. please, slect all parameters to apply this settings.";
            }
        }
    }
}
