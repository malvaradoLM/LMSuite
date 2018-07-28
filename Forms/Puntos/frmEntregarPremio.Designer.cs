namespace RPSuite.Forms.Puntos
{
    partial class frmEntregarPremio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregarPremio));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mmeObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.luePremio = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSaldo = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spCatPremioDS = new RPSuite.Datasets.Catalogos.spCatPremioDS();
            this.txtClienteID = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePremio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatPremioDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtClienteID);
            this.groupControl1.Controls.Add(this.mmeObservaciones);
            this.groupControl1.Controls.Add(this.txtCantidad);
            this.groupControl1.Controls.Add(this.luePremio);
            this.groupControl1.Controls.Add(this.txtSaldo);
            this.groupControl1.Controls.Add(this.txtNombre);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(496, 355);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // mmeObservaciones
            // 
            this.mmeObservaciones.Location = new System.Drawing.Point(22, 235);
            this.mmeObservaciones.Name = "mmeObservaciones";
            this.mmeObservaciones.Size = new System.Drawing.Size(440, 103);
            this.mmeObservaciones.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(398, 190);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(64, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // luePremio
            // 
            this.luePremio.Location = new System.Drawing.Point(22, 190);
            this.luePremio.Name = "luePremio";
            this.luePremio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePremio.Size = new System.Drawing.Size(353, 20);
            this.luePremio.TabIndex = 9;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(22, 143);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Properties.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(22, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(440, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Observaciones";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(398, 169);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Cantidad";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Premio";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 124);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Saldo";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ClienteID";
            // 
            // spCatPremioDS
            // 
            this.spCatPremioDS.DataSetName = "spCatPremioDS";
            this.spCatPremioDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(22, 53);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtClienteID.Size = new System.Drawing.Size(100, 20);
            this.txtClienteID.TabIndex = 12;
            // 
            // frmEntregarPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(520, 379);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEntregarPremio";
            this.Text = "Entregar Premio";
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luePremio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spCatPremioDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClienteID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit mmeObservaciones;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.LookUpEdit luePremio;
        private DevExpress.XtraEditors.TextEdit txtSaldo;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Datasets.Catalogos.spCatPremioDS spCatPremioDS;
        private DevExpress.XtraEditors.ButtonEdit txtClienteID;
    }
}
