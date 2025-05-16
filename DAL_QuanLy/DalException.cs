using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DalException : Exception
    {
        public int ErrorCode { get; }

        public DalException(string message, Exception inner, int errorCode = 0) 
            : base(message, inner) => ErrorCode = errorCode;
    }
}
