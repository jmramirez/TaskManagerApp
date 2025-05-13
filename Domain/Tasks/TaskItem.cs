using Domain.Common;
using Domain.Tasks.ValueObjects;

namespace Domain.Tasks;

public sealed class TaskItem : BaseEntity<TaskId> 
{
    public TaskTitle Title { get;private set; }
    public TaskDescription Description { get; private set; }
    public DueDate DueDate { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public bool IsCompleted { get; private set; }

    private TaskItem(TaskId id, TaskTitle title, TaskDescription description, DueDate dueDate, DateTime createdAt) : base(id)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
        CreatedAt = createdAt;
    }

    public static Result<TaskItem> Create(TaskTitle title, TaskDescription description, DueDate dueDate,
        DateTime createdAt)
    {
        var id = TaskId.New();
        return Result<TaskItem>.Success(new TaskItem(id, title, description, dueDate, createdAt));
    }
    
    public void MarkCompleted() => IsCompleted = true;

    public void Update(TaskTitle title, TaskDescription description, DueDate dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
    }
}