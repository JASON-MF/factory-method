using AFRetroAlimentacion.Objetoseguirreglas;
using AFRetroAlimentacion.Reglas;
using AFRetroAlimentacion.SeleccionDeAnimal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFRetroAlimentacion.FactoryClass
{
    public class DelfinFactory : SeleccionAnimal
    {
        public override IAcciones Seleccionar()
        {
            return new Delfin();
        }
    }
}
