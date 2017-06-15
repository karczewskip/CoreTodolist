using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CoreTodoList.DAL
{
	public class TodoListContextFactory : IDbContextFactory<TodoListContext>
	{
		public TodoListContext Create(DbContextFactoryOptions options)
		{
			var contextOptions = new DbContextOptionsBuilder<TodoListContext>().UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=TodoList;Integrated Security=SSPI;").Options;
			return new TodoListContext(contextOptions);
		}
	}
}
