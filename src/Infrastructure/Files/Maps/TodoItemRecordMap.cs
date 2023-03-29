using System.Globalization;
using CLEAN_ARCHITECTURE.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace CLEAN_ARCHITECTURE.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
