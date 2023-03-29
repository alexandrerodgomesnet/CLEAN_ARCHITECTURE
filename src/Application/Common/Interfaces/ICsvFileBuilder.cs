using CLEAN_ARCHITECTURE.Application.TodoLists.Queries.ExportTodos;

namespace CLEAN_ARCHITECTURE.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
