using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Checador;
using AccesoDatos.Checador2;

namespace LogicaNegocios.Checador
{
   public class ChecadorManejador
    {
        private ChecadasAccesoDatos _checadasAccesoDatos;
        private EChecadas eChecadas;
        public ChecadorManejador()
        {
            _checadasAccesoDatos = new ChecadasAccesoDatos();
            eChecadas = new EChecadas();
        }
        public void Eliminar(EChecadas eChecadas)
        {
            _checadasAccesoDatos.Eliminar(eChecadas);
        }

        public void Guardar(EChecadas eChecadas)
        {
            _checadasAccesoDatos.Guardar(eChecadas);
        }
        public void Actualizar(EChecadas eChecadas)
        {
            _checadasAccesoDatos.Actualizar(eChecadas);
        }
    }
}
