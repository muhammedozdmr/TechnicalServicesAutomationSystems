namespace TeknikServisOtomasyon.Formlar
{
    partial class FormInvoiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoiceList));
            this.groupProduct = new DevExpress.XtraEditors.GroupControl();
            this.txtSerialNumber = new System.Windows.Forms.MaskedTextBox();
            this.cmbPersonal = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTax = new DevExpress.XtraEditors.TextEdit();
            this.dateInvoice = new System.Windows.Forms.DateTimePicker();
            this.txtLineNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblCategoryId = new DevExpress.XtraEditors.LabelControl();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblCategoryName = new DevExpress.XtraEditors.LabelControl();
            this.timeInvoice = new DevExpress.XtraEditors.TextEdit();
            this.gridList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupProduct)).BeginInit();
            this.groupProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLineNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupProduct
            // 
            this.groupProduct.Controls.Add(this.txtSerialNumber);
            this.groupProduct.Controls.Add(this.cmbPersonal);
            this.groupProduct.Controls.Add(this.labelControl6);
            this.groupProduct.Controls.Add(this.labelControl5);
            this.groupProduct.Controls.Add(this.cmbCustomer);
            this.groupProduct.Controls.Add(this.labelControl4);
            this.groupProduct.Controls.Add(this.labelControl3);
            this.groupProduct.Controls.Add(this.labelControl2);
            this.groupProduct.Controls.Add(this.labelControl1);
            this.groupProduct.Controls.Add(this.txtTax);
            this.groupProduct.Controls.Add(this.dateInvoice);
            this.groupProduct.Controls.Add(this.txtLineNumber);
            this.groupProduct.Controls.Add(this.txtID);
            this.groupProduct.Controls.Add(this.lblCategoryId);
            this.groupProduct.Controls.Add(this.btnList);
            this.groupProduct.Controls.Add(this.btnUpdate);
            this.groupProduct.Controls.Add(this.btnDelete);
            this.groupProduct.Controls.Add(this.btnSave);
            this.groupProduct.Controls.Add(this.lblCategoryName);
            this.groupProduct.Controls.Add(this.timeInvoice);
            this.groupProduct.Location = new System.Drawing.Point(1417, 2);
            this.groupProduct.Name = "groupProduct";
            this.groupProduct.Size = new System.Drawing.Size(466, 806);
            this.groupProduct.TabIndex = 7;
            this.groupProduct.Text = "FATURA İŞLEMLERİ";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(97, 78);
            this.txtSerialNumber.Mask = "A";
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(293, 21);
            this.txtSerialNumber.TabIndex = 1;
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.Location = new System.Drawing.Point(96, 242);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPersonal.Properties.DisplayMember = "AD";
            this.cmbPersonal.Properties.NullText = "PERSONEL SEÇİNİZ";
            this.cmbPersonal.Properties.ValueMember = "ID";
            this.cmbPersonal.Size = new System.Drawing.Size(294, 20);
            this.cmbPersonal.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(35, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "PERSONEL:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(61, 216);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(29, 13);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "CARİ:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Location = new System.Drawing.Point(96, 213);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCustomer.Properties.DisplayMember = "AD";
            this.cmbCustomer.Properties.NullText = "CARİ SEÇİNİZ";
            this.cmbCustomer.Properties.ValueMember = "ID";
            this.cmbCustomer.Size = new System.Drawing.Size(294, 20);
            this.cmbCustomer.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 189);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "VERGİ DAİRESİ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(60, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "SAAT:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "TARİH:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 112);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "SIRA NO:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(96, 186);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(294, 20);
            this.txtTax.TabIndex = 5;
            // 
            // dateInvoice
            // 
            this.dateInvoice.Location = new System.Drawing.Point(96, 132);
            this.dateInvoice.Name = "dateInvoice";
            this.dateInvoice.Size = new System.Drawing.Size(294, 21);
            this.dateInvoice.TabIndex = 3;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(96, 105);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(294, 20);
            this.txtLineNumber.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(96, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(294, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.Location = new System.Drawing.Point(75, 56);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(15, 13);
            this.lblCategoryId.TabIndex = 19;
            this.lblCategoryId.Text = "ID:";
            // 
            // btnList
            // 
            this.btnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnList.ImageOptions.Image")));
            this.btnList.Location = new System.Drawing.Point(97, 426);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(292, 38);
            this.btnList.TabIndex = 18;
            this.btnList.Text = "LİSTELE";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(96, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(292, 38);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "GÜNCELLE";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(96, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(292, 38);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "SİL";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(96, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(292, 38);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "KAYDET";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Location = new System.Drawing.Point(63, 82);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(27, 13);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "SERİ:";
            // 
            // timeInvoice
            // 
            this.timeInvoice.EditValue = "";
            this.timeInvoice.Location = new System.Drawing.Point(96, 160);
            this.timeInvoice.Name = "timeInvoice";
            this.timeInvoice.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.timeInvoice.Size = new System.Drawing.Size(294, 20);
            this.timeInvoice.TabIndex = 4;
            // 
            // gridList
            // 
            this.gridList.Location = new System.Drawing.Point(11, 2);
            this.gridList.MainView = this.gridView1;
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(1400, 647);
            this.gridList.TabIndex = 6;
            this.gridList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.SkyBlue;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridList;
            this.gridView1.Name = "gridView1";
            // 
            // FormInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 811);
            this.Controls.Add(this.groupProduct);
            this.Controls.Add(this.gridList);
            this.Name = "FormInvoiceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormInvoiceList";
            this.Load += new System.EventHandler(this.FormInvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupProduct)).EndInit();
            this.groupProduct.ResumeLayout(false);
            this.groupProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPersonal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLineNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupProduct;
        private DevExpress.XtraEditors.LookUpEdit cmbPersonal;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cmbCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTax;
        private System.Windows.Forms.DateTimePicker dateInvoice;
        private DevExpress.XtraEditors.TextEdit txtLineNumber;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblCategoryId;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblCategoryName;
        private DevExpress.XtraGrid.GridControl gridList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.MaskedTextBox txtSerialNumber;
        private DevExpress.XtraEditors.TextEdit timeInvoice;
    }
}