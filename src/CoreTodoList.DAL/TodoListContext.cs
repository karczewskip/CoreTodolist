using CoreTodoList.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTodoList.DAL
{
    public class TodoListContext : DbContext
    {
		public TodoListContext(DbContextOptions<TodoListContext> options) : base(options)
		{

		}

		public DbSet<TodoTask> TodoTasks { get; set; }
    }
}
