using CoreTodoList.BL;
using CoreTodoList.DAL.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace TerminalInterface
{
	class Program
    {
        static void Main(string[] args)
		{
			var todoListPresenter = new TodoListPresenter(new InboxTodoTasksProvider(GetDbContext()), new InboxTodoTasksInserter(GetDbContext()), new PriorityTodoTasksProvider(GetDbContext()), new PriorityTodoTaskInserter(GetDbContext()));

			todoListPresenter.Present();
		}

		private static CoreTodoList.DAL.TodoListContext GetDbContext()
		{
			var todoListContextFactory = new TodoListContextFactory();

			var dbContext = todoListContextFactory.Create(new DbContextFactoryOptions());
			return dbContext;
		}
	}
}