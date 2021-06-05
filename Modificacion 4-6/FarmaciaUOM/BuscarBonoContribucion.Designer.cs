namespace FarmaciaUOM
{
    partial class BuscarBonoContribucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarBonoContribucion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grv_Bono_Contrib = new System.Windows.Forms.DataGridView();
            this.fARPEDIDOSPUBLICOCABBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDAL = new FarmaciaUOM.CAD.FarmaciaDAL();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Busq_Bono = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.fAR_PEDIDOS_PUBLICO_CABTableAdapter = new FarmaciaUOM.CAD.FarmaciaDALTableAdapters.FAR_PEDIDOS_PUBLICO_CABTableAdapter();
            this.pEDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDNOMBRECLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDFECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEDUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Bono_Contrib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARPEDIDOSPUBLICOCABBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDAL)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grv_Bono_Contrib);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 413);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar Bono Contribución";
            // 
            // grv_Bono_Contrib
            // 
            this.grv_Bono_Contrib.AllowUserToAddRows = false;
            this.grv_Bono_Contrib.AllowUserToDeleteRows = false;
            this.grv_Bono_Contrib.AutoGenerateColumns = false;
            this.grv_Bono_Contrib.BackgroundColor = System.Drawing.Color.White;
            this.grv_Bono_Contrib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Bono_Contrib.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pEDIDDataGridViewTextBoxColumn,
            this.pEDNOMBRECLIDataGridViewTextBoxColumn,
            this.nHCDataGridViewTextBoxColumn,
            this.pEDFECHADataGridViewTextBoxColumn,
            this.pEDUSUARIODataGridViewTextBoxColumn});
            this.grv_Bono_Contrib.DataSource = this.fARPEDIDOSPUBLICOCABBindingSource;
            this.grv_Bono_Contrib.Location = new System.Drawing.Point(23, 129);
            this.grv_Bono_Contrib.Name = "grv_Bono_Contrib";
            this.grv_Bono_Contrib.ReadOnly = true;
            this.grv_Bono_Contrib.RowHeadersVisible = false;
            this.grv_Bono_Contrib.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_Bono_Contrib.Size = new System.Drawing.Size(654, 281);
            this.grv_Bono_Contrib.TabIndex = 2;
            this.grv_Bono_Contrib.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_Bono_Contrib_CellContentClick);
            // 
            // fARPEDIDOSPUBLICOCABBindingSource
            // 
            this.fARPEDIDOSPUBLICOCABBindingSource.DataMember = "FAR_PEDIDOS_PUBLICO_CAB";
            this.fARPEDIDOSPUBLICOCABBindingSource.DataSource = this.farmaciaDAL;
            // 
            // farmaciaDAL
            // 
            this.farmaciaDAL.DataSetName = "FarmaciaDAL";
            this.farmaciaDAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_Busq_Bono);
            this.panel4.Location = new System.Drawing.Point(23, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 65);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro. Bono:";
            // 
            // txt_Busq_Bono
            // 
            this.txt_Busq_Bono.Location = new System.Drawing.Point(87, 12);
            this.txt_Busq_Bono.Name = "txt_Busq_Bono";
            this.txt_Busq_Bono.Size = new System.Drawing.Size(134, 20);
            this.txt_Busq_Bono.TabIndex = 0;
            this.txt_Busq_Bono.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(365, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 65);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(63, 39);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desde:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_buscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 30);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(555, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Location = new System.Drawing.Point(636, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 0;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // fAR_PEDIDOS_PUBLICO_CABTableAdapter
            // 
            this.fAR_PEDIDOS_PUBLICO_CABTableAdapter.ClearBeforeFill = true;
            // 
            // pEDIDDataGridViewTextBoxColumn
            // 
            this.pEDIDDataGridViewTextBoxColumn.DataPropertyName = "PED_ID";
            this.pEDIDDataGridViewTextBoxColumn.HeaderText = "Bono";
            this.pEDIDDataGridViewTextBoxColumn.Name = "pEDIDDataGridViewTextBoxColumn";
            this.pEDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pEDNOMBRECLIDataGridViewTextBoxColumn
            // 
            this.pEDNOMBRECLIDataGridViewTextBoxColumn.DataPropertyName = "PED_NOMBRE_CLI";
            this.pEDNOMBRECLIDataGridViewTextBoxColumn.HeaderText = "Paciente";
            this.pEDNOMBRECLIDataGridViewTextBoxColumn.Name = "pEDNOMBRECLIDataGridViewTextBoxColumn";
            this.pEDNOMBRECLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.pEDNOMBRECLIDataGridViewTextBoxColumn.Width = 200;
            // 
            // nHCDataGridViewTextBoxColumn
            // 
            this.nHCDataGridViewTextBoxColumn.DataPropertyName = "NHC";
            this.nHCDataGridViewTextBoxColumn.HeaderText = "NHC";
            this.nHCDataGridViewTextBoxColumn.Name = "nHCDataGridViewTextBoxColumn";
            this.nHCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pEDFECHADataGridViewTextBoxColumn
            // 
            this.pEDFECHADataGridViewTextBoxColumn.DataPropertyName = "PED_FECHA";
            this.pEDFECHADataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.pEDFECHADataGridViewTextBoxColumn.Name = "pEDFECHADataGridViewTextBoxColumn";
            this.pEDFECHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pEDUSUARIODataGridViewTextBoxColumn
            // 
            this.pEDUSUARIODataGridViewTextBoxColumn.DataPropertyName = "PED_USUARIO";
            this.pEDUSUARIODataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.pEDUSUARIODataGridViewTextBoxColumn.Name = "pEDUSUARIODataGridViewTextBoxColumn";
            this.pEDUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.pEDUSUARIODataGridViewTextBoxColumn.Width = 150;
            // 
            // BuscarBonoContribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarBonoContribucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia > Buscar Bono contribución";
            this.Load += new System.EventHandler(this.BuscarBonoContribucion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Bono_Contrib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fARPEDIDOSPUBLICOCABBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDAL)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grv_Bono_Contrib;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Busq_Bono;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private CAD.FarmaciaDAL farmaciaDAL;
        private System.Windows.Forms.BindingSource fARPEDIDOSPUBLICOCABBindingSource;
        private CAD.FarmaciaDALTableAdapters.FAR_PEDIDOS_PUBLICO_CABTableAdapter fAR_PEDIDOS_PUBLICO_CABTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDNOMBRECLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nHCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDFECHADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEDUSUARIODataGridViewTextBoxColumn;
    }
}