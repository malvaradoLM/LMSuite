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
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoFacturaDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // spCatGrupoFacturaDS1
            // 
            this.spCatGrupoFacturaDS1.DataSetName = "spCatGrupoFacturaDS";
            this.spCatGrupoFacturaDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 392);
            this.Name = "frmLiquidacion";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatGrupoFacturaDS1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datasets.Catalogos.spCatGrupoFacturaDS spCatGrupoFacturaDS1;
    }
}
