using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        //Client
        static void Main(string[] args)
        {
            //Configurar Receiver
            Server server = new Server();
            //Cria commando configurando o receiver
            Command cmd = new ServerCommand(server);

            //Configura Invoker
            Formulario form = new Formulario();

            //Configurar e executae comando....
            form.setCommand(cmd);
            form.ClickValidate();

            Console.ReadLine();
        }
    }
}
