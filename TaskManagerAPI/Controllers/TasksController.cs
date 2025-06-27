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

        public TasksController(TaskManagerService taskService)
        {
            _taskService = taskService;
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
        [HttpPost]
        public IActionResult AddTask([FromBody] string task)
        {
            if (string.IsNullOrWhiteSpace(task))
            {
                return BadRequest("Task cannot be empty."); 
            }

            if (_taskService.AddTask(task))
            {
                return Ok("Task added successfully.");
            }
            return StatusCode(500, "Failed to add task."); 
        }

        // DELETE: api/Tasks/{taskNumber}
        [HttpDelete("{taskNumber}")]
        public IActionResult RemoveTask(int taskNumber)
        {
            if (taskNumber <= 0)
            {
                return BadRequest("Task number must be a positive integer."); 
            }

            if (_taskService.RemoveTask(taskNumber))
            {
                return Ok("Task deleted successfully."); 
            }
            return NotFound("Task not found or invalid task number."); 
        }

        // PUT: api/Tasks/{taskNumber}
        // For a simple string update
        [HttpPut("{taskNumber}")]
        public IActionResult UpdateTask(int taskNumber, [FromBody] string newTaskText)
        {
            if (taskNumber <= 0)
            {
                return BadRequest("Task number must be a positive integer.");
            }
            if (string.IsNullOrWhiteSpace(newTaskText))
            {
                return BadRequest("New task text cannot be empty."); 
            }

            if (_taskService.UpdateTask(taskNumber, newTaskText))
            {
                return Ok("Task updated successfully."); 
            }
            return NotFound("Task not found or invalid task number."); 
        }
    }
}