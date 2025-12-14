namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        public TodoItemDTO() { }

        // This constructor assumes a 'Todo' class exists and performs mapping
        public TodoItemDTO(Todo todoItem) =>
            (Id, Name, IsComplete) = (todoItem.Id, todoItem.Name, todoItem.IsComplete);
    }
}