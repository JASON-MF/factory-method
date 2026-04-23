using AbstracMethod.producto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    public class LaptopFactory : DispositivoFactory
    {
        public override IDispositivo DispositivoElectronico()
        {
            return new Laptop ();
        }
    }
}