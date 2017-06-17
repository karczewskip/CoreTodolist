using CoreTodoList.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace TerminalInterface
{
	public class TodoListContextFactory : IDbContextFactory<TodoListContext>
	{
		public TodoListContext Create(DbContextFactoryOptions options)
		{
			var configuration = new ConfigurationBuilder()
			 .SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json").Build();

			var connectionString = configuration.GetConnectionString("DefaultConnection");

			var contextOptions = new DbContextOptionsBuilder<TodoListContext>().UseSqlServer(connectionString).Options;
			return new TodoListContext(contextOptions);
		}
	}
}
