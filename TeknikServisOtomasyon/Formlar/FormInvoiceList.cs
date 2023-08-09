﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormInvoiceList : Form
    {
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        public FormInvoiceList()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            gridList.DataSource = db.TBLFATURABILGIs.ToList();
            var degerler = from u in db.TBLFATURABILGIs
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARI = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD
                           };
            cmbCustomer.Properties.DataSource = (from x in db.TBLCARIs
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            cmbPersonal.Properties.DataSource = (from x in db.TBLPERSONELs
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }
        private void FormInvoiceList_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = txtSerialNumber.Text;
            t.SIRANO = txtLineNumber.Text;
            t.TARIH = dateInvoice.Value;
            t.SAAT = timeInvoice.Text;
            t.CARI = int.Parse(cmbCustomer.EditValue.ToString());
            t.PERSONEL = short.Parse(cmbPersonal.EditValue.ToString());
            t.VERGIDAIRE = txtTax.Text;
            db.TBLFATURABILGIs.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura sisteme kaydedilmiştir. Kalem girişi yapabilirsiniz !");
        }
    }
}
