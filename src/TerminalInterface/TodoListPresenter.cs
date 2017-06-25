using CoreTodoList.BL;
using System;

namespace TerminalInterface
{
    public class TodoListPresenter : IPresenter
    {
		private InboxTodoTasksProvider _inboxTodoTasksProvider;
		private InboxTodoTasksInserter _inboxTodoTasksInserter;
		private PriorityTodoTasksProvider _priorityTodoTasksProvider;
		private PriorityTodoTaskInserter _priorityTodoTasksInserter;


		public TodoListPresenter(InboxTodoTasksProvider inboxTodoTasksProvider, InboxTodoTasksInserter inboxTodoTasksInserter, PriorityTodoTasksProvider priorytyTasksProvider, PriorityTodoTaskInserter priorytyTasksInserter)
		{
			_inboxTodoTasksProvider = inboxTodoTasksProvider;
			_inboxTodoTasksInserter = inboxTodoTasksInserter;
			_priorityTodoTasksProvider = priorytyTasksProvider;
			_priorityTodoTasksInserter = priorytyTasksInserter;
		}

		public void Present()
		{
			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("What do you want to do:");

				var command = Console.ReadLine();

				if(command == "Show Inbox")
				{
					ShowTasks(_inboxTodoTasksProvider);
				}

				else if(command == "Show Priority")
				{
					ShowTasks(_priorityTodoTasksProvider);
				}

				else if (command == "Exit")
					break;

				else if(command.StartsWith("Add Priority"))
				{
					var newTaskName = command.Substring(12).Trim();
					_priorityTodoTasksInserter.InsertNewTask(newTaskName);
				}

				else if (command.StartsWith("Add "))
				{
					var newTaskName = command.Substring(4).Trim();
					_inboxTodoTasksInserter.InsertNewTask(newTaskName);
				}

			}
		}

		private static void ShowTasks(ITodoTasksProvider todoTasksProvider)
		{
			Console.WriteLine();
			Console.WriteLine("In your inbox there are:");
			foreach (var task in todoTasksProvider.GetTasks())
			{
				Console.WriteLine(task.Title);
			}
			Console.WriteLine();
		}

	}
}
