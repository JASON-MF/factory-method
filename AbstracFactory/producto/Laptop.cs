using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.producto
{
    public class Laptop : IDispositivo
    {
        public void Encender()
        {
            Console.WriteLine("Laptop encendida");
        }

        public void Apagar()
        {
            Console.WriteLine("Laptop apagada");
        }

        public void Iniciar()
        {
            Console.WriteLine("Laptop iniciada");
        }

        public void Suspender()
        {
            Console.WriteLine("Laptop suspendida");
        }

    }
}
