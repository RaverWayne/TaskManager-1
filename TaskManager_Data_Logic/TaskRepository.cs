using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Data_Logic
{
    public class TaskRepository
    {
        private string[] taskList = new string[5];
        private int taskCount = 0;

        public string[] GetTasks()
        {
            string[] tasks = new string[taskCount];
            Array.Copy(taskList, tasks, taskCount);
            return tasks;
        }

        public bool AddTask(string task)
        {
            if (taskCount >= taskList.Length)
                return false;

            taskList[taskCount] = task;
            taskCount++;
            return true;
        }

        public bool RemoveTask(int index)
        {
            for (int i = index; i < taskCount - 1; i++)
            {
                taskList[i] = taskList[i + 1];
            }
            taskCount--;
            return true;
        }

        public bool UpdateTask(int index, string newTaskText)
        {

            taskList[index] = newTaskText;
            return true;
        }
    }
}