using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioMgr
{
    public partial class TestForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            accordionControl1.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Inline;
        }

        private void TestForm_SizeChanged(object sender, EventArgs e)
        {
            this.Text = this.Width + " - " + this.Height;
        }


    }
}
