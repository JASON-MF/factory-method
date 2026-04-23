using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.producto
{
    public class Tablet : IDispositivo
    {
        public void Encender()
        {
            Console.WriteLine("Tablet encendida");
        }

        public void Apagar()
        {
            Console.WriteLine("Tablet apagada");
        }


        public void Iniciar()
        {
            Console.WriteLine("Tablet iniciada");
        }

        public void Suspender()
        {
            Console.WriteLine("Tablet suspendida");
        }
    }
}

       
