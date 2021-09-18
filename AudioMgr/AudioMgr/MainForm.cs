using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioMgr.Control;

namespace AudioMgr
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region load - 初始化
        private void MainForm_Load(object sender, EventArgs e)
        {
            //设置Accordioncontrol一直显示
            this.OptionsAdaptiveLayout.InlineModeThreshold = 0;
            this.OptionsAdaptiveLayout.OverlayModeThreshold = 0;
            this.accordionControl1.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Inline;
        }
        #endregion

        #region accordionControl - 项单击事件
        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            showContainer(e.Element.Text);
        }
        #endregion

        #region ContextButton - 单击事件
        private void accordionControl1_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            showContainer(e.Item.Tag.ToString());
        }
        #endregion 

        #region 容器显示方法
        private void showContainer(string name)
        {
            //清空容器
            this.fluentDesignFormContainer1.Controls.Clear();
            UserControl control;
            switch (name)
            {
                case "本地音乐":
                    control = new UserControlLocalMusic();
                    control.Dock = DockStyle.Fill;
                    this.fluentDesignFormContainer1.Controls.Add(control);
                    break;
                case "本地视频":
                    control = new UserControlLocalVideo();
                    control.Dock = DockStyle.Fill;
                    this.fluentDesignFormContainer1.Controls.Add(control);
                    break;
                case "本地图片":
                    control = new UserControlLocalImg();
                    control.Dock = DockStyle.Fill;
                    this.fluentDesignFormContainer1.Controls.Add(control);
                    break;
                case "默认列表":
                    control = new UserControlDefaultList();
                    control.Dock = DockStyle.Fill;
                    this.fluentDesignFormContainer1.Controls.Add(control);
                    break;

                case "浏览":
                    control = new UserControlSearch();
                    control.Dock = DockStyle.Fill;
                    this.fluentDesignFormContainer1.Controls.Add(control);
                    break;
                case "新建列表":
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
