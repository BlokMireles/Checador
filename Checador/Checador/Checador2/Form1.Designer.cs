namespace Checador2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelRegistros = new System.Windows.Forms.Panel();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.BtnTp = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new GradientPanelDemo.GradientPanel();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hora
            // 
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 42);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Checador TecMm";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.PanelRegistros);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.gradientPanel2);
            this.panel2.Controls.Add(this.BtnCheck);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 1366);
            this.panel2.TabIndex = 14;
            // 
            // PanelRegistros
            // 
            this.PanelRegistros.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelRegistros.Controls.Add(this.BtnPersonal);
            this.PanelRegistros.Controls.Add(this.BtnTp);
            this.PanelRegistros.Location = new System.Drawing.Point(31, 400);
            this.PanelRegistros.Name = "PanelRegistros";
            this.PanelRegistros.Size = new System.Drawing.Size(210, 166);
            this.PanelRegistros.TabIndex = 0;
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.Image = global::Checador2.Properties.Resources.icons8_marque_todas_las_50;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.Location = new System.Drawing.Point(3, 91);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Size = new System.Drawing.Size(204, 71);
            this.BtnPersonal.TabIndex = 14;
            this.BtnPersonal.Text = "Personal";
            this.BtnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // BtnTp
            // 
            this.BtnTp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnTp.FlatAppearance.BorderSize = 0;
            this.BtnTp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnTp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnTp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTp.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTp.Image = global::Checador2.Properties.Resources.icons8_marque_todas_las_50;
            this.BtnTp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTp.Location = new System.Drawing.Point(0, 3);
            this.BtnTp.Name = "BtnTp";
            this.BtnTp.Size = new System.Drawing.Size(207, 71);
            this.BtnTp.TabIndex = 13;
            this.BtnTp.Text = "Tipo Persona";
            this.BtnTp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTp.UseVisualStyleBackColor = true;
            this.BtnTp.Click += new System.EventHandler(this.BtnTp_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(1, 329);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 71);
            this.panel5.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Checador2.Properties.Resources.icons8_marque_todas_las_50;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(31, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 71);
            this.button4.TabIndex = 12;
            this.button4.Text = "Registrar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 71);
            this.panel3.TabIndex = 0;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.Empty;
            this.gradientPanel2.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel2.Location = new System.Drawing.Point(245, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1081, 505);
            this.gradientPanel2.TabIndex = 15;
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCheck.FlatAppearance.BorderSize = 0;
            this.BtnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheck.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.Image = global::Checador2.Properties.Resources.icons8_marque_todas_las_50;
            this.BtnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheck.Location = new System.Drawing.Point(34, 220);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(210, 71);
            this.BtnCheck.TabIndex = 11;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Checador2.Properties.Resources.LOGOS_UA_TJMM_new_02;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 172);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Location = new System.Drawing.Point(246, 42);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1119, 768);
            this.PanelContenedor.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.PanelRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private GradientPanelDemo.GradientPanel gradientPanel2;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel PanelRegistros;
        private System.Windows.Forms.Button BtnPersonal;
        private System.Windows.Forms.Button BtnTp;
    }
}

