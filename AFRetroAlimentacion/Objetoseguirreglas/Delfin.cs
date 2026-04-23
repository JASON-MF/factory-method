using AFRetroAlimentacion.Reglas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFRetroAlimentacion.Objetoseguirreglas
{
    public class Delfin : IAcciones
    {
        public void Comida()
        {
            Console.WriteLine("Se alimentan principalmente de pez");
        }

        public void Habla()
        {
            Console.WriteLine("tienen un sistema complejo de comunicacion " +
                "pero no utilizan palabras como los humans" +
                "Se dice que saben la 11");
        }

        public void Movimiento()
        {
            Console.WriteLine("Son nadadores expertos y muy rapidos");
        }
    }
}
