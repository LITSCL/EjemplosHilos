using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjemploHilo1
{
    class Program
    {
        static void Ejecutar()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("{0:} Esta es la repetición número {1}", Thread.CurrentThread.Name, i);
            }
        }
        static void Main(string[] args)
        {
            /*
                El hilo principal (Main), es de primer plano.
                Todos los hilos por defecto son de primer plano (Hilo1, Hilo2).
                Si hay un hilo de primer plano que aún no termina su ejecución, el programa no se cierra.
                Es por eso que la consola no se cierra aunque se haya leído la última línea del método Main.
             */
            Console.WriteLine("Hilo princinpal iniciado (Main)");
            Thread t1 = new Thread(new ThreadStart(Ejecutar)); //Aquí se crea el hilo (Todavía no se inicia).
            t1.Name = "Hilo 1";
            //t1.IsBackground = true;
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(Ejecutar)); //Aquí se crea el hilo (Todavía no se inicia).
            t2.Name = "Hilo 2";
            //t2.IsBackground = true;
            t2.Start();
            Console.WriteLine("Hilo princinpal finalizado (Main)");
            //Console.ReadKey(); //Aquí la consola espera que escribamos algo (Simplemente es para que no se cierre).
        }
    }
}
