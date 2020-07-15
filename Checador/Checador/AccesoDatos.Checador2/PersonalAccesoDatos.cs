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
    public  class PersonalAccesoDatos
    {
        Conexion _conexion;
        public PersonalAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "checador", 3306);
        }
        public void Eliminar(EPersonal ePersonal)
        {
            string cadena = string.Format("Delete from personal where RFC = {0} ", ePersonal.RFC);
            _conexion.EjecutarConsulta(cadena);
            MessageBox.Show(cadena);
        }
        public void Actualizar(EPersonal ePersonal)
        {
            DialogResult dr = MessageBox.Show("Desea Guardar los datos", "Guardar Datos", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string cadena = string.Format("Update personal set  NOMBRE='{0}', APELLIDOP='{1}',APELLIDOM='{2}',FECHADENACIMIENTO='{3}' ,FKTIPOPERSONAL = '{4}'    where RFC = '{5}'", ePersonal.NOMBRE,ePersonal.APELLIDOP,ePersonal.APELLIDOM,ePersonal.FECHADENACIMIENTO,ePersonal.FKTIPOPERSONAL,ePersonal.RFC);
                _conexion.EjecutarConsulta(cadena);
                MessageBox.Show(cadena);
            }
        }
        public void Guardar(EPersonal ePersonal)
        {

            if (ePersonal.NOMBRE != " ")
            {
                string cadena = string.Format("insert into personal values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", ePersonal.RFC, ePersonal.NOMBRE, ePersonal.APELLIDOP, ePersonal.APELLIDOM, ePersonal.FECHADENACIMIENTO, ePersonal.FKTIPOPERSONAL);
                MessageBox.Show(cadena);
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
        public List<ETipoPersonal> ObtenerLista2(string filtro)
        {
            var list = new List<ETipoPersonal>();
            string consulta = string.Format("select * from tipopersonal where TIPOPERSONAL like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "personal");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var etipopersonal = new ETipoPersonal
                {
                    IDTIPOPERSONAL = int.Parse(row["IDTIPOPERSONAL"].ToString()),
                    TIPOPERSONAL = row["TIPOPERSONAL"].ToString(),

                };
                list.Add(etipopersonal);
            }
            return list;
        }

    }
}
