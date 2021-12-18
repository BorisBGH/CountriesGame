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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var users = UserResultsStorage.GetResults();

            foreach (var user in users)
            {
                dataGridView1.Rows.Add(user.Name, user.Score);
            }
        }
    }
}
