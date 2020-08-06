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
  public  class HorariosAccesoDatos
    {
        Conexion _conexion;
        public HorariosAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "checador", 3306);
        }
        public void Eliminar(EHorarios eHorarios)
        {
            string cadena = string.Format("Delete from horarios where IDhorario = {0} ", eHorarios.IDhorario);
            _conexion.EjecutarConsulta(cadena);
            MessageBox.Show(cadena);
        }
        public void Actualizar(EHorarios eHorarios)
        {
            DialogResult dr = MessageBox.Show("Desea Guardar los datos", "Guardar Datos", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string cadena = string.Format("Update horarios set  Dia='{0}', HoraEntrada='{1}', HoraSalida ='{2}',FKRFC='{3}'   where IDhorario = '{4}'", eHorarios.Dia,eHorarios.HoraEntrada,eHorarios.HoraSalida,eHorarios.FKRFC,eHorarios.IDhorario);
                _conexion.EjecutarConsulta(cadena);
                MessageBox.Show(cadena);
            }
        }
        public void Guardar(EHorarios eHorarios)
        {

            if (eHorarios.FKRFC != " ")
            {

                string cadena = string.Format("insert into horarios values(null, '{1}', '{2}', '{3}','{4}')", eHorarios.IDhorario,eHorarios.Dia,eHorarios.HoraEntrada,eHorarios.HoraSalida,eHorarios.FKRFC );
                // MessageBox.Show("Acceso Correcto");
                _conexion.EjecutarConsulta(cadena);
            }



        }
        public List<EHorarios> ObtenerLista(string filtro)
        {
            var list = new List<EHorarios>();
            string consulta = string.Format("Select * from horarios", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "horarios");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var eHorarios = new EHorarios
                {
                    IDhorario = int.Parse(row["IDhorario"].ToString()),
                    Dia = row["Dia"].ToString(),
                    HoraEntrada = row["HoraEntrada"].ToString(),
                    HoraSalida = row["HoraSalida"].ToString(),
                    FKRFC = row["FKRFC"].ToString(),

                };
                list.Add(eHorarios);
            }
            return list;
        }
        public List<EPersonal> ObtenerLista2(string filtro)
        {
            var list = new List<EPersonal>();
            string consulta = string.Format("select * from personal where NOMBRE   like '%{0}%' and APELLIDOP like '%{0}%' and APELLIDOM like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "personal");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var ePersonal = new EPersonal
                {
                    RFC = row["RFC"].ToString(),
                    NOMBRE = row["NOMBRE"].ToString(),
                    APELLIDOP = row["APELLIDOP"].ToString(),
                    APELLIDOM = row["APELLIDOM"].ToString(),
                };
                list.Add(ePersonal);
            }
            return list;
        }

    }
}
