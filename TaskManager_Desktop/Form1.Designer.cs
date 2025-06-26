namespace TaskManager_Desktop
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstTasks = new ListBox();
            txtNewTask = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            radJsonFile = new RadioButton();
            radTextFile = new RadioButton();
            radInMemory = new RadioButton();
            lblTaskCount = new Label();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();


            lstTasks.Font = new Font("Segoe UI", 10F);
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 23;
            lstTasks.Location = new Point(12, 12);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(400, 257);
            lstTasks.TabIndex = 0;


            txtNewTask.Font = new Font("Segoe UI", 10F);
            txtNewTask.Location = new Point(12, 298);
            txtNewTask.Name = "txtNewTask";
            txtNewTask.PlaceholderText = "Enter new task...";
            txtNewTask.Size = new Size(400, 30);
            txtNewTask.TabIndex = 1;
            txtNewTask.Text = "it";
   

            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(12, 334);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 35);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
 

            btnRemove.BackColor = Color.IndianRed;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(112, 334);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 35);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
 

            btnUpdate.BackColor = Color.SeaGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(212, 334);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 35);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;


            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(12, 394);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search tasks...";
            txtSearch.Size = new Size(294, 30);
            txtSearch.TabIndex = 5;

 
            btnSearch.BackColor = Color.MediumPurple;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(312, 394);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;


            groupBox1.Controls.Add(radJsonFile);
            groupBox1.Controls.Add(radTextFile);
            groupBox1.Controls.Add(radInMemory);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(418, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 120);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Source";

            radJsonFile.AutoSize = true;
            radJsonFile.Font = new Font("Segoe UI", 9F);
            radJsonFile.Location = new Point(6, 80);
            radJsonFile.Name = "radJsonFile";
            radJsonFile.Size = new Size(92, 24);
            radJsonFile.TabIndex = 2;
            radJsonFile.Text = "JSON File";
            radJsonFile.UseVisualStyleBackColor = true;
            radJsonFile.CheckedChanged += radDataSource_CheckedChanged;


            radTextFile.AutoSize = true;
            radTextFile.Font = new Font("Segoe UI", 9F);
            radTextFile.Location = new Point(6, 50);
            radTextFile.Name = "radTextFile";
            radTextFile.Size = new Size(84, 24);
            radTextFile.TabIndex = 1;
            radTextFile.Text = "Text File";
            radTextFile.UseVisualStyleBackColor = true;
            radTextFile.CheckedChanged += radDataSource_CheckedChanged;


            radInMemory.AutoSize = true;
            radInMemory.Checked = true;
            radInMemory.Font = new Font("Segoe UI", 9F);
            radInMemory.Location = new Point(6, 20);
            radInMemory.Name = "radInMemory";
            radInMemory.Size = new Size(101, 24);
            radInMemory.TabIndex = 0;
            radInMemory.TabStop = true;
            radInMemory.Text = "In Memory";
            radInMemory.UseVisualStyleBackColor = true;
            radInMemory.CheckedChanged += radDataSource_CheckedChanged;


            lblTaskCount.AutoSize = true;
            lblTaskCount.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblTaskCount.Location = new Point(12, 272);
            lblTaskCount.Name = "lblTaskCount";
            lblTaskCount.Size = new Size(63, 20);
            lblTaskCount.TabIndex = 8;
            lblTaskCount.Text = "0 task(s)";


            btnClear.BackColor = Color.Gray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(312, 334);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.Location = new Point(418, 135);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 10;
            label1.Text = "Changes take effect immediately";


            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic);
            label2.Location = new Point(418, 155);
            label2.Name = "label2";
            label2.Size = new Size(164, 17);
            label2.TabIndex = 11;
            label2.Text = "(Data persists between runs)";


            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(632, 453);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(lblTaskCount);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtNewTask);
            Controls.Add(lstTasks);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.TextBox txtNewTask;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radJsonFile;
        private System.Windows.Forms.RadioButton radTextFile;
        private System.Windows.Forms.RadioButton radInMemory;
        private System.Windows.Forms.Label lblTaskCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}