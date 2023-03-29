using CLEAN_ARCHITECTURE.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CLEAN_ARCHITECTURE.Application.TodoItems.EventHandlers;

public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CLEAN_ARCHITECTURE Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
