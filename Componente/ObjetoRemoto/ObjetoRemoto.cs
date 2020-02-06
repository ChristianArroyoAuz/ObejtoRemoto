using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;


namespace ObjetoRemoto
{
    public class ObjetoRemoto : MarshalByRefObject
    {
        public string ObtenerDominioActual()
        {
            return AppDomain.CurrentDomain.FriendlyName;
        }
    }
}