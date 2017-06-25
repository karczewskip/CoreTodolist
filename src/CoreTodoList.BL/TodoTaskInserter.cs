using CoreTodoList.DAL;
using CoreTodoList.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTodoList.BL
{
	public abstract class TodoTaskInserter : ITodoTasksInserter
	{
		private readonly TodoListContext _dbContext;

		public TodoTaskInserter(TodoListContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void InsertNewTask(string taskName)
		{
			var newTodoTask = new TodoTask()
			{
				Title = taskName,
				Created = DateTime.UtcNow
			};

			CustomizeTask(newTodoTask);
			
			_dbContext.Add(newTodoTask);
			_dbContext.SaveChanges();
		}

		protected abstract void CustomizeTask(TodoTask addingTask);
	}
}
