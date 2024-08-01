namespace JKS_HIGH
{
    partial class MainWindow
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainBtn_Exit = new System.Windows.Forms.Button();
            this.mainBtn_About = new System.Windows.Forms.Button();
            this.mainBtn_AllSHow = new System.Windows.Forms.Button();
            this.mainBtn_Data = new System.Windows.Forms.Button();
            this.MAIN = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.MAIN.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainBtn_Exit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mainBtn_About, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mainBtn_AllSHow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainBtn_Data, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 1080);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // mainBtn_Exit
            // 
            this.mainBtn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBtn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.mainBtn_Exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainBtn_Exit.FlatAppearance.BorderSize = 0;
            this.mainBtn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainBtn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBtn_Exit.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.mainBtn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("mainBtn_Exit.Image")));
            this.mainBtn_Exit.Location = new System.Drawing.Point(3, 907);
            this.mainBtn_Exit.Name = "mainBtn_Exit";
            this.mainBtn_Exit.Size = new System.Drawing.Size(224, 75);
            this.mainBtn_Exit.TabIndex = 4;
            this.mainBtn_Exit.Text = "  退出程序";
            this.mainBtn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainBtn_Exit.UseVisualStyleBackColor = false;
            this.mainBtn_Exit.Click += new System.EventHandler(this.mainBtn_Exit_Click);
            // 
            // mainBtn_About
            // 
            this.mainBtn_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBtn_About.BackColor = System.Drawing.Color.Transparent;
            this.mainBtn_About.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainBtn_About.FlatAppearance.BorderSize = 0;
            this.mainBtn_About.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainBtn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBtn_About.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.mainBtn_About.Image = ((System.Drawing.Image)(resources.GetObject("mainBtn_About.Image")));
            this.mainBtn_About.Location = new System.Drawing.Point(3, 637);
            this.mainBtn_About.Name = "mainBtn_About";
            this.mainBtn_About.Size = new System.Drawing.Size(224, 75);
            this.mainBtn_About.TabIndex = 3;
            this.mainBtn_About.Text = "  设置面板";
            this.mainBtn_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainBtn_About.UseVisualStyleBackColor = false;
            this.mainBtn_About.Click += new System.EventHandler(this.mainBtn_About_Click);
            // 
            // mainBtn_AllSHow
            // 
            this.mainBtn_AllSHow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBtn_AllSHow.BackColor = System.Drawing.Color.Transparent;
            this.mainBtn_AllSHow.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainBtn_AllSHow.FlatAppearance.BorderSize = 0;
            this.mainBtn_AllSHow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainBtn_AllSHow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBtn_AllSHow.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainBtn_AllSHow.Image = ((System.Drawing.Image)(resources.GetObject("mainBtn_AllSHow.Image")));
            this.mainBtn_AllSHow.Location = new System.Drawing.Point(3, 97);
            this.mainBtn_AllSHow.Name = "mainBtn_AllSHow";
            this.mainBtn_AllSHow.Size = new System.Drawing.Size(224, 75);
            this.mainBtn_AllSHow.TabIndex = 1;
            this.mainBtn_AllSHow.Text = "  全局监控";
            this.mainBtn_AllSHow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainBtn_AllSHow.UseVisualStyleBackColor = false;
            this.mainBtn_AllSHow.Click += new System.EventHandler(this.mainBtn_AllSHow_Click);
            // 
            // mainBtn_Data
            // 
            this.mainBtn_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBtn_Data.BackColor = System.Drawing.Color.Transparent;
            this.mainBtn_Data.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainBtn_Data.FlatAppearance.BorderSize = 0;
            this.mainBtn_Data.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainBtn_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainBtn_Data.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.mainBtn_Data.Image = ((System.Drawing.Image)(resources.GetObject("mainBtn_Data.Image")));
            this.mainBtn_Data.Location = new System.Drawing.Point(3, 367);
            this.mainBtn_Data.Name = "mainBtn_Data";
            this.mainBtn_Data.Size = new System.Drawing.Size(224, 75);
            this.mainBtn_Data.TabIndex = 2;
            this.mainBtn_Data.Text = "  数据分析";
            this.mainBtn_Data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mainBtn_Data.UseVisualStyleBackColor = false;
            this.mainBtn_Data.Click += new System.EventHandler(this.mainBtn_Data_Click);
            // 
            // MAIN
            // 
            this.MAIN.Controls.Add(this.label1);
            this.MAIN.Dock = System.Windows.Forms.DockStyle.Right;
            this.MAIN.Location = new System.Drawing.Point(232, 0);
            this.MAIN.Margin = new System.Windows.Forms.Padding(0);
            this.MAIN.Name = "MAIN";
            this.MAIN.Size = new System.Drawing.Size(1688, 1080);
            this.MAIN.TabIndex = 4;
            this.MAIN.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1080);
            this.panel2.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(186, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1312, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "基于压力传感器的山区铁路边滑坡监测预警系统软件\r\n";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MAIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MAIN.ResumeLayout(false);
            this.MAIN.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mainBtn_AllSHow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mainBtn_Data;
        private System.Windows.Forms.Panel MAIN;
        private System.Windows.Forms.Button mainBtn_About;
        private System.Windows.Forms.Button mainBtn_Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

