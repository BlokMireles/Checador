using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Checador
{
    public class ETipoPersonal
    {
        private int _IDTIPOPERSONAL;
        private string _TIPOPERSONAL;

        public int IDTIPOPERSONAL { get => _IDTIPOPERSONAL; set => _IDTIPOPERSONAL = value; }
        public string TIPOPERSONAL { get => _TIPOPERSONAL; set => _TIPOPERSONAL = value; }
    }
}
