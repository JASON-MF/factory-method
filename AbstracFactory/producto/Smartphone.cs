using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.producto
{
    public class Smartphone : IDispositivo
    {
        public void Encender()
        {
            Console.WriteLine("Smartphone encendido");
        }

        public void Apagar()
        {
            Console.WriteLine("Smartphone apagado");
        }

        public void Iniciar()
        {
            Console.WriteLine("Smartphone iniciado");
        }

        public void Suspender() 
        {
            Console.WriteLine("Smartphone suspendido");
        }

    }
}
