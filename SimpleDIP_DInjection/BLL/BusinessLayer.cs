using SimpleDIP_DInjection.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDIP_DInjection.BLL
{
	public class BusinessLayer
	{
        private readonly IDataAccess _dataAccess ;

        public BusinessLayer(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public string RunSelectedApp (int Id)
		{
			

			return _dataAccess.GetBy(Id);
		}
	}
}
