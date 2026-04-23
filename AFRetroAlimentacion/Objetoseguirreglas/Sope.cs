using AFRetroAlimentacion.Reglas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFRetroAlimentacion.Objetoseguirreglas
{
    internal class Sope : IAcciones
    {
        public void Comida()
        {
            Console.WriteLine("Carroneros y omnivoros");
        }

        public void Habla()
        {
            Console.WriteLine("Gesticulan pero no tienen un sistema" +
                "complejo de comunicacion");
        }

        public void Movimiento()
        {
            Console.WriteLine("Vuelan pero" +
                " al ser grandes necesitan descanso constante");
        }
    }
}
