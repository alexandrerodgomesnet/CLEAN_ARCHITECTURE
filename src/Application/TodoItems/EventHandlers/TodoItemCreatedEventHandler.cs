using CLEAN_ARCHITECTURE.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CLEAN_ARCHITECTURE.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CLEAN_ARCHITECTURE Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
