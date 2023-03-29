using CLEAN_ARCHITECTURE.Application.Common.Exceptions;
using CLEAN_ARCHITECTURE.Application.TodoLists.Commands.CreateTodoList;
using CLEAN_ARCHITECTURE.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace CLEAN_ARCHITECTURE.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class CreateTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireMinimumFields()
    {
        var command = new CreateTodoListCommand();
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<ValidationException>();
    }

    [Test]
    public async Task ShouldRequireUniqueTitle()
    {
        await SendAsync(new CreateTodoListCommand
        {
            Title = "Shopping"
        });

        var command = new CreateTodoListCommand
        {
            Title = "Shopping"
        };

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<ValidationException>();
    }

    [Test]
    public async Task ShouldCreateTodoList()
    {
        var userId = await RunAsDefaultUserAsync();

        var command = new CreateTodoListCommand
        {
            Title = "Tasks"
        };

        var id = await SendAsync(command);

        var list = await FindAsync<TodoList>(id);

        list.Should().NotBeNull();
        list!.Title.Should().Be(command.Title);
        list.CreatedBy.Should().Be(userId);
        list.Created.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
