namespace RPSuite.Forms.Liquidacion
{
    partial class frmConsumoFlotillas
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
            this.tpSagarpa = new DevExpress.XtraTab.XtraTabPage();
            this.tpCuponesInternos = new DevExpress.XtraTab.XtraTabPage();
            this.tpCuponesExternos = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.SelectedTabPage = this.tpDatos;
            this.tbControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpSagarpa,
            this.tpCuponesInternos,
            this.tpCuponesExternos});
            this.tbControl.Controls.SetChildIndex(this.tpCuponesExternos, 0);
            this.tbControl.Controls.SetChildIndex(this.tpCuponesInternos, 0);
            this.tbControl.Controls.SetChildIndex(this.tpSagarpa, 0);
            this.tbControl.Controls.SetChildIndex(this.tpDatos, 0);
            // 
            // tpDatos
            // 
            this.tpDatos.Text = "Consumo Flotillas";
            // 
            // tpSagarpa
            // 
            this.tpSagarpa.Name = "tpSagarpa";
            this.tpSagarpa.Size = new System.Drawing.Size(710, 367);
            this.tpSagarpa.Text = "Sagarpa";
            // 
            // tpCuponesInternos
            // 
            this.tpCuponesInternos.Name = "tpCuponesInternos";
            this.tpCuponesInternos.Size = new System.Drawing.Size(0, 0);
            this.tpCuponesInternos.Text = "Cupones Internos";
            // 
            // tpCuponesExternos
            // 
            this.tpCuponesExternos.Name = "tpCuponesExternos";
            this.tpCuponesExternos.Size = new System.Drawing.Size(0, 0);
            this.tpCuponesExternos.Text = "Cupones Externos";
            // 
            // frmConsumoFlotillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 392);
            this.Name = "frmConsumoFlotillas";
            this.Text = "Consumo Flotillas";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage tpSagarpa;
        private DevExpress.XtraTab.XtraTabPage tpCuponesInternos;
        private DevExpress.XtraTab.XtraTabPage tpCuponesExternos;
    }
}
