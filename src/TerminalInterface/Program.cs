using CoreTodoList.DAL;
using CoreTodoList.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace TerminalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
			var contextOptions = new DbContextOptionsBuilder<TodoListContext>().UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=TodoList;Integrated Security=SSPI;").Options;
			var dbContext = new TodoListContext(contextOptions);

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