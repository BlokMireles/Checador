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
    public partial class TipoPersonal : Form
    {
        private TipoPersonalManejador _tipoPersonalManejador;
        private ETipoPersonal _tipopersonal;
        private bool _isEnablebinding = false;
        public TipoPersonal()
        {
            _tipoPersonalManejador = new TipoPersonalManejador();
            _tipopersonal = new ETipoPersonal();
            BindingTpersonal();
            _isEnablebinding = true;
            InitializeComponent();
        }
        public TipoPersonal(TipoPersonal tipoPersonal)
        {
            _tipoPersonalManejador = new TipoPersonalManejador();
            _tipopersonal = new ETipoPersonal();
        }
        private void BindingTpersonal()
        {
            if (_isEnablebinding)
            {
                _tipopersonal.TIPOPERSONAL = TxtTpersonal.Text;
            }
        }
        private void BindingTpersonal2()
        {
            if (_isEnablebinding)
            {
                _tipopersonal.IDTIPOPERSONAL = int.Parse(TxtId.Text);
                _tipopersonal.TIPOPERSONAL = TxtTpersonal.Text;
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BindingTpersonal();
            _tipoPersonalManejador.Guardar(_tipopersonal);
            BuscarCita("");
            limpiartxt();
        }
        private void BuscarCita(string filtro)
        {
            Datos.DataSource = _tipoPersonalManejador.ObtenerLista(filtro);
        }
        private void limpiartxt()
        {
            TxtTpersonal.Clear();

            TxtId.Clear();

        }

        private void TipoPersonal_Load(object sender, EventArgs e)
        {
            BuscarCita("");
        }

        private void Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rellenar = Datos.Rows[e.RowIndex];
            TxtId.Text = rellenar.Cells["IDTIPOPERSONAL"].Value.ToString();
            TxtTpersonal.Text = rellenar.Cells["TIPOPERSONAL"].Value.ToString();

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

        private void BtnAct_Click(object sender, EventArgs e)
        {
            BindingTpersonal2();
            _tipoPersonalManejador.Actualizar(_tipopersonal);
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
            BindingTpersonal2();
            _tipoPersonalManejador.Eliminar(_tipopersonal);
            BuscarCita("");
            limpiartxt();
            BtnAct.Visible = false;
            BtnEliminar.Visible = false;
            BtnEliminar.Enabled = false;
            BtnAct.Enabled = false;
            BtnGuardar.Visible = true;
            BtnGuardar.Enabled = true;
        }
    }
}
