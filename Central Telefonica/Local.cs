using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    public class Local : Llamada
    {
        float _costo;

        public float Costo
        {
            get
            {
                return this._costo;
            }
        }

        public Local(Llamada unaLlamada, float costo)
            : base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._costo = costo;
        }

        public Local(float costo, string origen, string destino, float duracion)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        float calcularCosto()
        {
            return this._costo * base._duracion;
        }

        void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar() + "Costo: " + this._costo);
        }
    }
}
