# TaskManager Application Summary

**Core Functionality:**
- View all current tasks in a numbered list
- Add new tasks to the task list (with validation for empty tasks)
- Delete existing tasks by number (with validation)
- Search for tasks by keyword
- Update existing tasks with new text
- Exit the application

**Architecture Components:**
- **TaskManagerUI**: Handles user interaction and display logic
- **TaskManagerService**: Contains business logic and validation rules
- **TaskRepository**: Manages task data storage and manipulation

**Key Features:**
- Simple command-line interface with numbered menu options
- Input validation to prevent errors
- Fixed-size task list (maximum of 5 tasks but can be changed)
- Clear separation of concerns between UI, business logic, and data layers
- Search functionality to find tasks containing specific keywords
- Task update capability to modify existing entries

**User Experience:**
- Clear menu system for navigating options
- Helpful feedback messages after operations
- Error handling for invalid inputs
