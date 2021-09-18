namespace AudioMgr.Control
{
    partial class PlayPane
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayPane));
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.preview = new DevExpress.XtraEditors.SimpleButton();
            this.play = new DevExpress.XtraEditors.SimpleButton();
            this.next = new DevExpress.XtraEditors.SimpleButton();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.playmode = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.AllowFocus = false;
            this.preview.AutoSize = true;
            this.preview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("preview.ImageOptions.SvgImage")));
            this.preview.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.preview.Location = new System.Drawing.Point(3, 25);
            this.preview.Name = "preview";
            this.preview.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.preview.Size = new System.Drawing.Size(48, 46);
            this.preview.TabIndex = 1;
            this.preview.ToolTip = "上一首";
            // 
            // play
            // 
            this.play.AllowFocus = false;
            this.play.AutoSize = true;
            this.play.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("play.ImageOptions.SvgImage")));
            this.play.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.play.Location = new System.Drawing.Point(57, 25);
            this.play.Name = "play";
            this.play.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.play.Size = new System.Drawing.Size(48, 46);
            this.play.TabIndex = 2;
            this.play.ToolTip = "上一首";
            // 
            // next
            // 
            this.next.AllowFocus = false;
            this.next.AutoSize = true;
            this.next.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("next.ImageOptions.SvgImage")));
            this.next.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.next.Location = new System.Drawing.Point(111, 25);
            this.next.Name = "next";
            this.next.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.next.Size = new System.Drawing.Size(48, 46);
            this.next.TabIndex = 3;
            this.next.ToolTip = "上一首";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl1.Location = new System.Drawing.Point(189, 65);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.DisplayFormat.FormatString = "{0}";
            this.progressBarControl1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.progressBarControl1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.progressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.progressBarControl1.Properties.ReadOnly = true;
            this.progressBarControl1.Size = new System.Drawing.Size(204, 10);
            this.progressBarControl1.TabIndex = 5;
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarControl1.EditValue = null;
            this.trackBarControl1.Location = new System.Drawing.Point(467, 3);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Properties.LabelAppearance.ForeColor = System.Drawing.Color.White;
            this.trackBarControl1.Properties.LabelAppearance.Options.UseForeColor = true;
            this.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "0";
            trackBarLabel2.Label = "100";
            trackBarLabel2.Value = 100;
            this.trackBarControl1.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1,
            trackBarLabel2});
            this.trackBarControl1.Properties.LargeChange = 1;
            this.trackBarControl1.Properties.Maximum = 100;
            this.trackBarControl1.Properties.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarControl1.Properties.ShowLabels = true;
            this.trackBarControl1.Properties.ShowValueToolTip = true;
            this.trackBarControl1.Properties.TickFrequency = 20;
            this.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarControl1.Size = new System.Drawing.Size(94, 92);
            this.trackBarControl1.TabIndex = 4;
            this.trackBarControl1.ToolTip = "音量";
            // 
            // playmode
            // 
            this.playmode.AllowFocus = false;
            this.playmode.AutoSize = true;
            this.playmode.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("playmode.ImageOptions.SvgImage")));
            this.playmode.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.playmode.Location = new System.Drawing.Point(408, 29);
            this.playmode.Name = "playmode";
            this.playmode.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.playmode.Size = new System.Drawing.Size(48, 46);
            this.playmode.TabIndex = 6;
            this.playmode.ToolTip = "播放模式";
            // 
            // PlayPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.playmode);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.trackBarControl1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.play);
            this.Controls.Add(this.preview);
            this.Name = "PlayPane";
            this.Size = new System.Drawing.Size(561, 98);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton preview;
        private DevExpress.XtraEditors.SimpleButton play;
        private DevExpress.XtraEditors.SimpleButton next;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.SimpleButton playmode;
    }
}
