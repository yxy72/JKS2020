namespace JKS_HIGH
{
    partial class PT
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
            this.data = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.sort = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.SystemColors.ControlLight;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.data.ForeColor = System.Drawing.Color.Black;
            this.data.Location = new System.Drawing.Point(0, 144);
            this.data.Margin = new System.Windows.Forms.Padding(0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(216, 36);
            this.data.TabIndex = 5;
            this.data.Text = "none";
            this.data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.data, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.sort, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(216, 180);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // sort
            // 
            this.sort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sort.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sort.Cursor = System.Windows.Forms.Cursors.Default;
            this.sort.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sort.ForeColor = System.Drawing.Color.Black;
            this.sort.Location = new System.Drawing.Point(0, 108);
            this.sort.Margin = new System.Windows.Forms.Padding(0);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(216, 36);
            this.sort.TabIndex = 4;
            this.sort.Text = "PTX";
            this.sort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn.BackgroundImage = global::JKS_HIGH.Properties.Resources.iconMain2_96px;
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.Location = new System.Drawing.Point(3, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(210, 102);
            this.btn.TabIndex = 6;
            this.btn.TabStop = false;
            this.btn.Click += new System.EventHandler(this.btn_Click_1);
            // 
            // PT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "PT";
            this.Size = new System.Drawing.Size(216, 180);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label sort;
        private System.Windows.Forms.PictureBox btn;
    }
}
