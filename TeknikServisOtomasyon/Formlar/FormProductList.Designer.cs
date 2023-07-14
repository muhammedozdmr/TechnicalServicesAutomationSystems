namespace TeknikServisOtomasyon.Formlar
{
    partial class FormProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductList));
            this.gridProductList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupProduct = new DevExpress.XtraEditors.GroupControl();
            this.txtProductID = new DevExpress.XtraEditors.TextEdit();
            this.lblProductID = new DevExpress.XtraEditors.LabelControl();
            this.btnProductList = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.txtStock = new DevExpress.XtraEditors.TextEdit();
            this.lblStock = new DevExpress.XtraEditors.LabelControl();
            this.txtSellPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblSellPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtBuyPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblBuyPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtProductMark = new DevExpress.XtraEditors.TextEdit();
            this.lblProductMark = new DevExpress.XtraEditors.LabelControl();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProduct)).BeginInit();
            this.groupProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductMark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductList
            // 
            this.gridProductList.Location = new System.Drawing.Point(1, 3);
            this.gridProductList.MainView = this.gridView1;
            this.gridProductList.Name = "gridProductList";
            this.gridProductList.Size = new System.Drawing.Size(1456, 806);
            this.gridProductList.TabIndex = 0;
            this.gridProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.SkyBlue;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridProductList;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupProduct
            // 
            this.groupProduct.Controls.Add(this.txtProductID);
            this.groupProduct.Controls.Add(this.lblProductID);
            this.groupProduct.Controls.Add(this.btnProductList);
            this.groupProduct.Controls.Add(this.btnUpdateProduct);
            this.groupProduct.Controls.Add(this.btnDeleteProduct);
            this.groupProduct.Controls.Add(this.btnSaveProduct);
            this.groupProduct.Controls.Add(this.cmbCategory);
            this.groupProduct.Controls.Add(this.lblCategory);
            this.groupProduct.Controls.Add(this.txtStock);
            this.groupProduct.Controls.Add(this.lblStock);
            this.groupProduct.Controls.Add(this.txtSellPrice);
            this.groupProduct.Controls.Add(this.lblSellPrice);
            this.groupProduct.Controls.Add(this.txtBuyPrice);
            this.groupProduct.Controls.Add(this.lblBuyPrice);
            this.groupProduct.Controls.Add(this.txtProductMark);
            this.groupProduct.Controls.Add(this.lblProductMark);
            this.groupProduct.Controls.Add(this.txtProductName);
            this.groupProduct.Controls.Add(this.lblProductName);
            this.groupProduct.Location = new System.Drawing.Point(1463, 3);
            this.groupProduct.Name = "groupProduct";
            this.groupProduct.Size = new System.Drawing.Size(427, 806);
            this.groupProduct.TabIndex = 3;
            this.groupProduct.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(97, 53);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(292, 20);
            this.txtProductID.TabIndex = 20;
            // 
            // lblProductID
            // 
            this.lblProductID.Location = new System.Drawing.Point(39, 56);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(46, 13);
            this.lblProductID.TabIndex = 19;
            this.lblProductID.Text = "ÜRÜN ID:";
            // 
            // btnProductList
            // 
            this.btnProductList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductList.ImageOptions.Image")));
            this.btnProductList.Location = new System.Drawing.Point(97, 382);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(292, 38);
            this.btnProductList.TabIndex = 18;
            this.btnProductList.Text = "LİSTELE";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.ImageOptions.Image")));
            this.btnUpdateProduct.Location = new System.Drawing.Point(96, 338);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(292, 38);
            this.btnUpdateProduct.TabIndex = 17;
            this.btnUpdateProduct.Text = "GÜNCELLE";
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.ImageOptions.Image")));
            this.btnDeleteProduct.Location = new System.Drawing.Point(96, 294);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(292, 38);
            this.btnDeleteProduct.TabIndex = 16;
            this.btnDeleteProduct.Text = "SİL";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.ImageOptions.Image")));
            this.btnSaveProduct.Location = new System.Drawing.Point(96, 250);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(292, 38);
            this.btnSaveProduct.TabIndex = 15;
            this.btnSaveProduct.Text = "KAYDET";
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Location = new System.Drawing.Point(96, 210);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCategory.Properties.DisplayMember = "AD";
            this.cmbCategory.Properties.ValueMember = "ID";
            this.cmbCategory.Size = new System.Drawing.Size(292, 20);
            this.cmbCategory.TabIndex = 14;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(36, 213);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "KATEGORİ:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(97, 184);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(292, 20);
            this.txtStock.TabIndex = 12;
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(61, 186);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(30, 13);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "STOK:";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(96, 157);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(292, 20);
            this.txtSellPrice.TabIndex = 10;
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.Location = new System.Drawing.Point(22, 160);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(69, 13);
            this.lblSellPrice.TabIndex = 9;
            this.lblSellPrice.Text = "SATIŞ FİYATI:";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(96, 131);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(292, 20);
            this.txtBuyPrice.TabIndex = 8;
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.Location = new System.Drawing.Point(29, 134);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(62, 13);
            this.lblBuyPrice.TabIndex = 7;
            this.lblBuyPrice.Text = "ALIŞ FİYATI:";
            // 
            // txtProductMark
            // 
            this.txtProductMark.Location = new System.Drawing.Point(96, 105);
            this.txtProductMark.Name = "txtProductMark";
            this.txtProductMark.Size = new System.Drawing.Size(292, 20);
            this.txtProductMark.TabIndex = 6;
            // 
            // lblProductMark
            // 
            this.lblProductMark.Location = new System.Drawing.Point(52, 108);
            this.lblProductMark.Name = "lblProductMark";
            this.lblProductMark.Size = new System.Drawing.Size(39, 13);
            this.lblProductMark.TabIndex = 5;
            this.lblProductMark.Text = "MARKA:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(96, 79);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(292, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(38, 82);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(53, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "ÜRÜN ADI:";
            // 
            // FormProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1894, 811);
            this.Controls.Add(this.groupProduct);
            this.Controls.Add(this.gridProductList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FormProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProduct)).EndInit();
            this.groupProduct.ResumeLayout(false);
            this.groupProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductMark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupProduct;
        private DevExpress.XtraEditors.TextEdit txtStock;
        private DevExpress.XtraEditors.LabelControl lblStock;
        private DevExpress.XtraEditors.TextEdit txtSellPrice;
        private DevExpress.XtraEditors.LabelControl lblSellPrice;
        private DevExpress.XtraEditors.TextEdit txtBuyPrice;
        private DevExpress.XtraEditors.LabelControl lblBuyPrice;
        private DevExpress.XtraEditors.TextEdit txtProductMark;
        private DevExpress.XtraEditors.LabelControl lblProductMark;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private DevExpress.XtraEditors.SimpleButton btnUpdateProduct;
        private DevExpress.XtraEditors.SimpleButton btnDeleteProduct;
        private DevExpress.XtraEditors.SimpleButton btnSaveProduct;
        private DevExpress.XtraEditors.LookUpEdit cmbCategory;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.SimpleButton btnProductList;
        private DevExpress.XtraEditors.TextEdit txtProductID;
        private DevExpress.XtraEditors.LabelControl lblProductID;
    }
}