using System;
using System.Collections.Generic;
using System.Text;

namespace AbstracMethod
{
    public  interface IDispositivo
    {
        #region explicacion interfaz
        // los metodoas abstractos de una interfaz 
        // nos permiten definir que hacer 
        // pero no como hacerlo 
        // permitir definir comportamientos 

        // metodos en comun estos metodos en comun 
        // una implmentacion por que las interfaz no se 
        // puede abstraer 
        // no se puede abstraer por que no tiene logica 
        #endregion

        public void Encender();
        public void Apagar();
        public void Iniciar();
        public void Suspender();

    }
}

