using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TeknikServisOtomasyon.Formlar
{
    public partial class FormQR : Form
    {
        public FormQR()
        {
            InitializeComponent();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(txtSerialNumber.Text);
        }

        private void cancelButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
