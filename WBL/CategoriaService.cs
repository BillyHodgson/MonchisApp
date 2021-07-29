using BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public class CategoriaService
    {
        private readonly IDataAccess sql;


        public CategoriaService(IDataAccess _sql)
        {
            sql = _sql;
        }
    }
}
