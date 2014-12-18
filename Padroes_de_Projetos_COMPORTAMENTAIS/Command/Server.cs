using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //Receiver
    public class Server 
    {
        public bool ValidateUser()
        {
            Console.WriteLine("Server - Receiver: Validando Usuario ");
            return true;
        }

    }
}
