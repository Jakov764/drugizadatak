using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite broj sekundi: ");
            int brojSekundi;
            brojSekundi = Convert.ToInt32(Console.ReadLine());
            int brojMinuta = brojSekundi / 60;
            int brojSekundi2 =brojSekundi % 60;
            if (brojSekundi % 60 != 0)
            {
                Console.WriteLine("{0} sekundi je {1} minuta/e i {2} sekunda/e.", brojSekundi, brojMinuta, brojSekundi2);
            }
            else
            {
                Console.WriteLine("{0} sekundi je {1} minuta/e.", brojSekundi, brojMinuta);
            }
               Console.ReadKey();
        }
    }
}
