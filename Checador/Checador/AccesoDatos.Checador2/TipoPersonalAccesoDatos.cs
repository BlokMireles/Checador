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
   public class TipoPersonalAccesoDatos
    {
        Conexion _conexion;
        public TipoPersonalAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "checador", 3306);
        }
        public void Eliminar(ETipoPersonal tipoPersonal)
        {
            string cadena = string.Format("Delete from tipopersonal where IDTIPOPERSONAL = {0} ", tipoPersonal.IDTIPOPERSONAL);
            _conexion.EjecutarConsulta(cadena);
            MessageBox.Show(cadena);
        }
        public void Actualizar(ETipoPersonal tipoPersonal)
        {
            DialogResult dr = MessageBox.Show("Desea Guardar los datos", "Guardar Datos", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string cadena = string.Format("Update tipopersonal set  TIPOPERSONAL='{0}' where IDTIPOPERSONAL = '{1}'", tipoPersonal.TIPOPERSONAL,tipoPersonal.IDTIPOPERSONAL);
                _conexion.EjecutarConsulta(cadena);
                MessageBox.Show(cadena);
            }
        }
        public void Guardar(ETipoPersonal tipoPersonal)
        {

            if (tipoPersonal.TIPOPERSONAL != " ")
            {
                string cadena = string.Format("insert into tipopersonal values('null', '{1}')", tipoPersonal.IDTIPOPERSONAL,tipoPersonal.TIPOPERSONAL);
                MessageBox.Show(cadena);
                _conexion.EjecutarConsulta(cadena);
            }

        }
        public List<ETipoPersonal> ObtenerLista(string filtro)
        {
            var list = new List<ETipoPersonal>();
            string consulta = string.Format("Select * from tipopersonal", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "tipopersonal");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var tipoPersonal = new ETipoPersonal
                {
                    IDTIPOPERSONAL = int.Parse(row["IDTIPOPERSONAL"].ToString()),
                    TIPOPERSONAL = row["TIPOPERSONAL"].ToString(),

                };
                list.Add(tipoPersonal);
            }
            return list;
        }
        
    }
}
