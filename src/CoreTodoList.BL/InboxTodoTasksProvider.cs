using CoreTodoList.DAL.Entities;
using CoreTodoList.DAL;
using System.Linq;

namespace CoreTodoList.BL
{
	public class InboxTodoTasksProvider : TodoTasksProvider
	{
		public InboxTodoTasksProvider(TodoListContext dbContext) : base(dbContext)
		{
		}

		protected override IQueryable<TodoTask> RetriveUsingCustomCondition(IQueryable<TodoTask> allTasks)
		{
			return allTasks.Where(x => !x.IsPriority);
		}
	}
}
