using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDIP_DInjection.DAL
{
	public class DataAccess :IDataAccess
	{

	

		Dictionary<int, string> _data = new Dictionary<int, string>()
		{
			{1,"Doctor Software" },
			{2,"Customer Software" },
			{3,"Admin Software" },
		};
		
		public string GetBy(int id)
		{
			return _data[id]; 
		}
	}
}
