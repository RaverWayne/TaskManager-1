using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_Data_Logic;

namespace TaskManager_Business_Logic
{
    public class TaskManagerService
    {
        private ITaskDataService taskDataService;
        private readonly EmailService emailService;
        private string userEmail;

        public TaskManagerService(ITaskDataService dataService)
        {
            this.taskDataService = dataService;
            this.emailService = new EmailService();
        }

        public void SetUserEmail(string email)
        {
            userEmail = email;
        }

        public string[] GetTasks() => taskDataService.GetTasks();

        public bool AddTask(string task)
        {
            if (string.IsNullOrWhiteSpace(task))
                return false;

            bool success = taskDataService.AddTask(task);


            if (success && !string.IsNullOrWhiteSpace(userEmail))
            {
                emailService.SendTaskAddedEmail(userEmail, task);
            }

            return success;
        }

        public bool RemoveTask(int taskNumber)
        {
            int index = taskNumber - 1;
            string[] tasks = GetTasks();

            if (index < 0 || index >= tasks.Length)
                return false;


            string taskToDelete = tasks[index];

            bool success = taskDataService.RemoveTask(index);


            if (success && !string.IsNullOrWhiteSpace(userEmail))
            {
                emailService.SendTaskDeletedEmail(userEmail, taskToDelete);
            }

            return success;
        }

        public int[] SearchTasks(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return Array.Empty<int>();

            string[] tasks = GetTasks();
            List<int> foundIndices = new List<int>();

            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i].Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    foundIndices.Add(i + 1);
                }
            }

            return foundIndices.ToArray();
        }

        public bool UpdateTask(int taskNumber, string newTaskText)
        {
            if (string.IsNullOrWhiteSpace(newTaskText))
                return false;

            int index = taskNumber - 1;
            string[] tasks = GetTasks();

            if (index < 0 || index >= tasks.Length)
                return false;


            string oldTaskText = tasks[index];

            bool success = taskDataService.UpdateTask(index, newTaskText);


            if (success && !string.IsNullOrWhiteSpace(userEmail))
            {
                emailService.SendTaskUpdatedEmail(userEmail, oldTaskText, newTaskText);
            }

            return success;
        }
    }
}