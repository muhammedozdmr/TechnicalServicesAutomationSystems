namespace TeknikServisOtomasyon.Formlar
{
    partial class FormFaturaKalemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFaturaKalemi));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridList = new DevExpress.XtraGrid.GridControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblCategoryId = new DevExpress.XtraEditors.LabelControl();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblCategoryName = new DevExpress.XtraEditors.LabelControl();
            this.groupProduct = new DevExpress.XtraEditors.GroupControl();
            this.txtUrun = new DevExpress.XtraEditors.TextEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.txtFaturaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProduct)).BeginInit();
            this.groupProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            this.SuspendLayout();
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
            // gridList
            // 
            this.gridList.Location = new System.Drawing.Point(11, 2);
            this.gridList.MainView = this.gridView1;
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(1400, 647);
            this.gridList.TabIndex = 8;
            this.gridList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 189);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "FATURA ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(54, 164);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "TUTAR:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 138);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "FİYAT:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(97, 131);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(294, 20);
            this.txtFiyat.TabIndex = 2;
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
            this.btnList.Location = new System.Drawing.Point(97, 383);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(292, 38);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "LİSTELE";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(96, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(292, 38);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "GÜNCELLE";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(96, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(292, 38);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "SİL";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(96, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(292, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "KAYDET";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Location = new System.Drawing.Point(58, 82);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(32, 13);
            this.lblCategoryName.TabIndex = 3;
            this.lblCategoryName.Text = "ÜRÜN:";
            // 
            // groupProduct
            // 
            this.groupProduct.Controls.Add(this.labelControl4);
            this.groupProduct.Controls.Add(this.txtAdet);
            this.groupProduct.Controls.Add(this.txtFaturaID);
            this.groupProduct.Controls.Add(this.labelControl3);
            this.groupProduct.Controls.Add(this.labelControl2);
            this.groupProduct.Controls.Add(this.labelControl1);
            this.groupProduct.Controls.Add(this.txtUrun);
            this.groupProduct.Controls.Add(this.txtTutar);
            this.groupProduct.Controls.Add(this.txtFiyat);
            this.groupProduct.Controls.Add(this.txtID);
            this.groupProduct.Controls.Add(this.lblCategoryId);
            this.groupProduct.Controls.Add(this.btnList);
            this.groupProduct.Controls.Add(this.btnUpdate);
            this.groupProduct.Controls.Add(this.btnDelete);
            this.groupProduct.Controls.Add(this.btnSave);
            this.groupProduct.Controls.Add(this.lblCategoryName);
            this.groupProduct.Location = new System.Drawing.Point(1417, 2);
            this.groupProduct.Name = "groupProduct";
            this.groupProduct.Size = new System.Drawing.Size(466, 806);
            this.groupProduct.TabIndex = 9;
            this.groupProduct.Text = "FATURA KALEM İŞLEMLERİ";
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(96, 79);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(294, 20);
            this.txtUrun.TabIndex = 1;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(97, 157);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(294, 20);
            this.txtTutar.TabIndex = 3;
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.Location = new System.Drawing.Point(98, 186);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.Size = new System.Drawing.Size(294, 20);
            this.txtFaturaID.TabIndex = 28;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(57, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "ADET:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(96, 105);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(294, 20);
            this.txtAdet.TabIndex = 29;
            // 
            // FormFaturaKalemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 811);
            this.Controls.Add(this.groupProduct);
            this.Controls.Add(this.gridList);
            this.Name = "FormFaturaKalemi";
            this.Text = "FormFaturaKalemi";
            this.Load += new System.EventHandler(this.FormFaturaKalemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProduct)).EndInit();
            this.groupProduct.ResumeLayout(false);
            this.groupProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridList;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblCategoryId;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl lblCategoryName;
        private DevExpress.XtraEditors.GroupControl groupProduct;
        private DevExpress.XtraEditors.TextEdit txtUrun;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtFaturaID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAdet;
    }
}