namespace JKS_HIGH
{
    partial class DetectForAll
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetectForAll));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_5s = new System.Windows.Forms.RadioButton();
            this.radioButton_10s = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton_2s = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnDCon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sysTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.retryBtn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "监控台管理";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.radioButton_5s);
            this.groupBox2.Controls.Add(this.radioButton_10s);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.radioButton_2s);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(352, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 275);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "刷新设置";
            // 
            // radioButton_5s
            // 
            this.radioButton_5s.AutoSize = true;
            this.radioButton_5s.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.radioButton_5s.Location = new System.Drawing.Point(21, 73);
            this.radioButton_5s.Name = "radioButton_5s";
            this.radioButton_5s.Size = new System.Drawing.Size(60, 29);
            this.radioButton_5s.TabIndex = 8;
            this.radioButton_5s.Text = "5秒";
            this.radioButton_5s.UseVisualStyleBackColor = true;
            // 
            // radioButton_10s
            // 
            this.radioButton_10s.AutoSize = true;
            this.radioButton_10s.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.radioButton_10s.Location = new System.Drawing.Point(21, 108);
            this.radioButton_10s.Name = "radioButton_10s";
            this.radioButton_10s.Size = new System.Drawing.Size(71, 29);
            this.radioButton_10s.TabIndex = 6;
            this.radioButton_10s.Text = "10秒";
            this.radioButton_10s.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 16.75F);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(6, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 75);
            this.button4.TabIndex = 8;
            this.button4.Text = "立即刷新";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton_2s
            // 
            this.radioButton_2s.AutoSize = true;
            this.radioButton_2s.Checked = true;
            this.radioButton_2s.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.radioButton_2s.Location = new System.Drawing.Point(21, 37);
            this.radioButton_2s.Name = "radioButton_2s";
            this.radioButton_2s.Size = new System.Drawing.Size(60, 29);
            this.radioButton_2s.TabIndex = 5;
            this.radioButton_2s.TabStop = true;
            this.radioButton_2s.Text = "2秒";
            this.radioButton_2s.UseVisualStyleBackColor = true;
            this.radioButton_2s.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCon);
            this.groupBox1.Controls.Add(this.btnDCon);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(26, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 157);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "活动统计";
            // 
            // btnCon
            // 
            this.btnCon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCon.BackColor = System.Drawing.Color.Transparent;
            this.btnCon.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCon.FlatAppearance.BorderSize = 0;
            this.btnCon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCon.Font = new System.Drawing.Font("微软雅黑", 20.75F);
            this.btnCon.Image = ((System.Drawing.Image)(resources.GetObject("btnCon.Image")));
            this.btnCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCon.Location = new System.Drawing.Point(27, 25);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(125, 75);
            this.btnCon.TabIndex = 11;
            this.btnCon.Text = "  0";
            this.btnCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCon.UseVisualStyleBackColor = false;
            // 
            // btnDCon
            // 
            this.btnDCon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDCon.BackColor = System.Drawing.Color.Transparent;
            this.btnDCon.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDCon.FlatAppearance.BorderSize = 0;
            this.btnDCon.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDCon.Font = new System.Drawing.Font("微软雅黑", 20.75F);
            this.btnDCon.Image = ((System.Drawing.Image)(resources.GetObject("btnDCon.Image")));
            this.btnDCon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDCon.Location = new System.Drawing.Point(158, 25);
            this.btnDCon.Name = "btnDCon";
            this.btnDCon.Size = new System.Drawing.Size(125, 75);
            this.btnDCon.TabIndex = 12;
            this.btnDCon.Text = "  24";
            this.btnDCon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDCon.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 352);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sysTime);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.25F);
            this.groupBox4.Location = new System.Drawing.Point(26, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 66);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "系统时间";
            // 
            // sysTime
            // 
            this.sysTime.AutoSize = true;
            this.sysTime.Location = new System.Drawing.Point(85, 27);
            this.sysTime.Name = "sysTime";
            this.sysTime.Size = new System.Drawing.Size(101, 20);
            this.sysTime.TabIndex = 0;
            this.sysTime.Text = "127.0.0.1:3333";
            this.sysTime.Click += new System.EventHandler(this.sysTime_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.retryBtn);
            this.groupBox3.Controls.Add(this.status);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.25F);
            this.groupBox3.Location = new System.Drawing.Point(26, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 75);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "服务器状态";
            // 
            // retryBtn
            // 
            this.retryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.retryBtn.BackColor = System.Drawing.Color.Transparent;
            this.retryBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.retryBtn.FlatAppearance.BorderSize = 0;
            this.retryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.retryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retryBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.retryBtn.ForeColor = System.Drawing.Color.Black;
            this.retryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.retryBtn.Location = new System.Drawing.Point(256, 27);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Size = new System.Drawing.Size(45, 25);
            this.retryBtn.TabIndex = 13;
            this.retryBtn.Text = "重试";
            this.retryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.retryBtn.UseVisualStyleBackColor = false;
            this.retryBtn.Visible = false;
            this.retryBtn.Click += new System.EventHandler(this.retryBtn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Green;
            this.status.Location = new System.Drawing.Point(204, 30);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(51, 20);
            this.status.TabIndex = 1;
            this.status.Text = "已连接";
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "114.215.181.67:3333";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DetectForAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 352);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetectForAll";
            this.Text = "DetectForAll";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_5s;
        private System.Windows.Forms.RadioButton radioButton_10s;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton_2s;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnDCon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label sysTime;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button retryBtn;
    }
}