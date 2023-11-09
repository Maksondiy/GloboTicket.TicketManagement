using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Exeptions
{
    public class NotFoudException : Exception
    {
        public NotFoudException(string name, object key)
            : base($"{name}({key}) is not found")
        { 
        }
    }
}
