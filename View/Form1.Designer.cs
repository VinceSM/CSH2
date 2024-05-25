namespace Transporte2
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
            this.btnVerMotores = new System.Windows.Forms.Button();
            this.btnVerConductores = new System.Windows.Forms.Button();
            this.txtConductores = new System.Windows.Forms.TextBox();
            this.txtMotores = new System.Windows.Forms.TextBox();
            this.btnCrearVehiculo = new System.Windows.Forms.Button();
            this.lblMotor = new System.Windows.Forms.Label();
            this.chkBoxMotorC = new System.Windows.Forms.CheckBox();
            this.chkBoxMotorE = new System.Windows.Forms.CheckBox();
            this.lblConductor = new System.Windows.Forms.Label();
            this.chkBoxConductorH = new System.Windows.Forms.CheckBox();
            this.chkBoxConductorR = new System.Windows.Forms.CheckBox();
            this.txtVehiculoCreado = new System.Windows.Forms.TextBox();
            this.btnGuardarV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerMotores
            // 
            this.btnVerMotores.Location = new System.Drawing.Point(49, 28);
            this.btnVerMotores.Name = "btnVerMotores";
            this.btnVerMotores.Size = new System.Drawing.Size(161, 23);
            this.btnVerMotores.TabIndex = 0;
            this.btnVerMotores.Text = "VER MOTORES";
            this.btnVerMotores.UseVisualStyleBackColor = true;
            this.btnVerMotores.Click += new System.EventHandler(this.btnVerMotores_Click);
            // 
            // btnVerConductores
            // 
            this.btnVerConductores.Location = new System.Drawing.Point(455, 27);
            this.btnVerConductores.Name = "btnVerConductores";
            this.btnVerConductores.Size = new System.Drawing.Size(163, 23);
            this.btnVerConductores.TabIndex = 1;
            this.btnVerConductores.Text = "VER CONDUCTORES";
            this.btnVerConductores.UseVisualStyleBackColor = true;
            this.btnVerConductores.Click += new System.EventHandler(this.btnVerConductores_Click);
            // 
            // txtConductores
            // 
            this.txtConductores.Location = new System.Drawing.Point(455, 77);
            this.txtConductores.Multiline = true;
            this.txtConductores.Name = "txtConductores";
            this.txtConductores.ReadOnly = true;
            this.txtConductores.Size = new System.Drawing.Size(290, 73);
            this.txtConductores.TabIndex = 2;
            // 
            // txtMotores
            // 
            this.txtMotores.Location = new System.Drawing.Point(49, 77);
            this.txtMotores.Multiline = true;
            this.txtMotores.Name = "txtMotores";
            this.txtMotores.ReadOnly = true;
            this.txtMotores.Size = new System.Drawing.Size(274, 73);
            this.txtMotores.TabIndex = 3;
            // 
            // btnCrearVehiculo
            // 
            this.btnCrearVehiculo.Location = new System.Drawing.Point(49, 185);
            this.btnCrearVehiculo.Name = "btnCrearVehiculo";
            this.btnCrearVehiculo.Size = new System.Drawing.Size(161, 23);
            this.btnCrearVehiculo.TabIndex = 4;
            this.btnCrearVehiculo.Text = "CREAR VEHICULO";
            this.btnCrearVehiculo.UseVisualStyleBackColor = true;
            this.btnCrearVehiculo.Click += new System.EventHandler(this.btnCrearVehiculo_Click);
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Location = new System.Drawing.Point(49, 228);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(75, 13);
            this.lblMotor.TabIndex = 5;
            this.lblMotor.Text = "TIPO MOTOR";
            this.lblMotor.Visible = false;
            // 
            // chkBoxMotorC
            // 
            this.chkBoxMotorC.AutoSize = true;
            this.chkBoxMotorC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkBoxMotorC.Location = new System.Drawing.Point(175, 223);
            this.chkBoxMotorC.Name = "chkBoxMotorC";
            this.chkBoxMotorC.Size = new System.Drawing.Size(102, 17);
            this.chkBoxMotorC.TabIndex = 6;
            this.chkBoxMotorC.Text = "COMBUSTIBLE";
            this.chkBoxMotorC.UseVisualStyleBackColor = true;
            this.chkBoxMotorC.Visible = false;
            // 
            // chkBoxMotorE
            // 
            this.chkBoxMotorE.AutoSize = true;
            this.chkBoxMotorE.Location = new System.Drawing.Point(310, 223);
            this.chkBoxMotorE.Name = "chkBoxMotorE";
            this.chkBoxMotorE.Size = new System.Drawing.Size(86, 17);
            this.chkBoxMotorE.TabIndex = 7;
            this.chkBoxMotorE.Text = "ELECTRICO";
            this.chkBoxMotorE.UseVisualStyleBackColor = true;
            this.chkBoxMotorE.Visible = false;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(52, 266);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(104, 13);
            this.lblConductor.TabIndex = 8;
            this.lblConductor.Text = "TIPO CONDUCTOR";
            this.lblConductor.Visible = false;
            // 
            // chkBoxConductorH
            // 
            this.chkBoxConductorH.AutoSize = true;
            this.chkBoxConductorH.Location = new System.Drawing.Point(175, 261);
            this.chkBoxConductorH.Name = "chkBoxConductorH";
            this.chkBoxConductorH.Size = new System.Drawing.Size(74, 17);
            this.chkBoxConductorH.TabIndex = 9;
            this.chkBoxConductorH.Text = "HUMANO";
            this.chkBoxConductorH.UseVisualStyleBackColor = true;
            this.chkBoxConductorH.Visible = false;
            // 
            // chkBoxConductorR
            // 
            this.chkBoxConductorR.AutoSize = true;
            this.chkBoxConductorR.Location = new System.Drawing.Point(310, 261);
            this.chkBoxConductorR.Name = "chkBoxConductorR";
            this.chkBoxConductorR.Size = new System.Drawing.Size(64, 17);
            this.chkBoxConductorR.TabIndex = 10;
            this.chkBoxConductorR.Text = "ROBOT";
            this.chkBoxConductorR.UseVisualStyleBackColor = true;
            this.chkBoxConductorR.Visible = false;
            // 
            // txtVehiculoCreado
            // 
            this.txtVehiculoCreado.Location = new System.Drawing.Point(468, 187);
            this.txtVehiculoCreado.Multiline = true;
            this.txtVehiculoCreado.Name = "txtVehiculoCreado";
            this.txtVehiculoCreado.ReadOnly = true;
            this.txtVehiculoCreado.Size = new System.Drawing.Size(277, 189);
            this.txtVehiculoCreado.TabIndex = 11;
            this.txtVehiculoCreado.Visible = false;
            // 
            // btnGuardarV
            // 
            this.btnGuardarV.Location = new System.Drawing.Point(49, 314);
            this.btnGuardarV.Name = "btnGuardarV";
            this.btnGuardarV.Size = new System.Drawing.Size(161, 23);
            this.btnGuardarV.TabIndex = 12;
            this.btnGuardarV.Text = "GUARDAR ";
            this.btnGuardarV.UseVisualStyleBackColor = true;
            this.btnGuardarV.Visible = false;
            this.btnGuardarV.Click += new System.EventHandler(this.btnGuardarV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarV);
            this.Controls.Add(this.txtVehiculoCreado);
            this.Controls.Add(this.chkBoxConductorR);
            this.Controls.Add(this.chkBoxConductorH);
            this.Controls.Add(this.lblConductor);
            this.Controls.Add(this.chkBoxMotorE);
            this.Controls.Add(this.chkBoxMotorC);
            this.Controls.Add(this.lblMotor);
            this.Controls.Add(this.btnCrearVehiculo);
            this.Controls.Add(this.txtMotores);
            this.Controls.Add(this.txtConductores);
            this.Controls.Add(this.btnVerConductores);
            this.Controls.Add(this.btnVerMotores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerMotores;
        private System.Windows.Forms.Button btnVerConductores;
        private System.Windows.Forms.TextBox txtConductores;
        private System.Windows.Forms.TextBox txtMotores;
        private System.Windows.Forms.Button btnCrearVehiculo;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.CheckBox chkBoxMotorC;
        private System.Windows.Forms.CheckBox chkBoxMotorE;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.CheckBox chkBoxConductorH;
        private System.Windows.Forms.CheckBox chkBoxConductorR;
        private System.Windows.Forms.TextBox txtVehiculoCreado;
        private System.Windows.Forms.Button btnGuardarV;
    }
}

