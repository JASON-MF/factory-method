using AFRetroAlimentacion.Reglas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFRetroAlimentacion.Objetoseguirreglas
{
    public class Cangrejo : IAcciones
    {
        public void Comida()
        {
            Console.WriteLine("Los cangrejos comen algas, peces pequeños, moluscos, restos orgánicos");
        }

        public void Habla()
        {
            Console.WriteLine("no tiene voz, se comunica con movimientos de pinzas y señales");
        }

        public void Movimiento()
        {
            Console.WriteLine("camina de lado con sus patas y puede nadar brevemente");
        }
    }
}
