using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    //Concrete Handler
    public class Formulario : IValidate
    {
        public override bool ValidateUser(string name, string password)
        {
            bool ret = false;
            if (name != null)
                if (password != null)
                    ret = true;
            Console.WriteLine("Validação feita no Formulario: " + ret);
            
            if (_sucessor != null)
                _sucessor.ValidateUser(name, password);

            return ret;
        }

    }
}
