using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Implementar una función Moda, que reciba como valores una cantidad indeterminada de enteros y devuelva la moda (estadística), el valor mínimo y el valor máximo.
    Invocar este método y mostrar los resultados por consola.
    Elija los modificadores mas adecuados
 */
namespace ParametrosModa
{
    internal class Program
    {




        static void Main(string[] args)
        {
            string s;
            int num = 0;
            List<int> list = new List<int>();
            Console.WriteLine("Insertar números enteros, pulsar \"s\" para salir");
            do
            {
                Console.WriteLine("Numero: ");
                s = Console.ReadLine();
                if (s != "s")
                {
                    int.TryParse(s, out num);
                    list.Add(num);
                }
                    
            
            }while(s!= "s");

            //foreach(int i in list)Console.WriteLine(i);

            Program program = new Program();
            program.Moda(list);

        }




        public void Moda( List<int>enteros)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            enteros.Sort();
            int repe1 = 0, repe2=0, indice=0;

            foreach (int i in enteros)
            {
                //Console.WriteLine(i);
                if (i < min) min = i;
                if(i > max) max = i;

            }
            int [] e = enteros.ToArray();

            for (int i = 0; i < e.Length; i++)
            {
                for (int j = i;j<e.Length;j++)
                {
                    if (e[i] == e[j])
                    {
                        repe1++;
                        
                    }
                    
                }
                if (repe1 > repe2)
                {
                    repe2 = repe1;
                    indice = i;
                }
                else if (repe2 ==0)
                {
                    indice = -1;
                }
                repe1 = 0;
            }
            Console.WriteLine("Valor mínimo: "+ min);
            Console.WriteLine("Valor máximo: "+ max);
            if (indice > 0)
            {
                Console.WriteLine("Moda:         "+ e[indice]);
            }
            else
            {
                Console.WriteLine("No existe Moda");
            }
        }
    }
}
