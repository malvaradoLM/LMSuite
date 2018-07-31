namespace RPSuite.Forms.Buscar
{
    partial class frmBuscar
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
            this.gcBusqueda = new DevExpress.XtraEditors.GroupControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDatosBusqueda = new DevExpress.XtraEditors.TextEdit();
            this.lblDatosBusqueda = new DevExpress.XtraEditors.LabelControl();
            this.dgcBusqueda = new DevExpress.XtraGrid.GridControl();
            this.gvBuscar = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).BeginInit();
            this.gcBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.dgcBusqueda);
            this.tpDatos.Controls.Add(this.gcBusqueda);
            // 
            // gcBusqueda
            // 
            this.gcBusqueda.Controls.Add(this.btnBuscar);
            this.gcBusqueda.Controls.Add(this.txtDatosBusqueda);
            this.gcBusqueda.Controls.Add(this.lblDatosBusqueda);
            this.gcBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBusqueda.Location = new System.Drawing.Point(0, 0);
            this.gcBusqueda.Name = "gcBusqueda";
            this.gcBusqueda.Size = new System.Drawing.Size(710, 100);
            this.gcBusqueda.TabIndex = 1;
            this.gcBusqueda.Text = "Busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageOptions.ImageIndex = 0;
            this.btnBuscar.Location = new System.Drawing.Point(370, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDatosBusqueda
            // 
            this.txtDatosBusqueda.Location = new System.Drawing.Point(13, 52);
            this.txtDatosBusqueda.Name = "txtDatosBusqueda";
            this.txtDatosBusqueda.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDatosBusqueda.Size = new System.Drawing.Size(351, 20);
            this.txtDatosBusqueda.TabIndex = 1;
            // 
            // lblDatosBusqueda
            // 
            this.lblDatosBusqueda.Location = new System.Drawing.Point(13, 33);
            this.lblDatosBusqueda.Name = "lblDatosBusqueda";
            this.lblDatosBusqueda.Size = new System.Drawing.Size(82, 13);
            this.lblDatosBusqueda.TabIndex = 0;
            this.lblDatosBusqueda.Text = "Datos Busqueda:";
            // 
            // dgcBusqueda
            // 
            this.dgcBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcBusqueda.Location = new System.Drawing.Point(0, 100);
            this.dgcBusqueda.MainView = this.gvBuscar;
            this.dgcBusqueda.Name = "dgcBusqueda";
            this.dgcBusqueda.Size = new System.Drawing.Size(710, 267);
            this.dgcBusqueda.TabIndex = 3;
            this.dgcBusqueda.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBuscar});
            // 
            // gvBuscar
            // 
            this.gvBuscar.GridControl = this.dgcBusqueda;
            this.gvBuscar.Name = "gvBuscar";
            this.gvBuscar.OptionsBehavior.Editable = false;
            this.gvBuscar.OptionsFind.AlwaysVisible = true;
            this.gvBuscar.OptionsFind.SearchInPreview = true;
            this.gvBuscar.OptionsFind.ShowClearButton = false;
            this.gvBuscar.OptionsFind.ShowCloseButton = false;
            this.gvBuscar.OptionsFind.ShowFindButton = false;
            this.gvBuscar.OptionsSelection.MultiSelect = true;
            this.gvBuscar.OptionsView.ColumnAutoWidth = false;
            this.gvBuscar.DoubleClick += new System.EventHandler(this.gvBuscar_DoubleClick);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 392);
            this.Name = "frmBuscar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuscar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBuscar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBusqueda)).EndInit();
            this.gcBusqueda.ResumeLayout(false);
            this.gcBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatosBusqueda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.GroupControl gcBusqueda;
        public DevExpress.XtraEditors.SimpleButton btnBuscar;
        public DevExpress.XtraEditors.TextEdit txtDatosBusqueda;
        public DevExpress.XtraEditors.LabelControl lblDatosBusqueda;
        public DevExpress.XtraGrid.GridControl dgcBusqueda;
        public DevExpress.XtraGrid.Views.Grid.GridView gvBuscar;
    }
}
