using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios.Checador;
using Entidades.Checador;

namespace Checador2
{
    public partial class RegistroPersonal : Form
    {
        private PersonalManejador _PersonalManejador;
        private EPersonal _personal;
        private bool _isEnablebinding = false;
        public RegistroPersonal()
        {
            _PersonalManejador = new PersonalManejador();
            _personal = new EPersonal();
            Bindingpersonal();
            _isEnablebinding = true;
            InitializeComponent();
        }
        public RegistroPersonal(EPersonal Personal)
        {
            _PersonalManejador = new PersonalManejador();
            _personal = new EPersonal();
        }

        private void Bindingpersonal()
        {
            if (_isEnablebinding)
            {
                _personal.RFC = TxtRFC.Text;
                _personal.NOMBRE = TxtNombre.Text;
                _personal.APELLIDOP = TxtApeP.Text;
                _personal.APELLIDOM = TxtApeM.Text;
                _personal.FECHADENACIMIENTO = TxtFecha.Text;
                _personal.FKTIPOPERSONAL = int.Parse( CmbTp.SelectedValue.ToString());
               
            }
        }

        private void BtnAct_Click(object sender, EventArgs e)
        {
            Bindingpersonal();
            _PersonalManejador.Actualizar(_personal);
            BuscarCita("");
            limpiartxt();
            BtnAct.Visible = false;
            BtnEliminar.Visible = false;
            BtnEliminar.Enabled = false;
            BtnAct.Enabled = false;
            BtnGuardar.Visible = true;
            BtnGuardar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Bindingpersonal();
            _PersonalManejador.Actualizar(_personal);
            BuscarCita("");
            limpiartxt();
            BtnAct.Visible = false;
            BtnEliminar.Visible = false;
            BtnEliminar.Enabled = false;
            BtnAct.Enabled = false;
            BtnGuardar.Visible = true;
            BtnGuardar.Enabled = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Bindingpersonal();
            _PersonalManejador.Guardar(_personal);
            BuscarCita("");
            limpiartxt();
        }
        private void BuscarCita(string filtro)
        {
            Datos.DataSource = _PersonalManejador.ObtenerLista(filtro);
        }
        private void limpiartxt()
        {
            TxtApeP.Clear();
            TxtApeM.Clear();
            TxtNombre.Clear();
            TxtRFC.Clear();
 


        }
        private void llenarTipoPersonal(string filtro)
        {
            CmbTp.DataSource = _PersonalManejador.ObtenerLista2(filtro);
            CmbTp.DisplayMember = "TIPOPERSONAL";
            CmbTp.ValueMember = "IDTIPOPERSONAL";

        }

        private void RegistroPersonal_Load(object sender, EventArgs e)
        {
            llenarTipoPersonal("");
            BuscarCita("");
        }

        private void Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rellenar = Datos.Rows[e.RowIndex];
            TxtRFC.Text = rellenar.Cells["RFC"].Value.ToString();
            TxtNombre.Text = rellenar.Cells["NOMBRE"].Value.ToString();
            TxtApeP.Text = rellenar.Cells["APELLIDOP"].Value.ToString();
            TxtApeM.Text = rellenar.Cells["APELLIDOM"].Value.ToString();
            TxtFecha.Text = rellenar.Cells["FECHADENACIMIENTO"].Value.ToString();
      
            BtnAct.Visible = true;
            BtnEliminar.Visible = true;
            BtnEliminar.Enabled = true;
            BtnAct.Enabled = true;
            BtnGuardar.Visible = false;
            BtnGuardar.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            limpiartxt();
            BtnAct.Visible = false;
            BtnEliminar.Visible = false;
            BtnEliminar.Enabled = false;
            BtnAct.Enabled = false;
            BtnGuardar.Visible = true;
            BtnGuardar.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CmbTp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
