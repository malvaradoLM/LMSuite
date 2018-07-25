namespace RPSuite.Forms.Facturacion
{
    partial class frmFacturacion
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelarGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.txtSerieGenerar = new DevExpress.XtraEditors.TextEdit();
            this.dateFechaCorte = new DevExpress.XtraEditors.DateEdit();
            this.dateFechaCaptura = new DevExpress.XtraEditors.DateEdit();
            this.lueProductos = new DevExpress.XtraEditors.LookUpEdit();
            this.lueGrupoFacturar = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tpObservaciones = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelarObservacion = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.memObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnConsultarObservacion = new DevExpress.XtraEditors.SimpleButton();
            this.txtFolioGenerar = new DevExpress.XtraEditors.TextEdit();
            this.txtSerieObservacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).BeginInit();
            this.tbControl.SuspendLayout();
            this.tpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieGenerar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCorte.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCorte.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaptura.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaptura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupoFacturar.Properties)).BeginInit();
            this.tpObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioGenerar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieObservacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.SelectedTabPage = this.tpDatos;
            this.tbControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpObservaciones});
            this.tbControl.Controls.SetChildIndex(this.tpObservaciones, 0);
            this.tbControl.Controls.SetChildIndex(this.tpDatos, 0);
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.groupControl1);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCancelarGenerar);
            this.groupControl1.Controls.Add(this.btnGenerar);
            this.groupControl1.Controls.Add(this.txtSerieGenerar);
            this.groupControl1.Controls.Add(this.dateFechaCorte);
            this.groupControl1.Controls.Add(this.dateFechaCaptura);
            this.groupControl1.Controls.Add(this.lueProductos);
            this.groupControl1.Controls.Add(this.lueGrupoFacturar);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(11, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(270, 327);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Parametros";
            // 
            // btnCancelarGenerar
            // 
            this.btnCancelarGenerar.Location = new System.Drawing.Point(118, 277);
            this.btnCancelarGenerar.Name = "btnCancelarGenerar";
            this.btnCancelarGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarGenerar.TabIndex = 11;
            this.btnCancelarGenerar.Text = "Cancelar";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(23, 277);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 10;
            this.btnGenerar.Text = "Generar";
            // 
            // txtSerieGenerar
            // 
            this.txtSerieGenerar.Location = new System.Drawing.Point(23, 57);
            this.txtSerieGenerar.Name = "txtSerieGenerar";
            this.txtSerieGenerar.Size = new System.Drawing.Size(74, 20);
            this.txtSerieGenerar.TabIndex = 9;
            // 
            // dateFechaCorte
            // 
            this.dateFechaCorte.EditValue = null;
            this.dateFechaCorte.Location = new System.Drawing.Point(23, 102);
            this.dateFechaCorte.Name = "dateFechaCorte";
            this.dateFechaCorte.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaCorte.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaCorte.Size = new System.Drawing.Size(134, 20);
            this.dateFechaCorte.TabIndex = 8;
            // 
            // dateFechaCaptura
            // 
            this.dateFechaCaptura.EditValue = null;
            this.dateFechaCaptura.Location = new System.Drawing.Point(23, 147);
            this.dateFechaCaptura.Name = "dateFechaCaptura";
            this.dateFechaCaptura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaCaptura.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFechaCaptura.Size = new System.Drawing.Size(134, 20);
            this.dateFechaCaptura.TabIndex = 7;
            // 
            // lueProductos
            // 
            this.lueProductos.Location = new System.Drawing.Point(23, 192);
            this.lueProductos.Name = "lueProductos";
            this.lueProductos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueProductos.Size = new System.Drawing.Size(220, 20);
            this.lueProductos.TabIndex = 6;
            // 
            // lueGrupoFacturar
            // 
            this.lueGrupoFacturar.Location = new System.Drawing.Point(23, 237);
            this.lueGrupoFacturar.Name = "lueGrupoFacturar";
            this.lueGrupoFacturar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGrupoFacturar.Size = new System.Drawing.Size(220, 20);
            this.lueGrupoFacturar.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 218);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Grupo a Facturar";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 173);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Productos";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Fecha Captura";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Fecha de Corte";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Serie";
            // 
            // tpObservaciones
            // 
            this.tpObservaciones.Controls.Add(this.groupControl3);
            this.tpObservaciones.Controls.Add(this.groupControl2);
            this.tpObservaciones.Name = "tpObservaciones";
            this.tpObservaciones.Size = new System.Drawing.Size(710, 367);
            this.tpObservaciones.Text = "Observaciones Factura";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnCancelarObservacion);
            this.groupControl3.Controls.Add(this.btnGuardarCancelar);
            this.groupControl3.Controls.Add(this.memObservaciones);
            this.groupControl3.Location = new System.Drawing.Point(11, 165);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(583, 189);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Observaciones";
            // 
            // btnCancelarObservacion
            // 
            this.btnCancelarObservacion.Location = new System.Drawing.Point(298, 160);
            this.btnCancelarObservacion.Name = "btnCancelarObservacion";
            this.btnCancelarObservacion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarObservacion.TabIndex = 2;
            this.btnCancelarObservacion.Text = "Cancelar";
            // 
            // btnGuardarCancelar
            // 
            this.btnGuardarCancelar.Location = new System.Drawing.Point(193, 160);
            this.btnGuardarCancelar.Name = "btnGuardarCancelar";
            this.btnGuardarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCancelar.TabIndex = 1;
            this.btnGuardarCancelar.Text = "Guardar";
            // 
            // memObservaciones
            // 
            this.memObservaciones.Location = new System.Drawing.Point(22, 34);
            this.memObservaciones.Name = "memObservaciones";
            this.memObservaciones.Size = new System.Drawing.Size(541, 119);
            this.memObservaciones.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnConsultarObservacion);
            this.groupControl2.Controls.Add(this.txtFolioGenerar);
            this.groupControl2.Controls.Add(this.txtSerieObservacion);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Location = new System.Drawing.Point(11, 11);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(245, 144);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Serie-Folio";
            // 
            // btnConsultarObservacion
            // 
            this.btnConsultarObservacion.Location = new System.Drawing.Point(132, 76);
            this.btnConsultarObservacion.Name = "btnConsultarObservacion";
            this.btnConsultarObservacion.Size = new System.Drawing.Size(86, 23);
            this.btnConsultarObservacion.TabIndex = 4;
            this.btnConsultarObservacion.Text = "Consultar";
            // 
            // txtFolioGenerar
            // 
            this.txtFolioGenerar.Location = new System.Drawing.Point(23, 100);
            this.txtFolioGenerar.Name = "txtFolioGenerar";
            this.txtFolioGenerar.Size = new System.Drawing.Size(77, 20);
            this.txtFolioGenerar.TabIndex = 3;
            // 
            // txtSerieObservacion
            // 
            this.txtSerieObservacion.Location = new System.Drawing.Point(23, 55);
            this.txtSerieObservacion.Name = "txtSerieObservacion";
            this.txtSerieObservacion.Size = new System.Drawing.Size(77, 20);
            this.txtSerieObservacion.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 81);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Folio";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 36);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Serie";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(712, 392);
            this.Name = "frmFacturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.tbControl)).EndInit();
            this.tbControl.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieGenerar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCorte.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCorte.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaptura.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFechaCaptura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueProductos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGrupoFacturar.Properties)).EndInit();
            this.tpObservaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolioGenerar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerieObservacion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancelarGenerar;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.TextEdit txtSerieGenerar;
        private DevExpress.XtraEditors.DateEdit dateFechaCorte;
        private DevExpress.XtraEditors.DateEdit dateFechaCaptura;
        private DevExpress.XtraEditors.LookUpEdit lueProductos;
        private DevExpress.XtraEditors.LookUpEdit lueGrupoFacturar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage tpObservaciones;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancelarObservacion;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCancelar;
        private DevExpress.XtraEditors.MemoEdit memObservaciones;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnConsultarObservacion;
        private DevExpress.XtraEditors.TextEdit txtFolioGenerar;
        private DevExpress.XtraEditors.TextEdit txtSerieObservacion;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}
