using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Checador
{
   public class EHorarios
    {
        private int _IDhorario;
        private string _Dia;
        private string _HoraEntrada;
        private string _HoraSalida;
        private string _FKRFC;

        public int IDhorario { get => _IDhorario; set => _IDhorario = value; }
        public string Dia { get => _Dia; set => _Dia = value; }
        public string HoraEntrada { get => _HoraEntrada; set => _HoraEntrada = value; }
        public string HoraSalida { get => _HoraSalida; set => _HoraSalida = value; }
        public string FKRFC { get => _FKRFC; set => _FKRFC = value; }
    }
}
