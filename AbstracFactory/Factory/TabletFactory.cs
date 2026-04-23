using AbstracMethod.producto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod.Factory
{
    internal class TabletFactory : DispositivoFactory
    {
        public override IDispositivo DispositivoElectronico()
        {
            return new Tablet ();
        }
    }
}
