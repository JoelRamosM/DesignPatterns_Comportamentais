﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    //Concrete Handler
    public class DataBase : IValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            bool ret = name == password;
            Console.WriteLine("Validação feita no DataBase: " + ret);
            //Encadeia a chamada
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);

            return ret;
        }
    }
}
