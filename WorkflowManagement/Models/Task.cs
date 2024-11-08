namespace WorkflowManagement.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } // e.g., Pending, In Progress, Complete
        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set; }
    }
}
