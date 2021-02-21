using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetIT.Services.Exception
{
    public class DbUpdateConcurrencyException : ApplicationException
    {
        public DbUpdateConcurrencyException(string message) : base(message)
        {

        }
    }
}
