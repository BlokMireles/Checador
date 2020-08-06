using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LogicaNegocios.Checador;
using Entidades.Checador;

namespace Checador2
{
    public partial class Checador : Form
    {
        private ChecadorManejador _checadorManejador;
        private EChecadas _eChecadas;
        private KardexManejador _kardexManejador;
        private EKardex _eKardex;
        private bool _isEnablebinding = false;
        MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;database=checador");
        public Checador()
        {
            _checadorManejador = new ChecadorManejador ();
            _eChecadas= new EChecadas();
            _kardexManejador = new KardexManejador();
            _eKardex = new EKardex();
            BindingChecadas();
            BindingkardexF();
            BindingkardexA();
            _isEnablebinding = true;
            InitializeComponent();
        }
        public Checador(EChecadas eChecadas,EKardex eKardex)
        {
            _checadorManejador = new ChecadorManejador();
            _eChecadas = new EChecadas();
            _kardexManejador = new KardexManejador();
            _eKardex = new EKardex();
        }
        private void BindingChecadas()
        {
            if (_isEnablebinding)
            {
                _eChecadas.FKRFC = TxtRFC.Text;
                _eChecadas.FECHA = LblFecha.Text;
                _eChecadas.Hora = LblHora.Text;
            }
        }
        private void BindingkardexF()
        {
            if (_isEnablebinding)
            {
               
                _eKardex.FKRFC = TxtRFC.Text;
                _eKardex.FECHA = LblFecha.Text;
                _eKardex.HORAENTRADAK = LblHora.Text;
                _eKardex.HORASALIDAK = LblHora.Text;
             //   _eKardex.ASITENTRADA = "";
               // _eKardex.ASISTSALIDA = "";
            }
        }
        private void BindingkardexA()
        {
            if (_isEnablebinding)
            {

                _eKardex.FKRFC = TxtRFC.Text;
                _eKardex.FECHA = LblFecha.Text;
                _eKardex.HORAENTRADAK = LblHora.Text;
                _eKardex.HORASALIDAK = LblHora.Text;
             //   _eKardex.ASITENTRADA = "";
               // _eKardex.ASISTSALIDA = "";
            }
        }
        private void Hora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm");
            LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Checador_Load(object sender, EventArgs e)
        {
            Hora.Enabled = true;
        }

        private void BtnChe_Click(object sender, EventArgs e)
        {
            GuardarC();
            GuardarK();
        }
        private void limpiartxt()
        {
            TxtRFC.Clear();
        }
        private void GuardarC()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM personal WHERE RFC ='" + TxtRFC.Text + "' ", con);
            MySqlDataReader leer = cmd.ExecuteReader();
            
            if (leer.Read())
            {

                //   BindingkardexF();
                //   _kardexManejador.Guardar(_eKardex);

                MessageBox.Show("Checada Correcta!! "+ leer["NOMBRE"].ToString()+" " + leer["APELLIDOP"].ToString()+" "+ leer["APELLIDOM"].ToString());
                BindingChecadas();
            
                _checadorManejador.Guardar(_eChecadas);
                
            }
            else
                MessageBox.Show("RFC No existe verificar los datos");
            con.Close();
        
        }

        private void GuardarK()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM kardex WHERE FKRFC ='" + TxtRFC.Text + "'and FECHA ='"+LblFecha.Text+" '", con);
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {

               
                BindingkardexA();
                _kardexManejador.Actualizar(_eKardex);
                limpiartxt();
            }
            else
                BindingkardexF();
            _kardexManejador.Guardar(_eKardex);
            limpiartxt();
            con.Close();
            
        }
       
        private void ValidarE()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from horarios,checadas where '"+ LblHora.Text + "' < horarios.HoraEntrada and horarios.FKRFC = '"+ TxtRFC.Text+ "'and checadas.FKRFC = '"+TxtRFC.Text+"' ", con);
            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                var a = LblHora.Text;
                var b = leer["HoraEntrada"].ToString();
                DateTime HEC = DateTime.Parse(a);
                DateTime HEH = DateTime.Parse(b);
                if (HEC < HEH)
                {
                    _eKardex.ASITENTRADA = "A";
                    BindingkardexA();
                    _kardexManejador.Actualizar(_eKardex);
                    limpiartxt();
                }
                else
                _eKardex.ASITENTRADA = "F";
                     BindingkardexA();
            _kardexManejador.Guardar(_eKardex);
            limpiartxt();


            }
            else
                BindingkardexA();
            _kardexManejador.Guardar(_eKardex);
            limpiartxt();
            con.Close();

        }
    }
}
