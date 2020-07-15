using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Checador
{
   public class EPersonal
    {
        private string _RFC;
        private string _NOMBRE;
        private string _APELLIDOP;
        private string _APELLIDOM;
        private string _FECHADENACIMIENTO;
        private int _FKTIPOPERSONAL;

        public string RFC { get => _RFC; set => _RFC = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string APELLIDOP { get => _APELLIDOP; set => _APELLIDOP = value; }
        public string APELLIDOM { get => _APELLIDOM; set => _APELLIDOM = value; }
        public string FECHADENACIMIENTO { get => _FECHADENACIMIENTO; set => _FECHADENACIMIENTO = value; }
        public int FKTIPOPERSONAL { get => _FKTIPOPERSONAL; set => _FKTIPOPERSONAL = value; }
    }
}
