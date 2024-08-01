namespace JKS_HIGH
{
    partial class Rail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rail));
            this.ImgBtn = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ImgBtn
            // 
            this.ImgBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgBtn.BackColor = System.Drawing.Color.Transparent;
            this.ImgBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ImgBtn.FlatAppearance.BorderSize = 0;
            this.ImgBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBtn.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ImgBtn.Image = ((System.Drawing.Image)(resources.GetObject("ImgBtn.Image")));
            this.ImgBtn.Location = new System.Drawing.Point(0, 0);
            this.ImgBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ImgBtn.Name = "ImgBtn";
            this.ImgBtn.Size = new System.Drawing.Size(108, 102);
            this.ImgBtn.TabIndex = 3;
            this.ImgBtn.Text = " ";
            this.ImgBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImgBtn.UseVisualStyleBackColor = false;
            // 
            // sort
            // 
            this.sort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sort.AutoSize = true;
            this.sort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sort.ForeColor = System.Drawing.Color.Black;
            this.sort.Location = new System.Drawing.Point(34, 102);
            this.sort.Margin = new System.Windows.Forms.Padding(0);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(41, 22);
            this.sort.TabIndex = 5;
            this.sort.Text = "PT1";
            // 
            // data
            // 
            this.data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.data.ForeColor = System.Drawing.Color.Red;
            this.data.Location = new System.Drawing.Point(17, 139);
            this.data.Margin = new System.Windows.Forms.Padding(0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(58, 21);
            this.data.TabIndex = 6;
            this.data.Text = "已断开";
            // 
            // Rail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.data);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.ImgBtn);
            this.DoubleBuffered = true;
            this.Name = "Rail";
            this.Size = new System.Drawing.Size(108, 180);
            this.Load += new System.EventHandler(this.Rail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImgBtn;
        private System.Windows.Forms.Label sort;
        private System.Windows.Forms.Label data;
    }
}
