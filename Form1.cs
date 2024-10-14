using System.Data.SQLite;
using System.Linq.Expressions;
using System.Timers;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace SuperCalculator
{
    public partial class Form1 : Form
    {
        //Main Screen
        private bool isEnabled = false;
        private System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            buttonHideOrUnhideMenu.Height = 90;
            labelMenu.Visible = false;
            buttonSettings.Visible = false;
            buttonSolves.Visible = false;
            buttonHelp.Visible = false;

            //Settings data updater
            timer = new System.Timers.Timer(1000); //or smaller count(500, 100...)
            timer.Elapsed += DataUpdater;
            timer.AutoReset = true;
            timer.Enabled = true;

            string connectionString = "Data Source=SolutionsData.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS SolutionsTable (Solution TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

        }

        private void Number_Button_Click(object sender, EventArgs e)
        {
            var button_value = (sender as Button).Text;
            solveBox.Text += button_value;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            solveBox.Clear();
        }

        private void Equals_Button_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SolutionsData.db;Version=3;";
            try {
                string solutionData = solveBox.Text;
                var answer = solveBox.Text;
                var result = Solve(answer);
                string final_result = result.ToString();
                solveBox.Text = final_result;

                static double Solve(string answer)
                {
                    return CSharpScript.EvaluateAsync<double>(answer).Result;
                }

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string insertSolutionQuery = "INSERT INTO SolutionsTable (Solution) VALUES (@solution)";
                    using (SQLiteCommand command = new SQLiteCommand(insertSolutionQuery, connection))
                    {
                        command.Parameters.AddWithValue("@solution", solutionData);

                        command.ExecuteNonQuery();
                    }
                }
            } catch {
                solveBox.Text = "0";
            }
        }

        private void Button_Open_Menu_Clicked(object sender, EventArgs e)
        {
            isEnabled = !isEnabled;
            if (isEnabled)
            {
                buttonHideOrUnhideMenu.Text = "close menu";
                buttonHideOrUnhideMenu.Height = 25;
                labelMenu.Visible = true;
                buttonSettings.Visible = true;
                buttonSolves.Visible = true;
                buttonHelp.Visible = true;
            } else {
                buttonHideOrUnhideMenu.Text = "open menu";
                buttonHideOrUnhideMenu.Height = 90;
                labelMenu.Visible = false;
                buttonSettings.Visible = false;
                buttonSolves.Visible = false;
                buttonHelp.Visible = false;
            }
        }

        private void Show_Sttings_Window(object sender, EventArgs e)
        {
            Form2 settingsForm = new Form2();
            settingsForm.Show();
        }

        private void Button_Solves_Clicked(object sender, EventArgs e)
        {
            Form3 solvesForm = new Form3();
            solvesForm.Show();
        }

        private void Button_Help_Clicked(object sender, EventArgs e)
        {
            Form4 helpForm = new Form4();
            helpForm.Show();
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
                            button0.BackColor = numcolor;
                            button000.BackColor = numcolor;
                            button1.BackColor = numcolor;
                            button2.BackColor = numcolor;
                            button3.BackColor = numcolor;
                            button4.BackColor = numcolor;
                            button5.BackColor = numcolor;
                            button6.BackColor = numcolor;
                            button7.BackColor = numcolor;
                            button8.BackColor = numcolor;
                            button9.BackColor = numcolor;

                            button0.ForeColor = textcolor;
                            button000.ForeColor = textcolor;
                            button1.ForeColor = textcolor;
                            button2.ForeColor = textcolor;
                            button3.ForeColor = textcolor;
                            button4.ForeColor = textcolor;
                            button5.ForeColor = textcolor;
                            button6.ForeColor = textcolor;
                            button7.ForeColor = textcolor;
                            button8.ForeColor = textcolor;
                            button9.ForeColor = textcolor;
                            if (solveBox.InvokeRequired)
                            {
                                solveBox.Invoke(new Action(() =>{solveBox.Font = fontView;solveBox.BackColor = ansBoxcolor;}));
                            }
                            else
                            {
                                solveBox.Font = fontView;
                                solveBox.BackColor = ansBoxcolor;
                            }
                            buttonPlus.BackColor = actioncolor;
                            buttonMinus.BackColor = actioncolor;
                            buttonMultiply.BackColor = actioncolor;
                            buttonApostrof.BackColor = actioncolor;
                            buttonDouble.BackColor = actioncolor;
                            buttonBracket1.BackColor = actioncolor;
                            buttonBracket2.BackColor = actioncolor;
                            this.BackColor = appcolor;
                        }
                    }
                }
            }
        }
    }
}
