using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploHilo3
{
    class Program
    {
        static void Instrucciones()
        {
            int numero = Convert.ToInt32(Thread.CurrentThread.Name);

            Thread.Sleep(numero * 1000);
            Console.WriteLine("Hola Mundo " + numero);
        }
        static void Main(string[] args)
        {
            Thread[] hilos = new Thread[4];
            for (int i =  0; i < hilos.Length; i++)
            {
                hilos[i] = new Thread(new ThreadStart(Instrucciones));
                hilos[i].Name = (i + 1).ToString();
                hilos[i].Start();
            }
            Console.ReadKey();
        }
    }
}
