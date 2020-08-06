namespace Checador2
{
    partial class HorariosModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtDia = new System.Windows.Forms.ComboBox();
            this.CmbRfc = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAct = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.TxtHoraSalida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxthoraEntrada = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TxtId);
            this.panel1.Controls.Add(this.TxtDia);
            this.panel1.Controls.Add(this.CmbRfc);
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnAct);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.Datos);
            this.panel1.Controls.Add(this.TxtHoraSalida);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxthoraEntrada);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 768);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(763, 32);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(29, 20);
            this.TxtId.TabIndex = 21;
            this.TxtId.Visible = false;
            // 
            // TxtDia
            // 
            this.TxtDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtDia.FormattingEnabled = true;
            this.TxtDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.TxtDia.Location = new System.Drawing.Point(796, 136);
            this.TxtDia.Name = "TxtDia";
            this.TxtDia.Size = new System.Drawing.Size(189, 21);
            this.TxtDia.TabIndex = 20;
            this.TxtDia.Text = "Seleccionar dia";
            // 
            // CmbRfc
            // 
            this.CmbRfc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbRfc.FormattingEnabled = true;
            this.CmbRfc.Location = new System.Drawing.Point(246, 137);
            this.CmbRfc.Name = "CmbRfc";
            this.CmbRfc.Size = new System.Drawing.Size(291, 21);
            this.CmbRfc.TabIndex = 19;
            this.CmbRfc.Text = "Nombre de personal";
            this.CmbRfc.SelectedIndexChanged += new System.EventHandler(this.CmbRfc_SelectedIndexChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnCancelar.Image = global::Checador2.Properties.Resources.icons8_cancelar_50__1_;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(796, 295);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(117, 80);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnEliminar.Image = global::Checador2.Properties.Resources.icons8_eliminar_propiedad_50;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(929, 295);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(106, 80);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAct
            // 
            this.BtnAct.BackColor = System.Drawing.Color.Transparent;
            this.BtnAct.Enabled = false;
            this.BtnAct.FlatAppearance.BorderSize = 0;
            this.BtnAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAct.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnAct.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnAct.Image = global::Checador2.Properties.Resources.icons8_guardar_50;
            this.BtnAct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAct.Location = new System.Drawing.Point(516, 295);
            this.BtnAct.Name = "BtnAct";
            this.BtnAct.Size = new System.Drawing.Size(134, 80);
            this.BtnAct.TabIndex = 14;
            this.BtnAct.Text = "Actualizar";
            this.BtnAct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAct.UseVisualStyleBackColor = false;
            this.BtnAct.Visible = false;
            this.BtnAct.Click += new System.EventHandler(this.BtnAct_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnGuardar.Image = global::Checador2.Properties.Resources.icons8_guardar_50;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(666, 295);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(106, 80);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Datos
            // 
            this.Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Datos.ColumnHeadersHeight = 25;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Datos.Location = new System.Drawing.Point(59, 421);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(976, 205);
            this.Datos.TabIndex = 12;
            this.Datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellDoubleClick);
            // 
            // TxtHoraSalida
            // 
            this.TxtHoraSalida.Location = new System.Drawing.Point(246, 245);
            this.TxtHoraSalida.Name = "TxtHoraSalida";
            this.TxtHoraSalida.Size = new System.Drawing.Size(291, 20);
            this.TxtHoraSalida.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(54, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hora entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(580, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dia de la semana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(54, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(72, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registro  De Horarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(54, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // TxthoraEntrada
            // 
            this.TxthoraEntrada.Location = new System.Drawing.Point(246, 190);
            this.TxthoraEntrada.Name = "TxthoraEntrada";
            this.TxthoraEntrada.Size = new System.Drawing.Size(291, 20);
            this.TxthoraEntrada.TabIndex = 0;
            // 
            // HorariosModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HorariosModal";
            this.Text = "HorariosModal";
            this.Load += new System.EventHandler(this.HorariosModal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TxtDia;
        private System.Windows.Forms.ComboBox CmbRfc;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAct;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox TxtHoraSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxthoraEntrada;
        private System.Windows.Forms.TextBox TxtId;
    }
}