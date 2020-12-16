using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    public class numeracionArabiga : SistemaNumerico
    {
        private int simbolo;

        public int Simbolo
        {
            get => simbolo;
            set => simbolo = value;
        }

        private string definicion;
        public string Definicion
        {
            get => definicion;
            set => definicion = value;
        }

        private double añodeCreacion;
        public double AñodeCreacion
        {
            get => añodeCreacion;
            set => añodeCreacion = value;
        }

        public numeracionArabiga(string caracteristicas, double añoOrigen, string tipodeSistema, int simbolo, string definicion, double añodeCreacion) : base(caracteristicas, añoOrigen, tipodeSistema)
        {
            this.simbolo = simbolo;
            this.definicion = definicion;
            this.añodeCreacion = añodeCreacion;
        }

    }
}
