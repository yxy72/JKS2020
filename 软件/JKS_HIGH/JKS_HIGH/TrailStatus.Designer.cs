namespace JKS_HIGH
{
    partial class TrailStatus
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnEnlarge = new System.Windows.Forms.Button();
            this.btnShrink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::JKS_HIGH.Properties.Resources._;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(364, -12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "ghfhg";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnlarge
            // 
            this.btnEnlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnlarge.BackColor = System.Drawing.Color.Transparent;
            this.btnEnlarge.BackgroundImage = global::JKS_HIGH.Properties.Resources._;
            this.btnEnlarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnlarge.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnlarge.FlatAppearance.BorderSize = 0;
            this.btnEnlarge.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEnlarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnlarge.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnlarge.Location = new System.Drawing.Point(19, 4);
            this.btnEnlarge.Name = "btnEnlarge";
            this.btnEnlarge.Size = new System.Drawing.Size(27, 27);
            this.btnEnlarge.TabIndex = 2;
            this.btnEnlarge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnlarge.UseVisualStyleBackColor = false;
            // 
            // btnShrink
            // 
            this.btnShrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShrink.BackColor = System.Drawing.Color.Transparent;
            this.btnShrink.BackgroundImage = global::JKS_HIGH.Properties.Resources.minus;
            this.btnShrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShrink.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnShrink.FlatAppearance.BorderSize = 0;
            this.btnShrink.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnShrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShrink.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShrink.Location = new System.Drawing.Point(56, 4);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(27, 27);
            this.btnShrink.TabIndex = 2;
            this.btnShrink.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShrink.UseVisualStyleBackColor = false;
            // 
            // TrailStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnShrink);
            this.Controls.Add(this.btnEnlarge);
            this.Controls.Add(this.button1);
            this.Name = "TrailStatus";
            this.Size = new System.Drawing.Size(1699, 32);
            this.Load += new System.EventHandler(this.TrailStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEnlarge;
        private System.Windows.Forms.Button btnShrink;
    }
}
