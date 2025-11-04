using Microsoft.AspNetCore.Mvc;
using TaskManager_Business_Logic;
using System.Collections.Generic;

namespace TaskManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly TaskManagerService _taskService;
        private readonly EmailService _emailService;

        public TasksController(TaskManagerService taskService, EmailService emailService)
        {
            _taskService = taskService;
            _emailService = emailService;
        }

        // GET: api/Tasks
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetTasks()
        {
            var tasks = _taskService.GetTasks();
            return Ok(tasks);
        }

        // GET: api/Tasks/search?keyword={keyword}
        [HttpGet("search")]
        public ActionResult<IEnumerable<int>> SearchTasks([FromQuery] string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest("Search keyword cannot be empty.");
            }

            var results = _taskService.SearchTasks(keyword);
            if (results.Length == 0)
            {
                return NotFound("No matching tasks found.");
            }

            return Ok(results);
        }

        // POST: api/Tasks
        // Body: { "task": "Task text", "email": "user@example.com" }
        [HttpPost]
        public IActionResult AddTask([FromBody] AddTaskRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Task))
            {
                return BadRequest("Task cannot be empty.");
            }

            if (_taskService.AddTask(request.Task))
            {
                if (!string.IsNullOrWhiteSpace(request.Email))
                {
                    _emailService.SendTaskAddedEmail(request.Email, request.Task);
                }

                return Ok(new
                {
                    message = "Task added successfully.",
                    emailSent = !string.IsNullOrWhiteSpace(request.Email)
                });
            }

            return StatusCode(500, "Failed to add task.");
        }

        // DELETE: api/Tasks/{taskNumber}?email={email}
        [HttpDelete("{taskNumber}")]
        public IActionResult RemoveTask(int taskNumber, [FromQuery] string email = null)
        {
            if (taskNumber <= 0)
            {
                return BadRequest("Task number must be a positive integer.");
            }

            var tasks = _taskService.GetTasks();
            if (taskNumber > tasks.Length)
            {
                return NotFound("Task not found or invalid task number.");
            }

            string taskText = tasks[taskNumber - 1];

            if (_taskService.RemoveTask(taskNumber))
            {
                if (!string.IsNullOrWhiteSpace(email))
                {
                    _emailService.SendTaskDeletedEmail(email, taskText);
                }

                return Ok(new
                {
                    message = "Task deleted successfully.",
                    emailSent = !string.IsNullOrWhiteSpace(email)
                });
            }

            return NotFound("Task not found or invalid task number.");
        }

        // PUT: api/Tasks/{taskNumber}
        // Body: { "newTaskText": "Updated task", "email": "user@example.com" }
        [HttpPut("{taskNumber}")]
        public IActionResult UpdateTask(int taskNumber, [FromBody] UpdateTaskRequest request)
        {
            if (taskNumber <= 0)
            {
                return BadRequest("Task number must be a positive integer.");
            }

            if (string.IsNullOrWhiteSpace(request.NewTaskText))
            {
                return BadRequest("New task text cannot be empty.");
            }

            var tasks = _taskService.GetTasks();
            if (taskNumber > tasks.Length)
            {
                return NotFound("Task not found or invalid task number.");
            }

            string oldTaskText = tasks[taskNumber - 1];

            if (_taskService.UpdateTask(taskNumber, request.NewTaskText))
            {
                if (!string.IsNullOrWhiteSpace(request.Email))
                {
                    _emailService.SendTaskUpdatedEmail(request.Email, oldTaskText, request.NewTaskText);
                }

                return Ok(new
                {
                    message = "Task updated successfully.",
                    emailSent = !string.IsNullOrWhiteSpace(request.Email)
                });
            }

            return NotFound("Task not found or invalid task number.");
        }
    }

    public class AddTaskRequest
    {
        public string Task { get; set; } = string.Empty;
        public string? Email { get; set; }
    }

    public class UpdateTaskRequest
    {
        public string NewTaskText { get; set; } = string.Empty;
        public string? Email { get; set; }
    }
}