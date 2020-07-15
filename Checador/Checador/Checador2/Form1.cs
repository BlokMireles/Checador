using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            Hora.Enabled = true;
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Checador());
           
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button4.Location = new Point(31, 329);
           
            PanelRegistros.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PanelRegistros.Visible == true)
            {
                PanelRegistros.Visible = false;
            }
            else
            {
                PanelRegistros.Visible = true;
            }

            button4.Location = new Point(31, 329);
            PanelRegistros.Location = new Point(31, 400);
            
            if (PanelRegistros.Visible == false)
            {
               button4.Location = new Point(31, 329);
               
            }
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroPersonal());
        }

        private void BtnTp_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new TipoPersonal());
        }
    }
}
