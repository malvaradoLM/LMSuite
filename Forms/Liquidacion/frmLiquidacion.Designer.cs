namespace RPSuite.Forms.Liquidacion
{
    partial class frmLiquidacion
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
            this.spCatGrupoFacturaDS1 = new RPSuite.Datasets.Catalogos.spCatGrupoFacturaDS();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoFacturaDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            // 
            // spCatGrupoFacturaDS1
            // 
            this.spCatGrupoFacturaDS1.DataSetName = "spCatGrupoFacturaDS";
            this.spCatGrupoFacturaDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(125, 29);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(382, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(210, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // frmLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 392);
            this.Name = "frmLiquidacion";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoFacturaDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Datasets.Catalogos.spCatGrupoFacturaDS spCatGrupoFacturaDS1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
