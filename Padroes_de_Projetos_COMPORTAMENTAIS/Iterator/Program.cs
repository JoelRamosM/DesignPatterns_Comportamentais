using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var equipe = new Equipe();
            equipe[0] = "Joel";
            equipe[1] = "Paulo";
            equipe[2] = "Jose";
            equipe[3] = "Luiz";
            
            //Criar Iterator
            ConcreeteIterator i = new ConcreeteIterator(equipe);

            //Iterar pela Coleção
            Console.WriteLine("Listando membros da Equipe:");
            Object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            Console.Read();




        }
    }
}
