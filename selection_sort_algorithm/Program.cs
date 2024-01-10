using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az elem számot");
            int n;
            n = int.Parse(Console.ReadLine());
            int[] t = new int[n];
            int i;
            Console.WriteLine("Rendezás elött");
            for (i = 0; i < n; i++) 
            {
                Console.WriteLine("Kérem a " + i + ". elemet");
                t[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write(t[i].ToString() + ", ");
            }
            Console.WriteLine("Kiírt rendezés száma");
            int j;
            for (i = 0; i < n; i++)
            {
                int MIN;
                MIN = i;
                for (j = 0; j < n - 1; j++)
                {
                    if (t[MIN] > t[j])
                    {
                        MIN = j;
                    }
                    int tmp;
                    tmp = t[MIN];
                    t[MIN] = t[i];
                    t[i] = tmp;
                }
            }
            Console.WriteLine("Rendezés után a számok: ");
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write(t[i].ToString() + ", ");
            }
            Console.ReadLine();
        }
    }
}
