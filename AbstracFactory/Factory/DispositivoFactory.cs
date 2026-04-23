using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    public abstract class DispositivoFactory
    {
        public abstract IDispositivo DispositivoElectronico();

        // la diferenca entre la parte de las interfaz
        // las interfas no tiene logica 
        // las clases abstracts si la tienen

        public IDispositivo seleccionar()
        {
            IDispositivo dispositivo = DispositivoElectronico();
            dispositivo.Encender();
            dispositivo.Apagar();
            dispositivo.Iniciar();
            dispositivo.Suspender();
            return dispositivo;
        }
    }
}
