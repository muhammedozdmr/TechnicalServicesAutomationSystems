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
    }
}
