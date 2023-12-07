using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploHilo4
{
    class Program
    {
        static void Instrucciones(Object o)
        {
            int numero = (int)o; //Casteando objeto.
            Thread.Sleep(numero * 1000);
            Console.WriteLine("Hola {0}", numero);
        }
        static void Main(string[] args)
        {
            Thread[] hilos = new Thread[4];
            for (int i = 0; i < hilos.Length; i++)
            {
                hilos[i] = new Thread(new ParameterizedThreadStart(Instrucciones)); //Al utilizar "ParameterizedThreadStart" se puede intregar un método que tenga como parámetro un objeto.
                hilos[i].Start(i + 1); //Aquí se entrega un objeto y se casetea en el método.
            }
            Console.ReadKey();
        }
    }
}
