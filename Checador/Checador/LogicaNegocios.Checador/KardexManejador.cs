using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Checador;
using AccesoDatos.Checador2;

namespace LogicaNegocios.Checador
{

    public class KardexManejador
    {
        private KardexAccessoDatos _kardexAccessoDatos;
        private EKardex eKardex;
        public KardexManejador()
        {
            _kardexAccessoDatos = new KardexAccessoDatos();
            eKardex = new EKardex();
        }
        public void Guardar(EKardex eKardex)
        {
            _kardexAccessoDatos.Guardar(eKardex);
        }
        public void Actualizar(EKardex eKardex)
        {
            _kardexAccessoDatos.Actualizar(eKardex);
        }
    }
}
