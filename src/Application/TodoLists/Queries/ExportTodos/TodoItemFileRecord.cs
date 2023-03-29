using CLEAN_ARCHITECTURE.Application.Common.Mappings;
using CLEAN_ARCHITECTURE.Domain.Entities;

namespace CLEAN_ARCHITECTURE.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
