using CoreTodoList.DAL;
using CoreTodoList.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTodoList.BL
{
	public class InboxTodoTasksInserter : ITodoTasksInserter
	{
		private readonly TodoListContext _dbContext;

		public InboxTodoTasksInserter(TodoListContext dbContext)
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

			_dbContext.Add(newTodoTask);
			_dbContext.SaveChanges();
		}
	}
}
