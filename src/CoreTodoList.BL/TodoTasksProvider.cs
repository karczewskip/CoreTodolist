using CoreTodoList.DAL;
using CoreTodoList.DAL.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CoreTodoList.BL
{
	public abstract class TodoTasksProvider : ITodoTasksProvider
	{
		private TodoListContext _dbContext;
		public TodoTasksProvider(TodoListContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<TodoTask> GetTasks()
		{
			var allTasks = _dbContext.TodoTasks;
			IQueryable<TodoTask> result = RetriveUsingCustomCondition(allTasks);

			return result;
		}

		protected abstract IQueryable<TodoTask> RetriveUsingCustomCondition(IQueryable<TodoTask> allTasks);
	}
}
