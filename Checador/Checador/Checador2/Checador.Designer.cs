namespace Checador2
{
    partial class Checador
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
            this.components = new System.ComponentModel.Container();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.gradientPanel1 = new GradientPanelDemo.GradientPanel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRFC = new System.Windows.Forms.TextBox();
            this.BtnChe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hora
            // 
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.BtnChe);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.LblFecha);
            this.gradientPanel1.Controls.Add(this.LblHora);
            this.gradientPanel1.Controls.Add(this.groupBox1);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.TxtRFC);
            this.gradientPanel1.Location = new System.Drawing.Point(-1, -1);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(953, 561);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold);
            this.LblFecha.ForeColor = System.Drawing.Color.DarkRed;
            this.LblFecha.Location = new System.Drawing.Point(670, 177);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(123, 45);
            this.LblFecha.TabIndex = 15;
            this.LblFecha.Text = "Fecha";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.Transparent;
            this.LblHora.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.DarkRed;
            this.LblHora.Location = new System.Drawing.Point(670, 26);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(104, 45);
            this.LblHora.TabIndex = 18;
            this.LblHora.Text = "Hora";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(13, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 156);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensajes";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(746, 128);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(111, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Numero Control";
            // 
            // TxtRFC
            // 
            this.TxtRFC.Location = new System.Drawing.Point(309, 277);
            this.TxtRFC.Name = "TxtRFC";
            this.TxtRFC.Size = new System.Drawing.Size(239, 20);
            this.TxtRFC.TabIndex = 14;
            // 
            // BtnChe
            // 
            this.BtnChe.BackColor = System.Drawing.Color.Transparent;
            this.BtnChe.FlatAppearance.BorderSize = 0;
            this.BtnChe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChe.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnChe.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnChe.Image = global::Checador2.Properties.Resources.icons8_marque_todas_las_50__1_;
            this.BtnChe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnChe.Location = new System.Drawing.Point(659, 239);
            this.BtnChe.Name = "BtnChe";
            this.BtnChe.Size = new System.Drawing.Size(134, 80);
            this.BtnChe.TabIndex = 6;
            this.BtnChe.Text = "Checar";
            this.BtnChe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnChe.UseVisualStyleBackColor = false;
            this.BtnChe.Click += new System.EventHandler(this.BtnChe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Checador2.Properties.Resources.Usuario_Icono;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(309, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 191);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Checador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 560);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Checador";
            this.Text = "Checador";
            this.Load += new System.EventHandler(this.Checador_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanelDemo.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRFC;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnChe;
    }
}