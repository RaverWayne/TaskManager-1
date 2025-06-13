using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace TaskManager_Data_Logic
{
    public class SqlServerDataService : ITaskDataService, IDisposable
    {
        private readonly SqlConnection _connection;
        private bool _disposed = false;

        public SqlServerDataService(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public string[] GetTasks()
        {
            var tasks = new List<string>();
            const string sql = "SELECT Title FROM Tasks ORDER BY CreatedDate DESC";

            using (var cmd = new SqlCommand(sql, _connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tasks.Add(reader.GetString(0));
                }
            }
            return tasks.ToArray();
        }

        public bool AddTask(string task)
        {
            if (string.IsNullOrWhiteSpace(task))
                return false;

            const string sql = @"INSERT INTO Tasks (Title) VALUES (@Title);
                               SELECT SCOPE_IDENTITY();";

            using (var cmd = new SqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@Title", task);
                return cmd.ExecuteScalar() != null;
            }
        }

        public bool RemoveTask(int index)
        {
            var taskId = GetTaskIdByIndex(index);
            if (taskId == -1) return false;

            const string sql = "DELETE FROM Tasks WHERE Id = @Id";

            using (var cmd = new SqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", taskId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateTask(int index, string newTaskText)
        {
            if (string.IsNullOrWhiteSpace(newTaskText))
                return false;

            var taskId = GetTaskIdByIndex(index);
            if (taskId == -1) return false;

            const string sql = @"UPDATE Tasks 
                               SET Title = @Title, 
                                   ModifiedDate = GETDATE()
                               WHERE Id = @Id";

            using (var cmd = new SqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", taskId);
                cmd.Parameters.AddWithValue("@Title", newTaskText);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private int GetTaskIdByIndex(int index)
        {
            const string sql = "SELECT Id FROM Tasks ORDER BY CreatedDate DESC OFFSET @Index ROWS FETCH NEXT 1 ROWS ONLY";

            using (var cmd = new SqlCommand(sql, _connection))
            {
                cmd.Parameters.AddWithValue("@Index", index);
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _connection?.Close();
                    _connection?.Dispose();
                }
                _disposed = true;
            }
        }
    }
}