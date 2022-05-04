using System;
using System.Collections.Generic;

namespace EjerciciosISP.Ejercicio1
{
    public class PagoBancario : Pago, IPagoBancario
    {
        public void IniciarPago()
        {
            
        }

        public string Estado()
        {
            return String.Empty;
        }

        public List<string> ObtenerPagos()
        {
            return new List<string>();
        }

        public void IniciarTotal()
        {
            throw new NotImplementedException();
        }

        public void IniciarAtrasado()
        {
            throw new NotImplementedException();
        }

        public void IniciarPAgo()
        {
            throw new NotImplementedException();
        }
    }
}