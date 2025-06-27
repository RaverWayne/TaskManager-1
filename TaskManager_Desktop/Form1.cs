using System;
using System.Windows.Forms;
using TaskManager_Business_Logic;
using TaskManager_Data_Logic;

namespace TaskManager_Desktop
{
    public partial class frmMain : Form
    {
        private TaskManagerService _taskService;
        private string _currentDataSource = "InMemory";

        public frmMain()
        {
            InitializeComponent();
            InitializeDataService();
            SetupDataBindings();
        }

        private void InitializeDataService()
        {
            ITaskDataService dataService = _currentDataSource switch
            {
                "TextFile" => new TextFileDataService(),
                "JsonFile" => new JsonFileDataService(),
                _ => new InMemoryDataService()
            };
            _taskService = new TaskManagerService(dataService);
            RefreshTaskList();
        }

        private void SetupDataBindings()
        {
            // for data source switching
            radInMemory.Checked = _currentDataSource == "InMemory";
            radTextFile.Checked = _currentDataSource == "TextFile";
            radJsonFile.Checked = _currentDataSource == "JsonFile";
        }

        private void RefreshTaskList()
        {
            lstTasks.Items.Clear();
            var tasks = _taskService.GetTasks();
            foreach (var task in tasks)
            {
                lstTasks.Items.Add(task);
            }
            lblTaskCount.Text = $"{tasks.Length} task(s)";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_taskService.AddTask(txtNewTask.Text))
            {
                RefreshTaskList();
                txtNewTask.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add task. List may be full or task is empty.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0)
            {
                if (_taskService.RemoveTask(lstTasks.SelectedIndex + 1))
                {
                    RefreshTaskList();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to remove.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedIndex >= 0 && !string.IsNullOrWhiteSpace(txtNewTask.Text))
            {
                if (_taskService.UpdateTask(lstTasks.SelectedIndex + 1, txtNewTask.Text))
                {
                    RefreshTaskList();
                    txtNewTask.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select a task and enter new text.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var foundIndices = _taskService.SearchTasks(txtSearch.Text);
            lstTasks.SelectedIndices.Clear();

            foreach (var index in foundIndices)
            {
                lstTasks.SelectedIndices.Add(index - 1);
            }

            if (foundIndices.Length == 0)
            {
                MessageBox.Show("No tasks found matching your search.",
                    "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radDataSource_CheckedChanged(object sender, EventArgs e)
        {
            if (radInMemory.Checked) _currentDataSource = "InMemory";
            if (radTextFile.Checked) _currentDataSource = "TextFile";
            if (radJsonFile.Checked) _currentDataSource = "JsonFile";

            InitializeDataService();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNewTask.Clear();
            txtSearch.Clear();
            lstTasks.SelectedIndex = -1;
        }
    }
}