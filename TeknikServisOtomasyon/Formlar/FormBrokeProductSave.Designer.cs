namespace TeknikServisOtomasyon.Formlar
{
    partial class FormBrokeProductSave
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrokeProductSave));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDate = new DevExpress.XtraEditors.TextEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPersonal = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnFillCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.dateProduct = new System.Windows.Forms.DateTimePicker();
            this.txtSeriNo = new System.Windows.Forms.MaskedTextBox();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(175, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(199, 25);
            this.labelControl1.TabIndex = 54;
            this.labelControl1.Text = "ARIZALI ÜRÜN KAYDI";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(263, 309);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 38);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "VAZGEÇ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(120, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 38);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "KAYDET";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(163, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 3);
            this.panel6.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(163, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 3);
            this.panel3.TabIndex = 42;
            // 
            // txtDate
            // 
            this.txtDate.EditValue = "Tarih:";
            this.txtDate.Location = new System.Drawing.Point(101, 204);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDate.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.Appearance.Options.UseForeColor = true;
            this.txtDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.txtDate.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtDate.Properties.MaskSettings.Set("mask", "d");
            this.txtDate.Size = new System.Drawing.Size(41, 26);
            this.txtDate.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(163, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 3);
            this.panel2.TabIndex = 39;
            // 
            // txtPersonal
            // 
            this.txtPersonal.EditValue = "Personel:";
            this.txtPersonal.Location = new System.Drawing.Point(74, 155);
            this.txtPersonal.Name = "txtPersonal";
            this.txtPersonal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPersonal.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonal.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtPersonal.Properties.Appearance.Options.UseBackColor = true;
            this.txtPersonal.Properties.Appearance.Options.UseFont = true;
            this.txtPersonal.Properties.Appearance.Options.UseForeColor = true;
            this.txtPersonal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtPersonal.Size = new System.Drawing.Size(68, 26);
            this.txtPersonal.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(163, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 3);
            this.panel1.TabIndex = 36;
            // 
            // txtName
            // 
            this.txtName.EditValue = "Müşteri:";
            this.txtName.Location = new System.Drawing.Point(76, 96);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.Appearance.Options.UseForeColor = true;
            this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtName.Size = new System.Drawing.Size(66, 26);
            this.txtName.TabIndex = 35;
            // 
            // btnFillCustomer
            // 
            this.btnFillCustomer.Location = new System.Drawing.Point(369, 256);
            this.btnFillCustomer.Name = "btnFillCustomer";
            this.btnFillCustomer.Size = new System.Drawing.Size(91, 24);
            this.btnFillCustomer.TabIndex = 55;
            this.btnFillCustomer.Text = "MÜŞTERİ  GETİR";
            this.btnFillCustomer.Click += new System.EventHandler(this.btnFillCustomer_Click);
            // 
            // dateProduct
            // 
            this.dateProduct.Location = new System.Drawing.Point(163, 206);
            this.dateProduct.Name = "dateProduct";
            this.dateProduct.Size = new System.Drawing.Size(200, 20);
            this.dateProduct.TabIndex = 58;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(163, 258);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(200, 20);
            this.txtSeriNo.TabIndex = 59;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Seri No:";
            this.textEdit1.Location = new System.Drawing.Point(74, 256);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.textEdit1.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.textEdit1.Properties.MaskSettings.Set("mask", "d");
            this.textEdit1.Size = new System.Drawing.Size(68, 26);
            this.textEdit1.TabIndex = 60;
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Location = new System.Drawing.Point(163, 157);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(200, 21);
            this.cmbPersonal.TabIndex = 61;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(163, 100);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 21);
            this.cmbCustomer.TabIndex = 62;
            // 
            // FormBrokeProductSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(534, 381);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.cmbPersonal);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.dateProduct);
            this.Controls.Add(this.btnFillCustomer);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPersonal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBrokeProductSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBrokeProductSave";
            this.Load += new System.EventHandler(this.FormBrokeProductSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtDate;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtPersonal;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnFillCustomer;
        private System.Windows.Forms.DateTimePicker dateProduct;
        private System.Windows.Forms.MaskedTextBox txtSeriNo;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.ComboBox cmbCustomer;
    }
}