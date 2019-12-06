namespace ViewHotel
{
    partial class Reservation
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
            this.dtgReservas = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblReservas = new System.Windows.Forms.Label();
            this.lblCLiente = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboHabitacion = new System.Windows.Forms.ComboBox();
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgReservas
            // 
            this.dtgReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.hotelName,
            this.roomName,
            this.admissionDate,
            this.departureDate,
            this.customerId,
            this.hotelId,
            this.roomId});
            this.dtgReservas.Location = new System.Drawing.Point(45, 262);
            this.dtgReservas.Name = "dtgReservas";
            this.dtgReservas.Size = new System.Drawing.Size(552, 163);
            this.dtgReservas.TabIndex = 24;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Nombre";
            this.customerName.Name = "customerName";
            // 
            // hotelName
            // 
            this.hotelName.DataPropertyName = "hotelName";
            this.hotelName.HeaderText = "Hotel";
            this.hotelName.Name = "hotelName";
            // 
            // roomName
            // 
            this.roomName.DataPropertyName = "roomName";
            this.roomName.HeaderText = "Tipo Habitación";
            this.roomName.Name = "roomName";
            // 
            // admissionDate
            // 
            this.admissionDate.DataPropertyName = "admissionDate";
            this.admissionDate.HeaderText = "Ingreso";
            this.admissionDate.Name = "admissionDate";
            // 
            // departureDate
            // 
            this.departureDate.DataPropertyName = "departureDate";
            this.departureDate.HeaderText = "Salida";
            this.departureDate.Name = "departureDate";
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "customerId";
            this.customerId.Name = "customerId";
            this.customerId.Visible = false;
            // 
            // hotelId
            // 
            this.hotelId.DataPropertyName = "hotelId";
            this.hotelId.HeaderText = "hotelId";
            this.hotelId.Name = "hotelId";
            this.hotelId.Visible = false;
            // 
            // roomId
            // 
            this.roomId.DataPropertyName = "roomId";
            this.roomId.HeaderText = "roomId";
            this.roomId.Name = "roomId";
            this.roomId.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(427, 472);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(508, 472);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservas.Location = new System.Drawing.Point(40, 27);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(253, 29);
            this.lblReservas.TabIndex = 26;
            this.lblReservas.Text = "Reservas Habitacion";
            // 
            // lblCLiente
            // 
            this.lblCLiente.AutoSize = true;
            this.lblCLiente.Location = new System.Drawing.Point(90, 85);
            this.lblCLiente.Name = "lblCLiente";
            this.lblCLiente.Size = new System.Drawing.Size(42, 13);
            this.lblCLiente.TabIndex = 27;
            this.lblCLiente.Text = "Cliente:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(71, 147);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(61, 13);
            this.lblHabitacion.TabIndex = 27;
            this.lblHabitacion.Text = "Habitacion:";
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(97, 111);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(35, 13);
            this.lblHotel.TabIndex = 27;
            this.lblHotel.Text = "Hotel:";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(54, 175);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(78, 13);
            this.lblIngreso.TabIndex = 27;
            this.lblIngreso.Text = "Fecha Ingreso:";
            this.lblIngreso.Click += new System.EventHandler(this.lblIngreso_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(60, 209);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(72, 13);
            this.lblSalida.TabIndex = 27;
            this.lblSalida.Text = "Fecha Salida:";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(168, 76);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(121, 21);
            this.cboCliente.TabIndex = 28;
            // 
            // cboHabitacion
            // 
            this.cboHabitacion.FormattingEnabled = true;
            this.cboHabitacion.Location = new System.Drawing.Point(168, 139);
            this.cboHabitacion.Name = "cboHabitacion";
            this.cboHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cboHabitacion.TabIndex = 28;
            // 
            // cboHotel
            // 
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Location = new System.Drawing.Point(168, 109);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(121, 21);
            this.cboHotel.TabIndex = 28;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(168, 175);
            this.dtpIngreso.MinDate = new System.DateTime(2019, 11, 25, 0, 0, 0, 0);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpIngreso.TabIndex = 29;
            this.dtpIngreso.Value = new System.DateTime(2019, 12, 5, 11, 5, 16, 0);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(168, 209);
            this.dtpSalida.MinDate = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpSalida.TabIndex = 29;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(400, 105);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(84, 73);
            this.btnReservar.TabIndex = 30;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(508, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 42);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 537);
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
            this.Controls.Add(this.lblReservas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dtgReservas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgReservas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblReservas;
        private System.Windows.Forms.Label lblCLiente;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboHabitacion;
        private System.Windows.Forms.ComboBox cboHotel;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomId;
    }
}