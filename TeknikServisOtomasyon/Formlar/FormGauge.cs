using System;
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
    public partial class FormGauge : Form
    {
        public FormGauge()
        {
            InitializeComponent();
        }

        private void FormGauge_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arcScaleComponent1.Value += 5;
            arcScaleComponent2.Value += 5;
            arcScaleComponent4.Value += 5;
            labelComponent2.Text = arcScaleComponent4.Value.ToString();
            arcScaleComponent5.Value += 5;
            if (arcScaleComponent1.Value == 100 && arcScaleComponent2.Value == 100 && arcScaleComponent4.Value == 100 && arcScaleComponent5.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            arcScaleComponent1.Value -= 5;
            arcScaleComponent2.Value -= 5;
            arcScaleComponent4.Value -= 5;
            labelComponent2.Text = arcScaleComponent4.Value.ToString();
            arcScaleComponent5.Value -= 5;
            if (arcScaleComponent1.Value == 0 && arcScaleComponent2.Value == 0 && arcScaleComponent4.Value == 0 && arcScaleComponent5.Value == 0)
            {
                timer2.Stop();
                timer1.Start();
            }
        }
    }
}
