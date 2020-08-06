using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Checador;
using AccesoDatos.Checador2;

namespace LogicaNegocios.Checador
{
   public class HorariosManejador
    {
        private HorariosAccesoDatos _horariosAccesoDatos;
        private EHorarios eHorarios;
        public HorariosManejador()
        {
            _horariosAccesoDatos = new HorariosAccesoDatos();
            eHorarios = new EHorarios();
        }
        public void Eliminar(EHorarios eHorarios)
        {
            _horariosAccesoDatos.Eliminar(eHorarios);
        }

        public void Guardar(EHorarios eHorarios)
        {
            _horariosAccesoDatos.Guardar(eHorarios);
        }
        public void Actualizar(EHorarios eHorarios)
        {
            _horariosAccesoDatos.Actualizar(eHorarios);
        }
        public List<EHorarios> ObtenerLista(string filtro)
        {
            var list = new List<EHorarios>();
            list = _horariosAccesoDatos.ObtenerLista(filtro);
            return list;
        }
        public List<EPersonal> ObtenerLista2(string filtro)
        {
            var list = new List<EPersonal>();
            list = _horariosAccesoDatos.ObtenerLista2(filtro);
            return list;
        }

    }
}