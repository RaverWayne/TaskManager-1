using System;
using System.Configuration;
using TaskManager_Business_Logic;
using TaskManager_Data_Logic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace TaskManager
{
    internal class Program
    {
        static void Main()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TaskManagerDB"]?.ConnectionString;

            ITaskDataService dataService = new SqlServerDataService(connectionString);
            var taskService = new TaskManagerService(dataService);

            string userEmail = GetUserEmail();
            taskService.SetUserEmail(userEmail);

            TaskManagerUI ui = new TaskManagerUI(taskService);
            ui.Run();
        }

        static string GetUserEmail()
        {
            Console.WriteLine("TASK MANAGER - Email Notification Setup");
            Console.WriteLine("=========================================");

            while (true)
            {
                Console.Write("Enter your email address for notifications (or press Enter to skip): ");
                string email = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.WriteLine("Email notifications disabled for this session.\n");
                    return null;
                }

                if (IsValidEmail(email))
                {
                    Console.WriteLine($"Email notifications enabled for: {email}\n");
                    return email;
                }
                else
                {
                    Console.WriteLine("Invalid email format. Please try again.\n");
                }
            }
        }

        static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Simple email validation using regex
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }
    }

    class TaskManagerUI
    {
        private readonly TaskManagerService taskService;

        public TaskManagerUI(TaskManagerService service)
        {
            taskService = service;
        }

        public void Run()
        {
            Console.WriteLine("TASK MANAGER");
            bool isRunning = true;
            while (isRunning)
            {
                DisplayMenuOptions();
                if (!int.TryParse(Console.ReadLine(), out int selectedOption))
                {
                    Console.WriteLine("Not a valid operation!\nChoose only in the options.");
                    continue;
                }

                switch (selectedOption)
                {
                    case 1:
                        DisplayTasks();
                        break;
                    case 2:
                        Console.Write("Enter task: ");
                        string task = Console.ReadLine();
                        if (taskService.AddTask(task))
                            Console.WriteLine("Task added. Email notification sent!");
                        else
                            Console.WriteLine("Task list full or empty task.");
                        break;
                    case 3:
                        Console.Write("Enter task number to delete: ");
                        if (!int.TryParse(Console.ReadLine(), out int taskNumber))
                        {
                            Console.WriteLine("Invalid task number.\nChoose a number in the list only!");
                            break;
                        }

                        if (!taskService.RemoveTask(taskNumber))
                        {
                            Console.WriteLine("Invalid task number.\nChoose a number in the list only!");
                        }
                        else
                        {
                            Console.WriteLine("Task deleted. Email notification sent!");
                        }
                        break;
                    case 4:
                        SearchTasks();
                        break;
                    case 5:
                        UpdateTask();
                        break;
                    case 6:
                        Console.WriteLine("Hope you did your tasks!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid operation!\nChoose only in the options.");
                        break;
                }
            }
        }

        private void DisplayTasks()
        {
            var tasks = taskService.GetTasks();
            Console.WriteLine("\nTASKS:");
            if (tasks.Length == 0)
            {
                Console.WriteLine("No tasks.");
                return;
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        private void SearchTasks()
        {
            Console.Write("Enter search keyword: ");
            string keyword = Console.ReadLine();

            int[] results = taskService.SearchTasks(keyword);

            if (results.Length == 0)
            {
                Console.WriteLine("No matching tasks found.");
                return;
            }

            Console.WriteLine($"\nFound {results.Length} matching tasks:");
            var tasks = taskService.GetTasks();

            foreach (int index in results)
            {
                Console.WriteLine($"{index}. {tasks[index - 1]}");
            }
        }

        private void UpdateTask()
        {
            DisplayTasks();
            Console.Write("Enter task number to update: ");

            if (!int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                Console.WriteLine("Invalid task number.\nChoose a number in the list only!");
                return;
            }

            Console.Write("Enter new task text: ");
            string newTaskText = Console.ReadLine();

            if (taskService.UpdateTask(taskNumber, newTaskText))
            {
                Console.WriteLine("Task updated successfully. Email notification sent!");
            }
            else
            {
                Console.WriteLine("Failed to update task. Invalid task number or empty text.");
            }
        }

        private void DisplayMenuOptions()
        {
            Console.WriteLine("\nOPTIONS:");
            Console.WriteLine("1 - View Tasks");
            Console.WriteLine("2 - Add Task");
            Console.WriteLine("3 - Delete Task");
            Console.WriteLine("4 - Search Tasks");
            Console.WriteLine("5 - Update Task");
            Console.WriteLine("6 - Exit");
            Console.Write("Enter option: ");
        }
    }
}