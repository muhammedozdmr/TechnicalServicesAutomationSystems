using DevExpress.Pdf.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeknikServisOtomasyon
{
    public partial class TeknikServisForm : DevExpress.XtraEditors.XtraForm
    {
        public TeknikServisForm()
        {
            InitializeComponent();
        }

        //private void OpenChildForm(Form childForm)
        //{
        //    TabPage tabPage = new TabPage(childForm.Text);
        //    tabPage.Tag = childForm;

        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    tabPage.Controls.Add(childForm);
        //    childForm.Show();

        //    tabControl1.TabPages.Add(tabPage);
        //}
        private void barProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormProductList formProduct = new Formlar.FormProductList();
            formProduct.MdiParent = this;
            formProduct.Show();
        }

        private void barNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCreateProduct formProduct = new Formlar.FormCreateProduct();
            formProduct.MdiParent = this;
            formProduct.Show();
        }

        private void barCategoryList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCategoryList formCategory = new Formlar.FormCategoryList();
            formCategory.MdiParent = this;
            formCategory.Show();
        }

        private void barNewCategory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCreateCategory formCreateCategory = new Formlar.FormCreateCategory();  
            formCreateCategory.MdiParent = this;
            formCreateCategory.Show();
        }

        private void barProductStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.ForrmStatistics formStatisticList = new Formlar.ForrmStatistics();
            formStatisticList.MdiParent = this;
            formStatisticList.Show();
        }

        private void barMarkStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormBrand formBrand = new Formlar.FormBrand();
            formBrand.MdiParent = this;
            formBrand.Show();
        }

        private void barCustomerList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCustomerList formCustomer = new Formlar.FormCustomerList();
            formCustomer.MdiParent = this;
            formCustomer.Show();
        }

        private void barCustomerCityStatistics_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCustomerCity formCustomerCity = new Formlar.FormCustomerCity();
            formCustomerCity.MdiParent = this;
            formCustomerCity.Show();
        }

        private void barNewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCreateCustomer formCreateCustomer = new Formlar.FormCreateCustomer();
            //formCreateCustomer.MdiParent = this;
            formCreateCustomer.Show();
        }

        private void barDepartmantList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormDeparmentList formDepartment = new Formlar.FormDeparmentList();
            formDepartment.MdiParent = this;
            formDepartment.Show();
        }

        private void barNewDepartmant_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCreateDepartment formDepartment = new Formlar.FormCreateDepartment();
            //formDepartment.MdiParent = this;
            formDepartment.Show();
        }

        private void barEmployeeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormEmployee formEmployee = new Formlar.FormEmployee();
            formEmployee.MdiParent = this;
            formEmployee.Show();
        }

        private void barCalculator_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void barCurrency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormCurrencies formCurrencies= new Formlar.FormCurrencies();
            formCurrencies.MdiParent = this;
            formCurrencies.Show();
        }

        private void barWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void barExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void barYouTube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormYoutube formYoutube = new Formlar.FormYoutube();
            formYoutube.MdiParent = this;
            formYoutube.Show();
        }

        private void barAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormNotes formNotes = new Formlar.FormNotes();
            formNotes.MdiParent = this;
            formNotes.Show();
        }

        private void barBrokenProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormArizaListesi formAriza= new Formlar.FormArizaListesi();
            formAriza.MdiParent = this;
            formAriza.Show();
        }

        private void barNewProductSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormProductSale formSale = new Formlar.FormProductSale();
            //formSale.MdiParent = this;
            formSale.Show();
        }

        private void barNewBrokenProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormBrokeProductSave formBroken= new Formlar.FormBrokeProductSave();
            //formSale.MdiParent = this;
            formBroken.Show();
        }

        private void barBrokenProductInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormArizaDetaylar formAriza = new Formlar.FormArizaDetaylar();
            formAriza.Show();
        }

        private void barCreateQR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormQR formQR = new Formlar.FormQR();
            formQR.Show();
        }

        private void barArizaliUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormArizaListesi formArizaDetay = new Formlar.FormArizaListesi();
            formArizaDetay.MdiParent = this;
            formArizaDetay.Show();
        }

        private void barInvoiceList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormInvoiceList formFaturaListesi = new Formlar.FormInvoiceList();
            formFaturaListesi.MdiParent = this;
            formFaturaListesi.Show();
        }

        private void barNewInvoiceSection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaKalemi formFaturaKalem = new Formlar.FormFaturaKalemi();
            formFaturaKalem.MdiParent = this;
            formFaturaKalem.Show();
        }

        private void barSearchInvoiceDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FormFaturaKalemDetaylari formFaturaKalemDetay = new Formlar.FormFaturaKalemDetaylari();
            formFaturaKalemDetay.MdiParent = this;
            formFaturaKalemDetay.Show();
        }
    }
}
