using CoreTodoList.DAL;
using CoreTodoList.DAL.Entities;
using System;
using System.Linq;
using System.Text;

namespace CoreTodoList.BL
{
	public class PriorityTodoTasksProvider : TodoTasksProvider
	{
		public PriorityTodoTasksProvider(TodoListContext dbContext) : base(dbContext)
		{
		}

		protected override IQueryable<TodoTask> RetriveUsingCustomCondition(IQueryable<TodoTask> allTasks)
		{
			return allTasks.Where(x => x.IsPriority);
		}
	}
}
