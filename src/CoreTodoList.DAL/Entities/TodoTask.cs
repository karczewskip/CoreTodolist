using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreTodoList.DAL.Entities
{
    public class TodoTask
    {
		public int TodoTaskId { get; set; }

		[Required]
		public string Title { get; set; }
	}
}
