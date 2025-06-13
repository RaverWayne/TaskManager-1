using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace TaskManager_Data_Logic
{
    public class JsonFileDataService : ITaskDataService
    {
        private const string FilePath = "tasks.json";

        public string[] GetTasks()
        {
            if (!File.Exists(FilePath))
                return Array.Empty<string>();

            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<string[]>(json) ?? Array.Empty<string>();
        }

        public bool AddTask(string task)
        {
            var tasks = GetTasks().ToList();
            tasks.Add(task);
            SaveTasks(tasks.ToArray());
            return true;
        }

        public bool RemoveTask(int index)
        {
            var tasks = GetTasks().ToList();
            if (index < 0 || index >= tasks.Count)
                return false;

            tasks.RemoveAt(index);
            SaveTasks(tasks.ToArray());
            return true;
        }

        public bool UpdateTask(int index, string newTaskText)
        {
            var tasks = GetTasks().ToList();
            if (index < 0 || index >= tasks.Count)
                return false;

            tasks[index] = newTaskText;
            SaveTasks(tasks.ToArray());
            return true;
        }

        private void SaveTasks(string[] tasks)
        {
            var json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(FilePath, json);
        }
    }
}
