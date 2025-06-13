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

        public TaskManagerService(ITaskDataService dataService)
        {
            this.taskDataService = dataService;
        }

        public string[] GetTasks() => taskDataService.GetTasks();

        public bool AddTask(string task)
        {
            if (string.IsNullOrWhiteSpace(task))
                return false;
            return taskDataService.AddTask(task);
        }

        public bool RemoveTask(int taskNumber)
        {
            int index = taskNumber - 1;
            string[] tasks = GetTasks();
            if (index < 0 || index >= tasks.Length)
                return false;
            return taskDataService.RemoveTask(index);
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

            return taskDataService.UpdateTask(index, newTaskText);
        }
    }
}