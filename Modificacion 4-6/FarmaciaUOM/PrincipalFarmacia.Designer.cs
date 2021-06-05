namespace FarmaciaUOM
{
    partial class PrincipalFarmacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFarmacia));
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Operacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Operación:";
            // 
            // cbo_Operacion
            // 
            this.cbo_Operacion.FormattingEnabled = true;
            this.cbo_Operacion.Items.AddRange(new object[] {
            "Bono contribución",
            "Buscar Bono contribución",
            "Rendición Bono contribución"});
            this.cbo_Operacion.Location = new System.Drawing.Point(116, 12);
            this.cbo_Operacion.Name = "cbo_Operacion";
            this.cbo_Operacion.Size = new System.Drawing.Size(148, 21);
            this.cbo_Operacion.TabIndex = 1;
            this.cbo_Operacion.Text = "Buscar";
            this.cbo_Operacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbo_Operacion.SelectedValueChanged += new System.EventHandler(this.cbo_Seleccionar_Operacion);
            // 
            // PrincipalFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 64);
            this.Controls.Add(this.cbo_Operacion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalFarmacia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia > Tipo de Operación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Operacion;
    }
}