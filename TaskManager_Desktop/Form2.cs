using System;
using System.Windows.Forms;

namespace TaskManager_Desktop
{
    public partial class Form2 : Form
    {
        public string TaskDescription { get; private set; }

        public Form2(string currentTask = "")
        {
            InitializeComponent();
            txtTask.Text = currentTask;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTask.Text))
            {
                MessageBox.Show("Please enter a task description",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaskDescription = txtTask.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}