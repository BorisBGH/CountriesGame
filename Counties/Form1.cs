using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countries
{
    public partial class CountriesGame : Form
    {
        List<Country> countries = CountryStorage.GetAll();
        int count;
        int randomInd;
        Country currentCountry;
        User user;
       

        public CountriesGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            count = countries.Count;
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();

            user = new User(welcomeForm.userName);

            ShowNextQuestion();
            
            
        }

        private void ShowNextQuestion()
        {
            
            
                Random random = new Random();
                randomInd = random.Next(0, countries.Count);
                currentCountry = countries[randomInd];

                country_label.Text = currentCountry.Name;
                textBox.Text = string.Empty;

            

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            string userAnswer = textBox.Text;
          
            
            if (InputChecker.CheckUserInput(textBox.Text) && textBox.Text == currentCountry.Capital)
            {
                MessageBox.Show("Верно!");
                user.AcceptAnswer();
            }
            else if (InputChecker.CheckUserInput(textBox.Text) && textBox.Text != currentCountry.Capital)
            {
                MessageBox.Show("Неверно!");
            }
            else
            {
                MessageBox.Show("Введите название города, состоящее из букв");
                return;
            }
            countries.Remove(currentCountry);
           


            if (countries.Count <= 0)
            {
                user.Diagnose = DiagnoseCalculator.Calculate(count, user.Score);
              //  MessageBox.Show($"Стран больше нет!\nВаш результат: {user.Score} из {count}.\nВаш уровень: {user.Diagnose}");
                next_button.Enabled = false;
                country_label.Text = "Игра окончена";
               
                UserResultsStorage.Save(user);

                Finish finish = new Finish();
                finish.label_gameOver.Text = $"Стран больше нет. Игра окончена!";
                finish.label_result.Text = $"Ваш результат: {user.Score} из {count}.\n\nВаш уровень: {user.Diagnose}";
                finish.Show();
            }
            else
            {
                ShowNextQuestion();
            }

        }

        private void показатьРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.Show();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
