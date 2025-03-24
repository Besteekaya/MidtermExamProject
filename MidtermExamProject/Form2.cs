using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermExamProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string task = txtTask.Text.Trim();
            if (string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Enter a task!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lstTask.Items.Add(task);
            txtTask.Clear();
            txtTask.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstTask.SelectedIndex == -1)
            {
                MessageBox.Show(" please select a task to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lstTask.Items.RemoveAt(lstTask.SelectedIndex);
        }

        private void backMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstTask = null;
        }
    }
}
