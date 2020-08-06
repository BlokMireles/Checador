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
    public partial class HorariosModal : Form
    {
        private HorariosManejador  _horariosManejador;
        private EHorarios _eHorarios;
        private bool _isEnablebinding = false;
        public HorariosModal()
        {
            _horariosManejador = new HorariosManejador();
            _eHorarios = new EHorarios();
            BindingHorarios();
            _isEnablebinding = true;
            InitializeComponent();
            CmbRfc.DropDownStyle = ComboBoxStyle.DropDownList;
            TxtDia.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public HorariosModal(EHorarios _eHorarios)
        {
            _horariosManejador = new HorariosManejador();
            _eHorarios = new EHorarios();
        }
        private void BindingHorarios()
        {
            if (_isEnablebinding)
            {
               // _eHorarios.IDhorario = int.Parse(TxtId.Text);
                _eHorarios.Dia = TxtDia.Text;
                _eHorarios.HoraEntrada = TxthoraEntrada.Text;
                _eHorarios.HoraSalida = TxtHoraSalida.Text;
               _eHorarios.FKRFC = CmbRfc.SelectedValue.ToString();

            }
        }
        private void BindingHorarios2()
        {
            if (_isEnablebinding)
            {
                 _eHorarios.IDhorario = int.Parse(TxtId.Text);
                _eHorarios.Dia = TxtDia.Text;
                _eHorarios.HoraEntrada = TxthoraEntrada.Text;
                _eHorarios.HoraSalida = TxtHoraSalida.Text;
                _eHorarios.FKRFC = CmbRfc.SelectedValue.ToString();

            }
        }

        private void HorariosModal_Load(object sender, EventArgs e)
        {
            llenarTipoPersonal("");
            BuscarCita("");
        }

        private void BtnAct_Click(object sender, EventArgs e)
        {
            BindingHorarios2();
            _horariosManejador.Actualizar(_eHorarios);
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
            BindingHorarios2();
            _horariosManejador.Actualizar(_eHorarios);
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
            BindingHorarios();
            _horariosManejador.Guardar(_eHorarios);
            BuscarCita("");
            limpiartxt();
            BtnAct.Visible = false;
            BtnEliminar.Visible = false;
            BtnEliminar.Enabled = false;
            BtnAct.Enabled = false;
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
        private void BuscarCita(string filtro)
        {
            Datos.DataSource = _horariosManejador.ObtenerLista(filtro);
        }
        private void limpiartxt()
        {
            TxthoraEntrada.Clear();
            TxtHoraSalida.Clear();
        }
        private void llenarTipoPersonal(string filtro)
        {
            CmbRfc.DataSource = _horariosManejador.ObtenerLista2(filtro);
            CmbRfc.DisplayMember = "NOMBRE";
            CmbRfc.ValueMember = "RFC";

        }

        private void CmbRfc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow rellenar = Datos.Rows[e.RowIndex];
            TxtId.Text = rellenar.Cells["IDhorario"].Value.ToString();
            TxthoraEntrada.Text = rellenar.Cells["HoraEntrada"].Value.ToString();
            TxtHoraSalida.Text = rellenar.Cells["HoraSalida"].Value.ToString();

            BtnAct.Visible = true;
            BtnEliminar.Visible = true;
            BtnEliminar.Enabled = true;
            BtnAct.Enabled = true;
            BtnGuardar.Visible = true;
            BtnGuardar.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
