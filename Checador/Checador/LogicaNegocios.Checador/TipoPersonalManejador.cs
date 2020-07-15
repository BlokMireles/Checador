using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Checador;
using AccesoDatos.Checador2;
using System.Text.RegularExpressions;

namespace LogicaNegocios.Checador
{
   public class TipoPersonalManejador
    {
        private TipoPersonalAccesoDatos _tipoPersonalAccesoDatos;
        private ETipoPersonal tipoPersonal;
        public TipoPersonalManejador()
        {
            _tipoPersonalAccesoDatos = new TipoPersonalAccesoDatos();
            tipoPersonal = new ETipoPersonal ();
        }
        public void Eliminar(ETipoPersonal tipoPersonal)
        {
            _tipoPersonalAccesoDatos.Eliminar(tipoPersonal);
        }

        public void Guardar(ETipoPersonal tipoPersonal)
        {
            _tipoPersonalAccesoDatos.Guardar(tipoPersonal);
        }
        public void Actualizar(ETipoPersonal tipoPersonal)
        {
            _tipoPersonalAccesoDatos.Actualizar(tipoPersonal);
        }
        public List<ETipoPersonal> ObtenerLista(string filtro)
        {
            var list = new List<ETipoPersonal>();
            list = _tipoPersonalAccesoDatos.ObtenerLista(filtro);
            return list;
        }
        
    }
}
