using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    public class SistemaNumerico
    {
        protected string caracteristicas = "Cada dígito tiene un valor absoluto y un valor relativo según su posición. El valor de cada posición es una potencia del número que es la base del sistema.";
        protected double añoOrigen = 7.000;
        protected string tipodeSistema = "Arabigo, Romano";

        public SistemaNumerico(string caracteristicas, double añoOrigen, string tipodeSistema)
        {
            this.caracteristicas = caracteristicas;
            this.añoOrigen = añoOrigen;
            this.tipodeSistema = tipodeSistema;
        }
        public string Caracteristicas
        {
            get { return caracteristicas; }
            set { caracteristicas = value; }
        }
        public double AñoOrigen
        {
            get { return añoOrigen; }
            set { añoOrigen = value; }
        }
        public string TipodeSistema
        {
            get { return tipodeSistema; }
            set { tipodeSistema = value; }
        }

    }
}
