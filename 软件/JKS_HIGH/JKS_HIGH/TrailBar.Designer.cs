namespace JKS_HIGH
{
    partial class TrailBar
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
            this.components = new System.ComponentModel.Container();
            this.severText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.severStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sysTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // severText
            // 
            this.severText.AutoSize = true;
            this.severText.Location = new System.Drawing.Point(1534, 6);
            this.severText.Name = "severText";
            this.severText.Size = new System.Drawing.Size(23, 12);
            this.severText.TabIndex = 1;
            this.severText.Text = "- -";
            this.severText.Click += new System.EventHandler(this.severText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1463, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器状态";
            // 
            // severStatus
            // 
            this.severStatus.AutoSize = true;
            this.severStatus.ForeColor = System.Drawing.Color.Green;
            this.severStatus.Location = new System.Drawing.Point(1630, 6);
            this.severStatus.Name = "severStatus";
            this.severStatus.Size = new System.Drawing.Size(41, 12);
            this.severStatus.TabIndex = 2;
            this.severStatus.Text = "已连接";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sysTime
            // 
            this.sysTime.AutoSize = true;
            this.sysTime.Location = new System.Drawing.Point(1331, 6);
            this.sysTime.Name = "sysTime";
            this.sysTime.Size = new System.Drawing.Size(23, 12);
            this.sysTime.TabIndex = 3;
            this.sysTime.Text = "- -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(977, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "当前报警临界值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(1074, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "30.00kg";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1155, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "当前时间范围：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(1250, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "30s内";
            // 
            // TrailBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sysTime);
            this.Controls.Add(this.severStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.severText);
            this.Name = "TrailBar";
            this.Size = new System.Drawing.Size(1688, 30);
            this.Load += new System.EventHandler(this.TrailBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label severText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label severStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sysTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
