namespace ViewHotel
{
    partial class UpdateReservation
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.cboHabitacion = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblCLiente = new System.Windows.Forms.Label();
            this.lblReservas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(476, 135);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 42);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(371, 120);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(84, 73);
            this.btnReservar.TabIndex = 42;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(136, 224);
            this.dtpSalida.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpSalida.TabIndex = 39;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(136, 190);
            this.dtpIngreso.MinDate = new System.DateTime(2019, 11, 25, 0, 0, 0, 0);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpIngreso.TabIndex = 40;
            this.dtpIngreso.Value = new System.DateTime(2019, 12, 5, 11, 5, 16, 0);
            // 
            // cboHotel
            // 
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Location = new System.Drawing.Point(136, 124);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(121, 21);
            this.cboHotel.TabIndex = 36;
            // 
            // cboHabitacion
            // 
            this.cboHabitacion.FormattingEnabled = true;
            this.cboHabitacion.Location = new System.Drawing.Point(136, 154);
            this.cboHabitacion.Name = "cboHabitacion";
            this.cboHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cboHabitacion.TabIndex = 37;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(136, 91);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 38;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(28, 224);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(72, 13);
            this.lblSalida.TabIndex = 31;
            this.lblSalida.Text = "Fecha Salida:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(22, 190);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(78, 13);
            this.lblIngreso.TabIndex = 32;
            this.lblIngreso.Text = "Fecha Ingreso:";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(65, 126);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(35, 13);
            this.lblHotel.TabIndex = 33;
            this.lblHotel.Text = "Hotel:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(39, 162);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(61, 13);
            this.lblHabitacion.TabIndex = 34;
            this.lblHabitacion.Text = "Habitacion:";
            // 
            // lblCLiente
            // 
            this.lblCLiente.AutoSize = true;
            this.lblCLiente.Location = new System.Drawing.Point(58, 100);
            this.lblCLiente.Name = "lblCLiente";
            this.lblCLiente.Size = new System.Drawing.Size(42, 13);
            this.lblCLiente.TabIndex = 35;
            this.lblCLiente.Text = "Cliente:";
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.Location = new System.Drawing.Point(45, 31);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(237, 29);
            this.lblReservas.TabIndex = 43;
            this.lblReservas.Text = "Actualiar Reservas ";
            this.lblReservas.Click += new System.EventHandler(this.lblReservas_Click);
            // 
            // UpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 282);
            this.Controls.Add(this.lblReservas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.cboHotel);
            this.Controls.Add(this.cboHabitacion);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.lblCLiente);
            this.Name = "UpdateReservation";
            this.Text = "UpdateReservation";
            this.Load += new System.EventHandler(this.UpdateReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.ComboBox cboHotel;
        private System.Windows.Forms.ComboBox cboHabitacion;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblCLiente;
        private System.Windows.Forms.Label lblReservas;
    }
}