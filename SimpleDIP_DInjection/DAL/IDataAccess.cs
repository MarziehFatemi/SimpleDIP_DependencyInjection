using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDIP_DInjection.DAL
{
	public interface IDataAccess
	{
		
		public string GetBy(int id); 
	}
}
