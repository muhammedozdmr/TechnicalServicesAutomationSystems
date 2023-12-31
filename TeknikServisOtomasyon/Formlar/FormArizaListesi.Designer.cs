﻿namespace TeknikServisOtomasyon.Formlar
{
    partial class FormArizaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArizaListesi));
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView3 = new DevExpress.XtraCharts.PieSeriesView();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblMesajBeklenen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.lblMevcutAriza = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.lblTadilatiBitmis = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.lblParcaBekleyen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.lblToplamUrun = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.lblIptalEdilen = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(34, 3);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Size = new System.Drawing.Size(51, 53);
            this.pictureEdit5.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(395, 18);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Projenin grafiğinde markaların istatistiksel grafiğini görebilirsiniz.";
            // 
            // gridList
            // 
            this.gridList.Location = new System.Drawing.Point(7, 1);
            this.gridList.MainView = this.gridView1;
            this.gridList.Name = "gridList";
            this.gridList.Size = new System.Drawing.Size(985, 808);
            this.gridList.TabIndex = 8;
            this.gridList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridList;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.lblMesajBeklenen);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(1009, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 158);
            this.panel1.TabIndex = 9;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(149, 48);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(46, 49);
            this.pictureEdit1.TabIndex = 2;
            // 
            // lblMesajBeklenen
            // 
            this.lblMesajBeklenen.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesajBeklenen.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMesajBeklenen.Appearance.Options.UseFont = true;
            this.lblMesajBeklenen.Appearance.Options.UseForeColor = true;
            this.lblMesajBeklenen.Location = new System.Drawing.Point(83, 48);
            this.lblMesajBeklenen.Name = "lblMesajBeklenen";
            this.lblMesajBeklenen.Size = new System.Drawing.Size(60, 39);
            this.lblMesajBeklenen.TabIndex = 1;
            this.lblMesajBeklenen.Text = "100";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mesaj Beklenen Müşteriler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.pictureEdit2);
            this.panel2.Controls.Add(this.lblMevcutAriza);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Location = new System.Drawing.Point(1009, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 158);
            this.panel2.TabIndex = 10;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(167, 46);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(82, 83);
            this.pictureEdit2.TabIndex = 2;
            // 
            // lblMevcutAriza
            // 
            this.lblMevcutAriza.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcutAriza.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMevcutAriza.Appearance.Options.UseFont = true;
            this.lblMevcutAriza.Appearance.Options.UseForeColor = true;
            this.lblMevcutAriza.Location = new System.Drawing.Point(83, 48);
            this.lblMevcutAriza.Name = "lblMevcutAriza";
            this.lblMevcutAriza.Size = new System.Drawing.Size(60, 39);
            this.lblMevcutAriza.TabIndex = 1;
            this.lblMevcutAriza.Text = "100";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(34, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(213, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mevcut Arızalı Ürün Sayısı";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureEdit5);
            this.panel5.Controls.Add(this.labelControl4);
            this.panel5.Controls.Add(this.labelControl2);
            this.panel5.Controls.Add(this.chartControl1);
            this.panel5.Location = new System.Drawing.Point(1009, 367);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(879, 442);
            this.panel5.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(91, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(237, 27);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Arızalı Ürün İstatistikleri";
            // 
            // chartControl1
            // 
            this.chartControl1.Legend.LegendID = -1;
            this.chartControl1.Location = new System.Drawing.Point(-1, 109);
            this.chartControl1.Name = "chartControl1";
            series3.LegendTextPattern = "{A}";
            series3.Name = "Series 1";
            series3.SeriesID = 0;
            series3.View = pieSeriesView3;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl1.Size = new System.Drawing.Size(873, 328);
            this.chartControl1.TabIndex = 0;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(167, 46);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Size = new System.Drawing.Size(81, 83);
            this.pictureEdit3.TabIndex = 2;
            // 
            // lblTadilatiBitmis
            // 
            this.lblTadilatiBitmis.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTadilatiBitmis.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTadilatiBitmis.Appearance.Options.UseFont = true;
            this.lblTadilatiBitmis.Appearance.Options.UseForeColor = true;
            this.lblTadilatiBitmis.Location = new System.Drawing.Point(83, 48);
            this.lblTadilatiBitmis.Name = "lblTadilatiBitmis";
            this.lblTadilatiBitmis.Size = new System.Drawing.Size(60, 39);
            this.lblTadilatiBitmis.TabIndex = 1;
            this.lblTadilatiBitmis.Text = "100";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(34, 17);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(214, 23);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Tadilatı Bitmiş Ürün Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(227)))), ((int)(((byte)(116)))));
            this.panel4.Controls.Add(this.pictureEdit4);
            this.panel4.Controls.Add(this.lblParcaBekleyen);
            this.panel4.Controls.Add(this.labelControl7);
            this.panel4.Location = new System.Drawing.Point(1615, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 158);
            this.panel4.TabIndex = 12;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(167, 46);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Size = new System.Drawing.Size(75, 83);
            this.pictureEdit4.TabIndex = 2;
            // 
            // lblParcaBekleyen
            // 
            this.lblParcaBekleyen.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParcaBekleyen.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParcaBekleyen.Appearance.Options.UseFont = true;
            this.lblParcaBekleyen.Appearance.Options.UseForeColor = true;
            this.lblParcaBekleyen.Location = new System.Drawing.Point(64, 48);
            this.lblParcaBekleyen.Name = "lblParcaBekleyen";
            this.lblParcaBekleyen.Size = new System.Drawing.Size(60, 39);
            this.lblParcaBekleyen.TabIndex = 1;
            this.lblParcaBekleyen.Text = "100";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 19);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(225, 23);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Parça Bekleyen Ürün Sayısı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.pictureEdit3);
            this.panel3.Controls.Add(this.lblTadilatiBitmis);
            this.panel3.Controls.Add(this.labelControl5);
            this.panel3.Location = new System.Drawing.Point(1313, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 158);
            this.panel3.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel6.Controls.Add(this.pictureEdit6);
            this.panel6.Controls.Add(this.lblToplamUrun);
            this.panel6.Controls.Add(this.labelControl8);
            this.panel6.Location = new System.Drawing.Point(1313, 189);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 158);
            this.panel6.TabIndex = 14;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(160, 46);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Size = new System.Drawing.Size(64, 70);
            this.pictureEdit6.TabIndex = 2;
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUrun.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToplamUrun.Appearance.Options.UseFont = true;
            this.lblToplamUrun.Appearance.Options.UseForeColor = true;
            this.lblToplamUrun.Location = new System.Drawing.Point(83, 48);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(60, 39);
            this.lblToplamUrun.TabIndex = 1;
            this.lblToplamUrun.Text = "100";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(34, 17);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(161, 23);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Toplam Ürün Sayısı";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.pictureEdit7);
            this.panel7.Controls.Add(this.lblIptalEdilen);
            this.panel7.Controls.Add(this.labelControl10);
            this.panel7.Location = new System.Drawing.Point(1615, 189);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(273, 158);
            this.panel7.TabIndex = 15;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(167, 46);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Size = new System.Drawing.Size(82, 83);
            this.pictureEdit7.TabIndex = 2;
            // 
            // lblIptalEdilen
            // 
            this.lblIptalEdilen.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIptalEdilen.Appearance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIptalEdilen.Appearance.Options.UseFont = true;
            this.lblIptalEdilen.Appearance.Options.UseForeColor = true;
            this.lblIptalEdilen.Location = new System.Drawing.Point(83, 48);
            this.lblIptalEdilen.Name = "lblIptalEdilen";
            this.lblIptalEdilen.Size = new System.Drawing.Size(60, 39);
            this.lblIptalEdilen.TabIndex = 1;
            this.lblIptalEdilen.Text = "100";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(34, 17);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(167, 23);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "İptal Edilen İşlemler";
            // 
            // FormArizaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 811);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.gridList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "FormArizaListesi";
            this.Text = "FormArizaListesi";
            this.Load += new System.EventHandler(this.FormArizaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblMesajBeklenen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl lblMevcutAriza;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.LabelControl lblTadilatiBitmis;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.LabelControl lblParcaBekleyen;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.LabelControl lblToplamUrun;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.LabelControl lblIptalEdilen;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}