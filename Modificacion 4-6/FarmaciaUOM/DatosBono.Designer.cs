namespace FarmaciaUOM
{
    partial class DatosBono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosBono));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_Precio_Total = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grv_Insumos_Detalles = new System.Windows.Forms.DataGridView();
            this.rEMNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMUNIDADESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REM_PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insumoListAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDAL1 = new FarmaciaUOM.CAD.FarmaciaDAL();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbo_Insumos = new System.Windows.Forms.ComboBox();
            this.insumocboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbo_cant2 = new System.Windows.Forms.TextBox();
            this.cbo_cant = new System.Windows.Forms.TextBox();
            this.cbo_precio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.insumoListAllBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_NHC = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Seccional = new System.Windows.Forms.Label();
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Apellido_Nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insumoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaciaDAL = new FarmaciaUOM.CAD.FarmaciaDAL();
            this.insumo_ListTableAdapter = new FarmaciaUOM.CAD.FarmaciaDALTableAdapters.Insumo_ListTableAdapter();
            this.insumo_List_AllTableAdapter = new FarmaciaUOM.CAD.FarmaciaDALTableAdapters.Insumo_List_AllTableAdapter();
            this.insumo_cboTableAdapter = new FarmaciaUOM.CAD.FarmaciaDALTableAdapters.Insumo_cboTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Insumos_Detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoListAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDAL1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insumocboBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insumoListAllBindingSource1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDAL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lbl_Precio_Total);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 43);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(438, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(501, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Contramovimiento";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(602, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Continuar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbl_Precio_Total
            // 
            this.lbl_Precio_Total.AutoSize = true;
            this.lbl_Precio_Total.Location = new System.Drawing.Point(3, 16);
            this.lbl_Precio_Total.Name = "lbl_Precio_Total";
            this.lbl_Precio_Total.Size = new System.Drawing.Size(93, 13);
            this.lbl_Precio_Total.TabIndex = 12;
            this.lbl_Precio_Total.Text = "Precio TOTAL ($):";
            this.lbl_Precio_Total.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.grv_Insumos_Detalles);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 307);
            this.panel2.TabIndex = 1;
            // 
            // grv_Insumos_Detalles
            // 
            this.grv_Insumos_Detalles.AllowUserToAddRows = false;
            this.grv_Insumos_Detalles.AllowUserToDeleteRows = false;
            this.grv_Insumos_Detalles.AllowUserToOrderColumns = true;
            this.grv_Insumos_Detalles.AutoGenerateColumns = false;
            this.grv_Insumos_Detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grv_Insumos_Detalles.BackgroundColor = System.Drawing.Color.White;
            this.grv_Insumos_Detalles.ColumnHeadersHeight = 30;
            this.grv_Insumos_Detalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEMNOMBREDataGridViewTextBoxColumn,
            this.rEMUNIDADESDataGridViewTextBoxColumn,
            this.rEMPRECIODataGridViewTextBoxColumn,
            this.REM_PRECIO});
            this.grv_Insumos_Detalles.DataSource = this.insumocboBindingSource;
            this.grv_Insumos_Detalles.Location = new System.Drawing.Point(21, 150);
            this.grv_Insumos_Detalles.Name = "grv_Insumos_Detalles";
            this.grv_Insumos_Detalles.RowHeadersWidth = 40;
            this.grv_Insumos_Detalles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grv_Insumos_Detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_Insumos_Detalles.Size = new System.Drawing.Size(625, 143);
            this.grv_Insumos_Detalles.TabIndex = 3;
            this.grv_Insumos_Detalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rEMNOMBREDataGridViewTextBoxColumn
            // 
            this.rEMNOMBREDataGridViewTextBoxColumn.DataPropertyName = "REM_NOMBRE";
            this.rEMNOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.rEMNOMBREDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.rEMNOMBREDataGridViewTextBoxColumn.Name = "rEMNOMBREDataGridViewTextBoxColumn";
            this.rEMNOMBREDataGridViewTextBoxColumn.Width = 69;
            // 
            // rEMUNIDADESDataGridViewTextBoxColumn
            // 
            this.rEMUNIDADESDataGridViewTextBoxColumn.DataPropertyName = "REM_UNIDADES";
            this.rEMUNIDADESDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.rEMUNIDADESDataGridViewTextBoxColumn.Name = "rEMUNIDADESDataGridViewTextBoxColumn";
            this.rEMUNIDADESDataGridViewTextBoxColumn.Width = 74;
            // 
            // rEMPRECIODataGridViewTextBoxColumn
            // 
            this.rEMPRECIODataGridViewTextBoxColumn.DataPropertyName = "REM_PRECIO";
            this.rEMPRECIODataGridViewTextBoxColumn.HeaderText = "Precio";
            this.rEMPRECIODataGridViewTextBoxColumn.Name = "rEMPRECIODataGridViewTextBoxColumn";
            this.rEMPRECIODataGridViewTextBoxColumn.Width = 62;
            // 
            // REM_PRECIO
            // 
            this.REM_PRECIO.DataPropertyName = "REM_PRECIO";
            this.REM_PRECIO.HeaderText = "Subtotal";
            this.REM_PRECIO.Name = "REM_PRECIO";
            this.REM_PRECIO.Width = 71;
            // 
            // insumoListAllBindingSource
            // 
            this.insumoListAllBindingSource.DataMember = "Insumo_List_All";
            this.insumoListAllBindingSource.DataSource = this.farmaciaDAL1;
            // 
            // farmaciaDAL1
            // 
            this.farmaciaDAL1.DataSetName = "FarmaciaDAL";
            this.farmaciaDAL1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Location = new System.Drawing.Point(17, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "Datos del Bono";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.cbo_Insumos);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(21, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 86);
            this.panel5.TabIndex = 1;
            // 
            // cbo_Insumos
            // 
            this.cbo_Insumos.DataSource = this.insumocboBindingSource;
            this.cbo_Insumos.DisplayMember = "REM_NOMBRE";
            this.cbo_Insumos.FormattingEnabled = true;
            this.cbo_Insumos.Location = new System.Drawing.Point(82, 30);
            this.cbo_Insumos.Name = "cbo_Insumos";
            this.cbo_Insumos.Size = new System.Drawing.Size(173, 21);
            this.cbo_Insumos.TabIndex = 7;
            this.cbo_Insumos.ValueMember = "REM_NOMBRE";
            // 
            // insumocboBindingSource
            // 
            this.insumocboBindingSource.DataMember = "Insumo_cbo";
            this.insumocboBindingSource.DataSource = this.farmaciaDAL1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Insumos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.cbo_cant2);
            this.panel3.Controls.Add(this.cbo_cant);
            this.panel3.Controls.Add(this.cbo_precio);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(350, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 86);
            this.panel3.TabIndex = 1;
            // 
            // cbo_cant2
            // 
            this.cbo_cant2.Location = new System.Drawing.Point(163, 39);
            this.cbo_cant2.Name = "cbo_cant2";
            this.cbo_cant2.Size = new System.Drawing.Size(50, 20);
            this.cbo_cant2.TabIndex = 15;
            // 
            // cbo_cant
            // 
            this.cbo_cant.Location = new System.Drawing.Point(81, 40);
            this.cbo_cant.Name = "cbo_cant";
            this.cbo_cant.Size = new System.Drawing.Size(56, 20);
            this.cbo_cant.TabIndex = 14;
            // 
            // cbo_precio
            // 
            this.cbo_precio.Location = new System.Drawing.Point(81, 12);
            this.cbo_precio.Name = "cbo_precio";
            this.cbo_precio.Size = new System.Drawing.Size(56, 20);
            this.cbo_precio.TabIndex = 8;
            this.cbo_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(125, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(81, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Stock actual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio ($)";
            // 
            // insumoListAllBindingSource1
            // 
            this.insumoListAllBindingSource1.DataMember = "Insumo_List_All";
            this.insumoListAllBindingSource1.DataSource = this.farmaciaDAL1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.lbl_id);
            this.panel4.Controls.Add(this.lbl_edad);
            this.panel4.Controls.Add(this.lbl_NHC);
            this.panel4.Controls.Add(this.lbl_Telefono);
            this.panel4.Controls.Add(this.lbl_Seccional);
            this.panel4.Controls.Add(this.lbl_Dni);
            this.panel4.Controls.Add(this.lbl_Apellido_Nombre);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(691, 58);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.ForeColor = System.Drawing.Color.Black;
            this.lbl_id.Location = new System.Drawing.Point(312, 22);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "id:";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.ForeColor = System.Drawing.Color.Black;
            this.lbl_edad.Location = new System.Drawing.Point(250, 3);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(38, 13);
            this.lbl_edad.TabIndex = 7;
            this.lbl_edad.Text = "Edad::";
            // 
            // lbl_NHC
            // 
            this.lbl_NHC.AutoSize = true;
            this.lbl_NHC.ForeColor = System.Drawing.Color.White;
            this.lbl_NHC.Location = new System.Drawing.Point(182, 22);
            this.lbl_NHC.Name = "lbl_NHC";
            this.lbl_NHC.Size = new System.Drawing.Size(33, 13);
            this.lbl_NHC.TabIndex = 6;
            this.lbl_NHC.Text = "NHC:";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.ForeColor = System.Drawing.Color.White;
            this.lbl_Telefono.Location = new System.Drawing.Point(219, 42);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_Telefono.TabIndex = 5;
            this.lbl_Telefono.Text = "Teléfono:";
            // 
            // lbl_Seccional
            // 
            this.lbl_Seccional.AutoSize = true;
            this.lbl_Seccional.ForeColor = System.Drawing.Color.White;
            this.lbl_Seccional.Location = new System.Drawing.Point(62, 42);
            this.lbl_Seccional.Name = "lbl_Seccional";
            this.lbl_Seccional.Size = new System.Drawing.Size(65, 13);
            this.lbl_Seccional.TabIndex = 3;
            this.lbl_Seccional.Text = "Seleccional:";
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.ForeColor = System.Drawing.Color.White;
            this.lbl_Dni.Location = new System.Drawing.Point(62, 22);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(28, 13);
            this.lbl_Dni.TabIndex = 2;
            this.lbl_Dni.Text = "DNi:";
            // 
            // lbl_Apellido_Nombre
            // 
            this.lbl_Apellido_Nombre.AutoSize = true;
            this.lbl_Apellido_Nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_Apellido_Nombre.Location = new System.Drawing.Point(62, 3);
            this.lbl_Apellido_Nombre.Name = "lbl_Apellido_Nombre";
            this.lbl_Apellido_Nombre.Size = new System.Drawing.Size(52, 13);
            this.lbl_Apellido_Nombre.TabIndex = 1;
            this.lbl_Apellido_Nombre.Text = "Paciente:";
            this.lbl_Apellido_Nombre.Click += new System.EventHandler(this.lbl_Apellido_Nombre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // insumoListBindingSource
            // 
            this.insumoListBindingSource.DataMember = "Insumo_List";
            this.insumoListBindingSource.DataSource = this.farmaciaDAL;
            // 
            // farmaciaDAL
            // 
            this.farmaciaDAL.DataSetName = "FarmaciaDAL";
            this.farmaciaDAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insumo_ListTableAdapter
            // 
            this.insumo_ListTableAdapter.ClearBeforeFill = true;
            // 
            // insumo_List_AllTableAdapter
            // 
            this.insumo_List_AllTableAdapter.ClearBeforeFill = true;
            // 
            // insumo_cboTableAdapter
            // 
            this.insumo_cboTableAdapter.ClearBeforeFill = true;
            // 
            // DatosBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 420);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosBono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia > Bono contribución";
            this.Load += new System.EventHandler(this.DatosBono_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Insumos_Detalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoListAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDAL1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insumocboBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.insumoListAllBindingSource1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaciaDAL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_Precio_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cbo_cant2;
        private System.Windows.Forms.TextBox cbo_cant;
        private System.Windows.Forms.TextBox cbo_precio;
        private System.Windows.Forms.DataGridView grv_Insumos_Detalles;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label lbl_Apellido_Nombre;
        public System.Windows.Forms.Label lbl_Dni;
        public System.Windows.Forms.Label lbl_Telefono;
        public System.Windows.Forms.Label lbl_Seccional;
        public System.Windows.Forms.Label lbl_NHC;
        public System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.ComboBox cbo_Insumos;
        private System.Windows.Forms.BindingSource insumoListBindingSource;
        private CAD.FarmaciaDAL farmaciaDAL;
        private CAD.FarmaciaDALTableAdapters.Insumo_ListTableAdapter insumo_ListTableAdapter;
        private CAD.FarmaciaDAL farmaciaDAL1;
        private System.Windows.Forms.BindingSource insumoListAllBindingSource;
        private CAD.FarmaciaDALTableAdapters.Insumo_List_AllTableAdapter insumo_List_AllTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMUNIDADESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn REM_PRECIO;
        public System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.BindingSource insumoListAllBindingSource1;
        private System.Windows.Forms.BindingSource insumocboBindingSource;
        private CAD.FarmaciaDALTableAdapters.Insumo_cboTableAdapter insumo_cboTableAdapter;
    }
}