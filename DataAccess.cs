using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApplication1
{
	public class DataAccess : IDataAccess
	{
		// The constructor receives an HttpClient via dependency
		// injection. HttpClient is a default service.
		public DataAccess(HttpClient client)
		{

		}

		public IReadOnlyList<Customer> GetAllCustomersAsync() => throw new NotImplementedException();
	}

	public interface IDataAccess
	{
		IReadOnlyList<Customer> GetAllCustomersAsync();
	}
}
