using AbstracMethod.producto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    public class SmartphoneFactory : DispositivoFactory
    {
        public override IDispositivo DispositivoElectronico()
        {
            return new Smartphone ();
        }
    }
}