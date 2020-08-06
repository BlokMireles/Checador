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
  public  class ChecadasAccesoDatos
    {
        Conexion _conexion;
        public ChecadasAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "checador", 3306);
        }
        public void Eliminar(EChecadas eChecadas )
        {
            string cadena = string.Format("Delete from checadas where IDCHECADO = {0} ", eChecadas.IDCHECADO);
            _conexion.EjecutarConsulta(cadena);
            MessageBox.Show("Acceso Correcto");
        }
        public void Actualizar(EChecadas eChecadas)
        {
            DialogResult dr = MessageBox.Show("Desea Guardar los datos", "Guardar Datos", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string cadena = string.Format("Update checadas set  FKRFC='{0}', Hora='{1}',FECHA='{2}'    where IDCHECADO = '{3}'", eChecadas.FECHA,eChecadas.Hora,eChecadas.FKRFC,eChecadas.IDCHECADO);
                _conexion.EjecutarConsulta(cadena);
                MessageBox.Show(cadena);
            }
        }
        public void Guardar(EChecadas eChecadas)
        {

            if (eChecadas.FKRFC != " ")
            {
               
                string cadena = string.Format("insert into checadas values(null, '{1}', '{2}', '{3}')", eChecadas.IDCHECADO,eChecadas.Hora,eChecadas.FECHA,eChecadas.FKRFC);
               // MessageBox.Show("Acceso Correcto");
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
