using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> filaNum = new Queue<int>();
            filaNum.Enqueue(6);
            filaNum.Enqueue(12);
            filaNum.Enqueue(9);
            filaNum.Enqueue(5);
            mostraFila(filaNum);

            Console.WriteLine("Primeiro elemento: {0}", filaNum.Peek());
            Console.WriteLine("Primeiro elemento: {0}", filaNum.First());
            Console.WriteLine("Último elemento: {0}", filaNum.Last());
            Console.WriteLine("Segundo elemento: {0}", filaNum.ElementAt(1));
            Console.WriteLine("Desenfileirado: {0}", filaNum.Dequeue());
            mostraFila(filaNum);

            filaNum.Enqueue(filaNum.Dequeue());
            mostraFila(filaNum);
        }

        static void mostraFila(Queue<int> f)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Qtde elementos na fila: {0}", f.Count);
            Console.WriteLine("----------------------------------");
            foreach(int n in f)
            {
                Console.WriteLine("Elemento: {0}", n);
            }
            Console.WriteLine("----------------------------------");
        }

    }
}
