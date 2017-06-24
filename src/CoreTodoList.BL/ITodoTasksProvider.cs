using CoreTodoList.DAL.Entities;
using System.Collections.Generic;

namespace CoreTodoList.BL
{
	public interface ITodoTasksProvider
	{
		IEnumerable<TodoTask> GetTasks();
	}
}