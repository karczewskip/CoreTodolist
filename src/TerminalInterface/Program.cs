using System;
using System.Collections.Generic;

namespace TerminalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
			var todoList = new List<string>();

			while (true)
			{
				Console.WriteLine();
				Console.WriteLine("All your todo tasks:");
				foreach(var task in todoList)
				{
					Console.WriteLine(task);
				}
				Console.WriteLine();

				Console.WriteLine("What you want to do(add - add new task, exit - close program):");
				var command = Console.ReadLine();

				if (command == "exit")
					break;

				if (command == "add")
				{
					Console.WriteLine("Write task:");
					todoList.Add(Console.ReadLine());
				}

			}
        }
    }
}