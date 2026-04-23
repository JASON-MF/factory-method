using AFRetroAlimentacion.Reglas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFRetroAlimentacion.Objetoseguirreglas
{
    public class Humano : IAcciones
    {
        public void Comida()
        {
            Console.WriteLine("Los humanos son omnivoros");
        }

        public void Habla()
        {
            Console.WriteLine("El humano habla diversos" + "idiomas segun su region");
        }

        public void Movimiento()
        {
            Console.WriteLine("Hasta hace " + "200 year eran fisicamente activos");
        }
    }
}
