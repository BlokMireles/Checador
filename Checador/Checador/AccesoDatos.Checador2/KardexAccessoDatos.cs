using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Checador;
using ConexionBD;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.Checador2
{
   public class KardexAccessoDatos
    {
        Conexion _conexion;
        public KardexAccessoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "checador", 3306);
        }
        public void Eliminar(EPersonal ePersonal)
        {
            string cadena = string.Format("Delete from Kardex where RFC = {0} ", ePersonal.RFC);
            _conexion.EjecutarConsulta(cadena);
            MessageBox.Show(cadena);
        }
        public void Actualizar(EKardex eKardex)
        {
           
                string cadena = string.Format("Call p_Horarios(null,'{0}','{1}','{2}','{3}','{4}','{5}',2);", eKardex.FECHA, eKardex.HORAENTRADAK, eKardex.HORASALIDAK, eKardex.ASITENTRADA, eKardex.ASISTSALIDA, eKardex.FKRFC);
                _conexion.EjecutarConsulta(cadena);
                MessageBox.Show(cadena);
           
        }
        public void Guardar(EKardex eKardex)
        {

            if (eKardex.FKRFC != " ")
            {
                string cadena = string.Format("Call p_Horarios(null, '{0}', '{1}', '{2}', '{3}','{4}','{5}',1)", eKardex.FECHA,eKardex.HORAENTRADAK,eKardex.HORASALIDAK,eKardex.ASITENTRADA,eKardex.ASISTSALIDA,eKardex.FKRFC);
              //  MessageBox.Show(cadena);
                _conexion.EjecutarConsulta(cadena);
            }

        }
        public List<EPersonal> ObtenerLista(string filtro)
        {
            var list = new List<EPersonal>();
            string consulta = string.Format("Select * from personal", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "personal");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var epersonal = new EPersonal
                {
                    RFC = row["RFC"].ToString(),
                    NOMBRE = row["NOMBRE"].ToString(),
                    APELLIDOP = row["APELLIDOP"].ToString(),
                    APELLIDOM = row["APELLIDOM"].ToString(),
                    FECHADENACIMIENTO = row["FECHADENACIMIENTO"].ToString(),
                    FKTIPOPERSONAL = int.Parse(row["FKTIPOPERSONAL"].ToString()),

                };
                list.Add(epersonal);
            }
            return list;
        }
    }
}
