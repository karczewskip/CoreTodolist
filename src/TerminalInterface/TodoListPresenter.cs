using CoreTodoList.BL;
using System;

namespace TerminalInterface
{
    public class TodoListPresenter : IPresenter
    {
		private InboxTodoTasksProvider _inboxTodoTasksProvider;
		private InboxTodoTasksInserter _inboxTodoTasksInserter;

		public TodoListPresenter(InboxTodoTasksProvider inboxTodoTasksProvider, InboxTodoTasksInserter inboxTodoTasksInserter)
		{
			_inboxTodoTasksProvider = inboxTodoTasksProvider;
			_inboxTodoTasksInserter = inboxTodoTasksInserter;
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
					Console.WriteLine();
					Console.WriteLine("In your inbox there are:");
					foreach (var task in _inboxTodoTasksProvider.GetTasks())
					{
						Console.WriteLine(task.Title);
					}
					Console.WriteLine();
				}

				if (command == "Exit")
					break;

				if (command.StartsWith("Add "))
				{
					var newTaskName = command.Substring(4).Trim();
					_inboxTodoTasksInserter.InsertNewTask(newTaskName);
				}

			}
		}


    }
}
