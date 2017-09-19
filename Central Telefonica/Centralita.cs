using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Central_Telefonica
{
    class Centralita
    {
        protected List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        float GananciaPorLocal
        {
            get {
                return CalcularGanancia(TipoLlamada.Local); 
            }
        }

        void Centralita() {
            this._razonSocial = "NO TIENE";
            this._listaDeLlamadas = new List<Llamada>;
        }

        public float CalcularGanancia(TipoLlamada tipo) {

            float resultado = 0;
            switch (tipo)
	        {
		        case TipoLlamada.Local:
                        foreach (Llamada i in _listaDeLlamadas) {
                        if (i is Local) {
                            resultado += (float)((Local)i).CalcularCosto();
                        }
                    break;
                case TipoLlamada.Provincial:
                        foreach (Llamada i in _listaDeLlamadas) {
                        if (i is Provincial) {
                            resultado += (float)((Provincial)i).CalcularCosto();
                        }
                    break;
                case TipoLlamada.Todas:
                           if (i is Provincial) {
                            resultado += (float)((Provincial)i).CalcularCosto();
                            }
                        if (i is Provincial) {
                            resultado += (float)((Provincial)i).CalcularCosto();
                        }
                    break;
                    }
            }
        }
    }
    }
}

