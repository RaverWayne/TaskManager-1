using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskManager_Data_Logic
{
    public class TextFileDataService : ITaskDataService
    {
        private const string FilePath = "tasks.txt";

        public string[] GetTasks()
        {
            if (!File.Exists(FilePath))
                return Array.Empty<string>();

            return File.ReadAllLines(FilePath);
        }

        public bool AddTask(string task)
        {
            File.AppendAllText(FilePath, task + Environment.NewLine);
            return true;
        }

        public bool RemoveTask(int index)
        {
            var tasks = GetTasks().ToList();
            if (index < 0 || index >= tasks.Count)
                return false;

            tasks.RemoveAt(index);
            File.WriteAllLines(FilePath, tasks);
            return true;
        }

        public bool UpdateTask(int index, string newTaskText)
        {
            var tasks = GetTasks().ToList();
            if (index < 0 || index >= tasks.Count)
                return false;

            tasks[index] = newTaskText;
            File.WriteAllLines(FilePath, tasks);
            return true;
        }
    }
}