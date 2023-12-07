using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploHilo2
{
    class Program
    {
        static void Instrucciones()
        {
            switch (Thread.CurrentThread.Name)
            {
                case "Hilo 1":
                    Thread.Sleep(0);
                    Console.WriteLine("Hola Mundo 1");
                    break;
                case "Hilo 2":
                    Thread.Sleep(2000);
                    Console.WriteLine("Hola Mundo 2");
                    break;
                case "Hilo 3":
                    Thread.Sleep(3000);
                    Console.WriteLine("Hola Mundo 3");
                    break;
                case "Hilo 4":
                    Thread.Sleep(4000);
                    Console.WriteLine("Hola Mundo 4");
                    break;
                default:
                    Console.WriteLine("No existe un hilo con ese nombre");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Instrucciones));
            Thread t2 = new Thread(new ThreadStart(Instrucciones));
            Thread t3 = new Thread(new ThreadStart(Instrucciones));
            Thread t4 = new Thread(new ThreadStart(Instrucciones));

            t1.Name = "Hilo 1";
            t2.Name = "Hilo 2";
            t3.Name = "Hilo 3";
            t4.Name = "Hilo 4";

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            Console.ReadKey();
        }
    }
}
