namespace ViewHotel
{
    partial class RegisterCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.cbDocumentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgwClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tipo Documento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "N° Documento:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(111, 115);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(176, 20);
            this.txtSurName.TabIndex = 2;
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.Location = new System.Drawing.Point(111, 179);
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(176, 20);
            this.txtDocumentNumber.TabIndex = 2;
            // 
            // cbDocumentType
            // 
            this.cbDocumentType.FormattingEnabled = true;
            this.cbDocumentType.Items.AddRange(new object[] {
            "DNI",
            "CE",
            "PASAPORTE"});
            this.cbDocumentType.Location = new System.Drawing.Point(111, 150);
            this.cbDocumentType.Margin = new System.Windows.Forms.Padding(2);
            this.cbDocumentType.Name = "cbDocumentType";
            this.cbDocumentType.Size = new System.Drawing.Size(176, 21);
            this.cbDocumentType.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "N° Celular :";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(111, 206);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(176, 20);
            this.txtMobile.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(354, 105);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 103);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(457, 131);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 56);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgwClientes
            // 
            this.dgwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name1,
            this.SurName,
            this.Phone,
            this.DocumentType,
            this.DocumentNumber});
            this.dgwClientes.Location = new System.Drawing.Point(41, 240);
            this.dgwClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgwClientes.Name = "dgwClientes";
            this.dgwClientes.RowTemplate.Height = 24;
            this.dgwClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwClientes.Size = new System.Drawing.Size(547, 196);
            this.dgwClientes.TabIndex = 8;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "Name";
            this.Name1.HeaderText = "Nombre";
            this.Name1.Name = "Name1";
            // 
            // SurName
            // 
            this.SurName.DataPropertyName = "SurName";
            this.SurName.HeaderText = "Apellido";
            this.SurName.Name = "SurName";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Celular";
            this.Phone.Name = "Phone";
            // 
            // DocumentType
            // 
            this.DocumentType.DataPropertyName = "DocumentType";
            this.DocumentType.HeaderText = "Tipo Doc";
            this.DocumentType.Name = "DocumentType";
            // 
            // DocumentNumber
            // 
            this.DocumentNumber.DataPropertyName = "DocumentNumber";
            this.DocumentNumber.HeaderText = "N° Documento";
            this.DocumentNumber.Name = "DocumentNumber";
            // 
            // RegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwClientes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDocumentType);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterCustomer";
            this.Text = "RegisterCustomer";
            this.Load += new System.EventHandler(this.RegisterCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtDocumentNumber;
        private System.Windows.Forms.ComboBox cbDocumentType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgwClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentNumber;
    }
}