namespace FarmaciaUOM
{
    partial class Buscar_Bono_Imp
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet5 = new FarmaciaUOM.DataSet5();
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CentroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new FarmaciaUOM.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLETableAdapter = new FarmaciaUOM.DataSet5TableAdapters.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLETableAdapter();
            this.DataSet4 = new FarmaciaUOM.DataSet4();
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter = new FarmaciaUOM.DataSet5TableAdapters.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter();
            this.CentroTableAdapter = new FarmaciaUOM.DataSet2TableAdapters.CentroTableAdapter();
            this.dataSet3 = new FarmaciaUOM.DataSet3();
            this.h2USUARIOSBYIDLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.h2_USUARIOS_BY_ID_LISTTableAdapter = new FarmaciaUOM.DataSet3TableAdapters.H2_USUARIOS_BY_ID_LISTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2USUARIOSBYIDLISTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABBindingSource
            // 
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABBindingSource.DataMember = "H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CAB";
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABBindingSource.DataSource = this.DataSet5;
            // 
            // DataSet5
            // 
            this.DataSet5.DataSetName = "DataSet5";
            this.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLEBindingSource
            // 
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLEBindingSource.DataMember = "H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLE";
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLEBindingSource.DataSource = this.DataSet5;
            // 
            // CentroBindingSource
            // 
            this.CentroBindingSource.DataMember = "Centro";
            this.CentroBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLEBindingSource;
            reportDataSource3.Name = "DataSet4";
            reportDataSource3.Value = this.CentroBindingSource;
            reportDataSource4.Name = "DataSet3";
            reportDataSource4.Value = this.h2USUARIOSBYIDLISTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FarmaciaUOM.Imp_Bono_Contribucion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(847, 496);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLETableAdapter
            // 
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLETableAdapter.ClearBeforeFill = true;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter
            // 
            this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter.ClearBeforeFill = true;
            // 
            // CentroTableAdapter
            // 
            this.CentroTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // h2USUARIOSBYIDLISTBindingSource
            // 
            this.h2USUARIOSBYIDLISTBindingSource.DataMember = "H2_USUARIOS_BY_ID_LIST";
            this.h2USUARIOSBYIDLISTBindingSource.DataSource = this.dataSet3;
            // 
            // h2_USUARIOS_BY_ID_LISTTableAdapter
            // 
            this.h2_USUARIOS_BY_ID_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // Buscar_Bono_Imp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 496);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Buscar_Bono_Imp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar_Bono_Imp";
            this.Load += new System.EventHandler(this.Buscar_Bono_Imp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CentroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2USUARIOSBYIDLISTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet4 DataSet4;
        private System.Windows.Forms.BindingSource H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLEBindingSource;
        private DataSet5 DataSet5;
        private DataSet5TableAdapters.H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLETableAdapter H2_FAR_PEDIDOS_PUBLICO_SELECT_DETALLETableAdapter;
        private System.Windows.Forms.BindingSource H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABBindingSource;
        private System.Windows.Forms.BindingSource CentroBindingSource;
        private DataSet2 DataSet2;
        private DataSet5TableAdapters.H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter H2_FAR_PEDIDOS_PUBLICO_SELECT_PRINT_CABTableAdapter;
        private DataSet2TableAdapters.CentroTableAdapter CentroTableAdapter;
        private System.Windows.Forms.BindingSource h2USUARIOSBYIDLISTBindingSource;
        private DataSet3 dataSet3;
        private DataSet3TableAdapters.H2_USUARIOS_BY_ID_LISTTableAdapter h2_USUARIOS_BY_ID_LISTTableAdapter;
    }
}