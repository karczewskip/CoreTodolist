using System;
using System.Collections.Generic;
using System.Text;
using CoreTodoList.DAL;
using CoreTodoList.DAL.Entities;

namespace CoreTodoList.BL
{
	public class PriorityTodoTaskInserter : TodoTaskInserter
	{
		public PriorityTodoTaskInserter(TodoListContext dbContext) : base(dbContext)
		{
		}

		protected override void CustomizeTask(TodoTask addingTask)
		{
			addingTask.IsPriority = true;
		}
	}
}
