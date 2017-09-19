using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;


        public float Duracion
        {
            get
            {
                return _duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return _nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return _nroOrigen;
            }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }

        public string Mostrar()
        {
            return "Duracion: " + this._duracion + " | Origen: " + this._nroOrigen + " | Duración: " + this._nroDestino;
        }

        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            if (uno.Duracion > dos.Duracion)
                return 1;
            else if (uno.Duracion < dos.Duracion)
                return -1;
            else
                return 0;
        }
    }
}