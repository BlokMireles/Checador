using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Checador
{
   public class EChecadas
    {
        private int _IDCHECADO;
        private string _Hora;
        private string _FECHA;
        private string _FKRFC;

        public int IDCHECADO { get => _IDCHECADO; set => _IDCHECADO = value; }
        public string Hora { get => _Hora; set => _Hora = value; }
        public string FECHA { get => _FECHA; set => _FECHA = value; }
        public string FKRFC { get => _FKRFC; set => _FKRFC = value; }
    }
}
