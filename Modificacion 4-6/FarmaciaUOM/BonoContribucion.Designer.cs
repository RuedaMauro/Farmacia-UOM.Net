namespace FarmaciaUOM
{
    partial class BonoContribucion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BonoContribucion));
            this.cbo_Tipo_Doc = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genteDAL = new FarmaciaUOM.CAD.GenteDAL();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_NHC = new System.Windows.Forms.TextBox();
            this.txt_AyN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgv_Pacientes = new System.Windows.Forms.DataGridView();
            this.NHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Buscar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tipo_DocumentoTableAdapter = new FarmaciaUOM.CAD.GenteDALTableAdapters.Tipo_DocumentoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_paciente_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genteDAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).BeginInit();
            this.panel_Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo_Tipo_Doc
            // 
            this.cbo_Tipo_Doc.DataSource = this.tipoDocumentoBindingSource;
            this.cbo_Tipo_Doc.DisplayMember = "descri";
            this.cbo_Tipo_Doc.FormattingEnabled = true;
            this.cbo_Tipo_Doc.Location = new System.Drawing.Point(173, 51);
            this.cbo_Tipo_Doc.Name = "cbo_Tipo_Doc";
            this.cbo_Tipo_Doc.Size = new System.Drawing.Size(165, 21);
            this.cbo_Tipo_Doc.TabIndex = 0;
            this.cbo_Tipo_Doc.ValueMember = "cod";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "Tipo_Documento";
            this.tipoDocumentoBindingSource.DataSource = this.genteDAL;
            // 
            // genteDAL
            // 
            this.genteDAL.DataSetName = "GenteDAL";
            this.genteDAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(173, 88);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(165, 20);
            this.txt_dni.TabIndex = 2;
            // 
            // txt_NHC
            // 
            this.txt_NHC.Location = new System.Drawing.Point(175, 125);
            this.txt_NHC.Name = "txt_NHC";
            this.txt_NHC.Size = new System.Drawing.Size(165, 20);
            this.txt_NHC.TabIndex = 3;
            // 
            // txt_AyN
            // 
            this.txt_AyN.Location = new System.Drawing.Point(175, 166);
            this.txt_AyN.Name = "txt_AyN";
            this.txt_AyN.Size = new System.Drawing.Size(165, 20);
            this.txt_AyN.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NHC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datos del Paciente";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(346, 166);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(53, 20);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgv_Pacientes
            // 
            this.dgv_Pacientes.AllowUserToAddRows = false;
            this.dgv_Pacientes.AllowUserToDeleteRows = false;
            this.dgv_Pacientes.AutoGenerateColumns = false;
            this.dgv_Pacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NHC,
            this.Paciente,
            this.tipo_doc,
            this.Column4,
            this.Telefono,
            this.PacienteID,
            this.codDataGridViewTextBoxColumn,
            this.descriDataGridViewTextBoxColumn});
            this.dgv_Pacientes.DataSource = this.tipoDocumentoBindingSource;
            this.dgv_Pacientes.Location = new System.Drawing.Point(9, 210);
            this.dgv_Pacientes.Name = "dgv_Pacientes";
            this.dgv_Pacientes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Pacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Pacientes.RowHeadersVisible = false;
            this.dgv_Pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Pacientes.Size = new System.Drawing.Size(505, 171);
            this.dgv_Pacientes.TabIndex = 11;
            this.dgv_Pacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pacientes_CellClick);
            this.dgv_Pacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pacientes_CellContentClick);
            // 
            // NHC
            // 
            this.NHC.DataPropertyName = "HC_UOM";
            this.NHC.HeaderText = "NHC";
            this.NHC.Name = "NHC";
            this.NHC.ReadOnly = true;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Paciente";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            // 
            // tipo_doc
            // 
            this.tipo_doc.DataPropertyName = "Tipo_documento";
            this.tipo_doc.HeaderText = "Tipo de Doc";
            this.tipo_doc.Name = "tipo_doc";
            this.tipo_doc.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "documento_real";
            this.Column4.HeaderText = "Documento";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // PacienteID
            // 
            this.PacienteID.DataPropertyName = "documento";
            this.PacienteID.HeaderText = "paciente_Id";
            this.PacienteID.Name = "PacienteID";
            this.PacienteID.ReadOnly = true;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "cod";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriDataGridViewTextBoxColumn
            // 
            this.descriDataGridViewTextBoxColumn.DataPropertyName = "descri";
            this.descriDataGridViewTextBoxColumn.HeaderText = "descri";
            this.descriDataGridViewTextBoxColumn.Name = "descriDataGridViewTextBoxColumn";
            this.descriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel_Buscar
            // 
            this.panel_Buscar.BackColor = System.Drawing.Color.White;
            this.panel_Buscar.Controls.Add(this.label6);
            this.panel_Buscar.Location = new System.Drawing.Point(9, 210);
            this.panel_Buscar.Name = "panel_Buscar";
            this.panel_Buscar.Size = new System.Drawing.Size(505, 171);
            this.panel_Buscar.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 31);
            this.label6.TabIndex = 0;
            // 
            // tipo_DocumentoTableAdapter
            // 
            this.tipo_DocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(439, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_paciente_id
            // 
            this.txt_paciente_id.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_paciente_id.Location = new System.Drawing.Point(202, 14);
            this.txt_paciente_id.Name = "txt_paciente_id";
            this.txt_paciente_id.Size = new System.Drawing.Size(100, 20);
            this.txt_paciente_id.TabIndex = 14;
            this.txt_paciente_id.Visible = false;
            // 
            // BonoContribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 417);
            this.Controls.Add(this.txt_paciente_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_Buscar);
            this.Controls.Add(this.dgv_Pacientes);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_AyN);
            this.Controls.Add(this.txt_NHC);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Tipo_Doc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BonoContribucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de operación > Bono contribución";
            this.Load += new System.EventHandler(this.BonoContribucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genteDAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pacientes)).EndInit();
            this.panel_Buscar.ResumeLayout(false);
            this.panel_Buscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Tipo_Doc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_NHC;
        private System.Windows.Forms.TextBox txt_AyN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_Pacientes;
        private System.Windows.Forms.Panel panel_Buscar;
        private System.Windows.Forms.Label label6;
        private CAD.GenteDAL genteDAL;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private CAD.GenteDALTableAdapters.Tipo_DocumentoTableAdapter tipo_DocumentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_paciente_id;
    }
}