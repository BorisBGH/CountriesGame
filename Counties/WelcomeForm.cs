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
    public partial class WelcomeForm : Form
    {
        public string userName = "";

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            if (InputChecker.CheckUserInput(name_textBox.Text))
            {
                userName = name_textBox.Text;
                Close();
            }
            else
            {
                MessageBox.Show("Введите имя, состоящее из букв");
            }
        }
    }
}
