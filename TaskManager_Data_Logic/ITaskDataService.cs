using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_Data_Logic
{
    public interface ITaskDataService
    {
        string[] GetTasks();
        bool AddTask(string task);
        bool RemoveTask(int index);
        bool UpdateTask(int index, string newTaskText);
    }
}
