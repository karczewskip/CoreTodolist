using System;
using System.Collections.Generic;
using System.Text;
using CoreTodoList.DAL.Entities;
using CoreTodoList.DAL;

namespace CoreTodoList.BL
{
	public class InboxTodoTasksProvider : ITodoTasksProvider
	{
		private TodoListContext _dbContext;
		public InboxTodoTasksProvider(TodoListContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IEnumerable<TodoTask> GetTasks()
		{
			return _dbContext.TodoTasks;
		}
	}
}
