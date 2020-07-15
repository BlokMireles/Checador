using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Checador;
using AccesoDatos.Checador2;

namespace LogicaNegocios.Checador
{
   public class PersonalManejador
    {
        private PersonalAccesoDatos _PersonalAccesoDatos;
        private EPersonal ePersonal;
        public PersonalManejador()
        {
            _PersonalAccesoDatos = new PersonalAccesoDatos();
            ePersonal = new EPersonal();
        }
        public void Eliminar(EPersonal ePersonal)
        {
            _PersonalAccesoDatos.Eliminar(ePersonal);
        }

        public void Guardar(EPersonal ePersonal)
        {
            _PersonalAccesoDatos.Guardar(ePersonal);
        }
        public void Actualizar(EPersonal ePersonal)
        {
            _PersonalAccesoDatos.Actualizar(ePersonal);
        }
        public List<EPersonal> ObtenerLista(string filtro)
        {
            var list = new List<EPersonal>();
            list = _PersonalAccesoDatos.ObtenerLista(filtro);
            return list;
        }
        public List<ETipoPersonal> ObtenerLista2(string filtro)
        {
            var list = new List<ETipoPersonal>();
            list = _PersonalAccesoDatos.ObtenerLista2(filtro);
            return list;
        }

    }
}
