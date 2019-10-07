using System.Collections.Generic;
using BlazorWebApplication1;
using Microsoft.AspNetCore.Components;

namespace BlazorSample
{
	public class TodoBase : ComponentBase
	{
		protected IList<TodoItem> todos = new List<TodoItem>();
		protected string newTodo;
		protected string errors;

		public void AddTodo()
		{
			// if we have something in the input field, add it to list and 
			// reset input field
			if (!string.IsNullOrWhiteSpace(newTodo))
			{
				todos.Add(new TodoItem { Title = newTodo });
				newTodo = string.Empty;
				errors = "";
			}
			else
			{
				errors = "Field cannot be null, empty or whitespace";
			}
		}
	}
}
