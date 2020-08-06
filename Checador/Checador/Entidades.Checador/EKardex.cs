using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Checador
{
    public class EKardex
    {
        private int _IDKARDEX;
        private string _FECHA;
        private string _HORAENTRADAK;
        private string _HORASALIDAK;
        private string _ASITENTRADA;
        private string _ASISTSALIDA;
        private string _FKRFC;

        public int IDKARDEX { get => _IDKARDEX; set => _IDKARDEX = value; }
        public string FECHA { get => _FECHA; set => _FECHA = value; }
        public string HORAENTRADAK { get => _HORAENTRADAK; set => _HORAENTRADAK = value; }
        public string HORASALIDAK { get => _HORASALIDAK; set => _HORASALIDAK = value; }
        public string ASITENTRADA { get => _ASITENTRADA; set => _ASITENTRADA = value; }
        public string ASISTSALIDA { get => _ASISTSALIDA; set => _ASISTSALIDA = value; }
        public string FKRFC { get => _FKRFC; set => _FKRFC = value; }
    }
}
