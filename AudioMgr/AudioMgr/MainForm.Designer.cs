namespace AudioMgr
{
    partial class MainForm
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
            DevExpress.XtraBars.Navigation.AccordionContextButton accordionContextButton1 = new DevExpress.XtraBars.Navigation.AccordionContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraBars.Navigation.AccordionContextButton accordionContextButton2 = new DevExpress.XtraBars.Navigation.AccordionContextButton();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement_mediaResp = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_localMusic = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_localVideo = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_localImg = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_list = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement_defaultList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(271, 46);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(632, 505);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement_mediaResp,
            this.accordionControlElement_list});
            this.accordionControl1.ExpandGroupOnHeaderClick = false;
            this.accordionControl1.Location = new System.Drawing.Point(0, 46);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ResizeMode = DevExpress.XtraBars.Navigation.AccordionControlResizeMode.InnerResizeZone;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowGroupExpandButtons = false;
            this.accordionControl1.Size = new System.Drawing.Size(271, 505);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.accordionControl1_ContextButtonClick);
            this.accordionControl1.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl1_ElementClick);
            // 
            // accordionControlElement_mediaResp
            // 
            accordionContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            accordionContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            accordionContextButton1.Id = new System.Guid("d5112bf6-e710-4d95-bd13-6afa34a27fc1");
            accordionContextButton1.ImageOptionsCollection.ItemNormal.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            accordionContextButton1.Name = "accordionContextButton_search";
            accordionContextButton1.Tag = "浏览";
            accordionContextButton1.ToolTip = "浏览";
            accordionContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
            this.accordionControlElement_mediaResp.ContextButtons.Add(accordionContextButton1);
            this.accordionControlElement_mediaResp.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement_localMusic,
            this.accordionControlElement_localVideo,
            this.accordionControlElement_localImg});
            this.accordionControlElement_mediaResp.Expanded = true;
            this.accordionControlElement_mediaResp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement_mediaResp.ImageOptions.Image")));
            this.accordionControlElement_mediaResp.Name = "accordionControlElement_mediaResp";
            this.accordionControlElement_mediaResp.Text = "媒体库";
            // 
            // accordionControlElement_localMusic
            // 
            this.accordionControlElement_localMusic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement_localMusic.ImageOptions.Image")));
            this.accordionControlElement_localMusic.Name = "accordionControlElement_localMusic";
            this.accordionControlElement_localMusic.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_localMusic.Tag = "";
            this.accordionControlElement_localMusic.Text = "本地音乐";
            // 
            // accordionControlElement_localVideo
            // 
            this.accordionControlElement_localVideo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement_localVideo.ImageOptions.Image")));
            this.accordionControlElement_localVideo.Name = "accordionControlElement_localVideo";
            this.accordionControlElement_localVideo.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_localVideo.Tag = "";
            this.accordionControlElement_localVideo.Text = "本地视频";
            // 
            // accordionControlElement_localImg
            // 
            this.accordionControlElement_localImg.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement_localImg.ImageOptions.Image")));
            this.accordionControlElement_localImg.Name = "accordionControlElement_localImg";
            this.accordionControlElement_localImg.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_localImg.Tag = "";
            this.accordionControlElement_localImg.Text = "本地图片";
            // 
            // accordionControlElement_list
            // 
            accordionContextButton2.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            accordionContextButton2.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            accordionContextButton2.Id = new System.Guid("b293ea1e-7936-4115-8ee3-57aea036c604");
            accordionContextButton2.ImageOptionsCollection.ItemNormal.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            accordionContextButton2.Name = "accordionContextButton_newList";
            accordionContextButton2.Tag = "新建列表";
            accordionContextButton2.ToolTip = "新建列表";
            accordionContextButton2.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
            this.accordionControlElement_list.ContextButtons.Add(accordionContextButton2);
            this.accordionControlElement_list.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement_defaultList});
            this.accordionControlElement_list.Expanded = true;
            this.accordionControlElement_list.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement_list.ImageOptions.Image")));
            this.accordionControlElement_list.Name = "accordionControlElement_list";
            this.accordionControlElement_list.Text = "列表";
            // 
            // accordionControlElement_defaultList
            // 
            this.accordionControlElement_defaultList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement_defaultList.ImageOptions.Image")));
            this.accordionControlElement_defaultList.Name = "accordionControlElement_defaultList";
            this.accordionControlElement_defaultList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement_defaultList.Tag = "";
            this.accordionControlElement_defaultList.Text = "默认列表";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(903, 46);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 551);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(903, 70);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.AutoSize = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(46, 44);
            this.simpleButton1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 621);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.Text = "媒体管理";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_mediaResp;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_localMusic;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_list;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_defaultList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_localVideo;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement_localImg;
        private System.Windows.Forms.Label label1;
    }
}