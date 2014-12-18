using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            var valForm = new Formulario();
            var valServer = new Server();
            var valDB = new DataBase();

            valForm.setSucessor(valServer);
            valServer.setSucessor(valDB);

            //passando requisiçãopara cadeia de responsabilidade
            valForm.ValidateUser("teste", "teste");
        }
    }
}
