using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApplication1
{
    public class Customer
    {
		private readonly string name;

		public Customer(string name)
		{
			this.name = name;
		}
	}
}
