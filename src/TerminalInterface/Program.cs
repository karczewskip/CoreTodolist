using CoreTodoList.DAL;
using CoreTodoList.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;

namespace TerminalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
			var todoListContextFactory = new TodoListContextFactory();

			var dbContext = todoListContextFactory.Create(new DbContextFactoryOptions());

			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("All your todo tasks:");
				foreach(var task in dbContext.TodoTasks)
				{
					Console.WriteLine(task.Title);
				}
				Console.WriteLine();

				Console.WriteLine("What you want to do(add - add new task, exit - close program):");
				var command = Console.ReadLine();

				if (command == "exit")
					break;

				if (command == "add")
				{
					Console.WriteLine("Write task:");
					var newTodoTask = new TodoTask()
					{
						Title = Console.ReadLine()
					};

					dbContext.TodoTasks.Add(newTodoTask);
					dbContext.SaveChanges();
				}

			}
        }
    }
}