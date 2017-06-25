using CoreTodoList.DAL;
using CoreTodoList.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTodoList.BL
{
	public class InboxTodoTasksInserter : TodoTaskInserter
	{
		public InboxTodoTasksInserter(TodoListContext dbContext) : base(dbContext)
		{
		}

		protected override void CustomizeTask(TodoTask addingTask)
		{
		}
	}
}
