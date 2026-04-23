using AFRetroAlimentacion.Reglas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AFRetroAlimentacion.SeleccionDeAnimal
{
    public abstract class SeleccionAnimal
    {
        public abstract IAcciones Seleccionar();
        public IAcciones Actividad()
        {
            IAcciones habilidad = Seleccionar();
            habilidad.Habla();
            habilidad.Movimiento();
            habilidad.Comida();
            return habilidad;
        }
    }
}
