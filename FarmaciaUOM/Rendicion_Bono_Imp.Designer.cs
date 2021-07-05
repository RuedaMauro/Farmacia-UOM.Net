namespace FarmaciaUOM
{
    partial class Rendicion_Bono_Imp
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
            this.H2_PEDIDOS_PUBLICO_RENDICIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new FarmaciaUOM.DataSet1();
            this.centroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new FarmaciaUOM.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.H2_PEDIDOS_PUBLICO_RENDICIONTableAdapter = new FarmaciaUOM.DataSet1TableAdapters.H2_PEDIDOS_PUBLICO_RENDICIONTableAdapter();
            this.centroTableAdapter = new FarmaciaUOM.DataSet2TableAdapters.CentroTableAdapter();
            this.h2USUARIOSBYIDLISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new FarmaciaUOM.DataSet3();
            this.h2_USUARIOS_BY_ID_LISTTableAdapter = new FarmaciaUOM.DataSet3TableAdapters.H2_USUARIOS_BY_ID_LISTTableAdapter();
            this.dataSet4 = new FarmaciaUOM.DataSet4();
            this.h2USUARIOSBYIDLISTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.h2_USUARIOS_BY_ID_LISTTableAdapter1 = new FarmaciaUOM.DataSet4TableAdapters.H2_USUARIOS_BY_ID_LISTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.H2_PEDIDOS_PUBLICO_RENDICIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2USUARIOSBYIDLISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2USUARIOSBYIDLISTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // H2_PEDIDOS_PUBLICO_RENDICIONBindingSource
            // 
            this.H2_PEDIDOS_PUBLICO_RENDICIONBindingSource.DataMember = "H2_PEDIDOS_PUBLICO_RENDICION";
            this.H2_PEDIDOS_PUBLICO_RENDICIONBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // centroBindingSource
            // 
            this.centroBindingSource.DataMember = "Centro";
            this.centroBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.H2_PEDIDOS_PUBLICO_RENDICIONBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.centroBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.h2USUARIOSBYIDLISTBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.h2USUARIOSBYIDLISTBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FarmaciaUOM.Reporte_Rendicion_Bono_Imp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(695, 405);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // H2_PEDIDOS_PUBLICO_RENDICIONTableAdapter
            // 
            this.H2_PEDIDOS_PUBLICO_RENDICIONTableAdapter.ClearBeforeFill = true;
            // 
            // centroTableAdapter
            // 
            this.centroTableAdapter.ClearBeforeFill = true;
            // 
            // h2USUARIOSBYIDLISTBindingSource
            // 
            this.h2USUARIOSBYIDLISTBindingSource.DataMember = "H2_USUARIOS_BY_ID_LIST";
            this.h2USUARIOSBYIDLISTBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // h2_USUARIOS_BY_ID_LISTTableAdapter
            // 
            this.h2_USUARIOS_BY_ID_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // h2USUARIOSBYIDLISTBindingSource1
            // 
            this.h2USUARIOSBYIDLISTBindingSource1.DataMember = "H2_USUARIOS_BY_ID_LIST";
            this.h2USUARIOSBYIDLISTBindingSource1.DataSource = this.dataSet4;
            // 
            // h2_USUARIOS_BY_ID_LISTTableAdapter1
            // 
            this.h2_USUARIOS_BY_ID_LISTTableAdapter1.ClearBeforeFill = true;
            // 
            // Rendicion_Bono_Imp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 405);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rendicion_Bono_Imp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendicion_Bono_Imp";
            this.Load += new System.EventHandler(this.Rendicion_Bono_Imp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.H2_PEDIDOS_PUBLICO_RENDICIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2USUARIOSBYIDLISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2USUARIOSBYIDLISTBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource H2_PEDIDOS_PUBLICO_RENDICIONBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.H2_PEDIDOS_PUBLICO_RENDICIONTableAdapter H2_PEDIDOS_PUBLICO_RENDICIONTableAdapter;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource centroBindingSource;
        private DataSet2TableAdapters.CentroTableAdapter centroTableAdapter;
        private System.Windows.Forms.BindingSource h2USUARIOSBYIDLISTBindingSource;
        private DataSet3 dataSet3;
        private DataSet3TableAdapters.H2_USUARIOS_BY_ID_LISTTableAdapter h2_USUARIOS_BY_ID_LISTTableAdapter;
        private System.Windows.Forms.BindingSource h2USUARIOSBYIDLISTBindingSource1;
        private DataSet4 dataSet4;
        private DataSet4TableAdapters.H2_USUARIOS_BY_ID_LISTTableAdapter h2_USUARIOS_BY_ID_LISTTableAdapter1;
    }
}