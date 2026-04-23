using AFRetroAlimentacion.Reglas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFRetroAlimentacion.Objetoseguirreglas
{
    Pu class Mariposa : IAcciones
    {
        public void Comida()
        {
            Console.WriteLine("Las mariposas se alimentan de néctar de flores y jugos de frutas");
        }

        public void Habla()
        {
            Console.WriteLine("no tiene voz, se comunica con colores, patrones en las alas y movimientos de vuelo");
        }

        public void Movimiento()
        {
            Console.WriteLine("vuela batiendo sus alas también puede posarse suavemente sobre flores o superficies.");
        }
    }
}
