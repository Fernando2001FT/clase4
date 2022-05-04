using System;
using System.Collections.Generic;

namespace EjerciciosISP.Ejercicio1
{
    public class PagoPrestamo : Pago
    {
        //public void IniciarPago()
        //{
        //    throw new NotImplementedException();
        //}

        public string Estado()
        {
            return string.Empty;
        }

        public List<string> ObtenerPagos()
        {
            return new List<string>();
        }

        public void IniciarTotal()
        {
            
        }

        public void IniciarAtrasado()
        {
            
        }
    }
}