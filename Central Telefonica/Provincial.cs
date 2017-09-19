using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    class Provincial : Llamada
    {

        Franja _franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.calcularCosto();
            }
        }


        public Provincial(Franja _franjaHoraria, Llamada unaLlamada)
            : base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._franjaHoraria = _franjaHoraria;
        }

        public Provincial(string origen, Franja miFranja, string destino, float duracion)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }


        float calcularCosto()
        {
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:

                    return (float)(0.99 * base._duracion);

                case Franja.Franja_2:
                    return (float)(1.25 * base._duracion);

                case Franja.Franja_3:
                    return (float)(0.66 * base._duracion);

            }
            return 0;
        }

        string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar() + "| Franja: " + this._franjaHoraria + " | Costo: " + this.CostoLlamada.ToString());
            
            return sb.ToString();
        }

    }
}
