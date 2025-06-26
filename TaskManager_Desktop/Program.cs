using System;
using System.Windows.Forms;

namespace TaskManager_Desktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            var dataService = new TaskManager_Data_Logic.InMemoryDataService();
            var taskService = new TaskManager_Business_Logic.TaskManagerService(dataService);

            Application.Run(new frmMain());
        }
    }
}