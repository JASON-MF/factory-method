using AFRetroAlimentacion.Objetoseguirreglas;
using AFRetroAlimentacion.Reglas;
using AFRetroAlimentacion.SeleccionDeAnimal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFRetroAlimentacion.FactoryClass
{
    public class MariposaFactory : SeleccionAnimal
    {
        public override IAcciones Seleccionar()
        {
        return new Mariposa();
        }


    }
}
