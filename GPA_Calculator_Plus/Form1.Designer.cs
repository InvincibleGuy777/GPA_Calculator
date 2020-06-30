namespace GPA_Calculator_Plus
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.Picbox_Logo = new System.Windows.Forms.PictureBox();
            this.miniBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsb_data_import = new System.Windows.Forms.ToolStripButton();
            this.tsb_data_export = new System.Windows.Forms.ToolStripButton();
            this.tsb_help = new System.Windows.Forms.ToolStripButton();
            this.tsb_about = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Calc = new System.Windows.Forms.Button();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_Output = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.Picbox_Logo);
            this.panel1.Controls.Add(this.miniBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 78);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(454, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "ver 2.0.1";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_title.Location = new System.Drawing.Point(88, 14);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(294, 47);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "GPA Calculator";
            // 
            // Picbox_Logo
            // 
            this.Picbox_Logo.BackgroundImage = global::GPA_Calculator_Plus.Properties.Resources.icon1;
            this.Picbox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picbox_Logo.Location = new System.Drawing.Point(7, 6);
            this.Picbox_Logo.Name = "Picbox_Logo";
            this.Picbox_Logo.Size = new System.Drawing.Size(64, 64);
            this.Picbox_Logo.TabIndex = 4;
            this.Picbox_Logo.TabStop = false;
            // 
            // miniBtn
            // 
            this.miniBtn.BackColor = System.Drawing.Color.DimGray;
            this.miniBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("miniBtn.BackgroundImage")));
            this.miniBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.miniBtn.FlatAppearance.BorderSize = 0;
            this.miniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.miniBtn.Location = new System.Drawing.Point(613, 14);
            this.miniBtn.Name = "miniBtn";
            this.miniBtn.Size = new System.Drawing.Size(45, 45);
            this.miniBtn.TabIndex = 3;
            this.miniBtn.UseVisualStyleBackColor = false;
            this.miniBtn.Click += new System.EventHandler(this.miniBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(683, 14);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(45, 45);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 60);
            this.panel2.TabIndex = 3;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.CanOverflow = false;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(750, 39);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_data_import,
            this.tsb_data_export,
            this.tsb_help,
            this.tsb_about});
            // 
            // tsb_data_import
            // 
            this.tsb_data_import.Font = new System.Drawing.Font("黑体", 12F);
            this.tsb_data_import.ForeColor = System.Drawing.Color.White;
            this.tsb_data_import.Image = global::GPA_Calculator_Plus.Properties.Resources.logo7;
            this.tsb_data_import.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_data_import.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsb_data_import.Name = "tsb_data_import";
            this.tsb_data_import.Size = new System.Drawing.Size(142, 36);
            this.tsb_data_import.Text = "导入数据";
            this.tsb_data_import.Click += new System.EventHandler(this.tsb_data_import_Click);
            // 
            // tsb_data_export
            // 
            this.tsb_data_export.Font = new System.Drawing.Font("黑体", 12F);
            this.tsb_data_export.ForeColor = System.Drawing.Color.White;
            this.tsb_data_export.Image = global::GPA_Calculator_Plus.Properties.Resources.logo6;
            this.tsb_data_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_data_export.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsb_data_export.Name = "tsb_data_export";
            this.tsb_data_export.Size = new System.Drawing.Size(142, 36);
            this.tsb_data_export.Text = "导出数据";
            this.tsb_data_export.Click += new System.EventHandler(this.tsb_data_export_Click);
            // 
            // tsb_help
            // 
            this.tsb_help.Font = new System.Drawing.Font("黑体", 12F);
            this.tsb_help.ForeColor = System.Drawing.Color.White;
            this.tsb_help.Image = global::GPA_Calculator_Plus.Properties.Resources.logo3;
            this.tsb_help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_help.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.tsb_help.Name = "tsb_help";
            this.tsb_help.Size = new System.Drawing.Size(94, 36);
            this.tsb_help.Text = "帮助";
            this.tsb_help.Click += new System.EventHandler(this.tsb_help_Click);
            // 
            // tsb_about
            // 
            this.tsb_about.Font = new System.Drawing.Font("黑体", 12F);
            this.tsb_about.ForeColor = System.Drawing.Color.White;
            this.tsb_about.Image = global::GPA_Calculator_Plus.Properties.Resources.logo4;
            this.tsb_about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_about.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.tsb_about.Name = "tsb_about";
            this.tsb_about.Size = new System.Drawing.Size(94, 36);
            this.tsb_about.Text = "关于";
            this.tsb_about.Click += new System.EventHandler(this.tsb_about_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 294);
            this.panel3.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(750, 294);
            this.dataGridView.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel4.Controls.Add(this.button_clear);
            this.panel4.Controls.Add(this.button_delete);
            this.panel4.Controls.Add(this.button_Calc);
            this.panel4.Controls.Add(this.textBox_Output);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label_Output);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 432);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(750, 168);
            this.panel4.TabIndex = 5;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_clear.FlatAppearance.BorderSize = 0;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold);
            this.button_clear.Location = new System.Drawing.Point(495, 0);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(85, 34);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "清空";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold);
            this.button_delete.Location = new System.Drawing.Point(580, 0);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(85, 34);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Calc
            // 
            this.button_Calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Calc.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Calc.FlatAppearance.BorderSize = 0;
            this.button_Calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Calc.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold);
            this.button_Calc.Location = new System.Drawing.Point(665, 0);
            this.button_Calc.Name = "button_Calc";
            this.button_Calc.Size = new System.Drawing.Size(85, 34);
            this.button_Calc.TabIndex = 8;
            this.button_Calc.Text = "计算";
            this.button_Calc.UseVisualStyleBackColor = false;
            // 
            // textBox_Output
            // 
            this.textBox_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.textBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_Output.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_Output.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox_Output.Location = new System.Drawing.Point(0, 34);
            this.textBox_Output.Multiline = true;
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.ReadOnly = true;
            this.textBox_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Output.Size = new System.Drawing.Size(750, 105);
            this.textBox_Output.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 29);
            this.panel5.TabIndex = 5;
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Font = new System.Drawing.Font("黑体", 10F);
            this.label_Output.ForeColor = System.Drawing.Color.White;
            this.label_Output.Location = new System.Drawing.Point(4, 6);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(89, 20);
            this.label_Output.TabIndex = 2;
            this.label_Output.Text = "结果列表";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPA计算器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox_Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button miniBtn;
        private System.Windows.Forms.PictureBox Picbox_Logo;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsb_data_export;
        private System.Windows.Forms.ToolStripButton tsb_help;
        private System.Windows.Forms.ToolStripButton tsb_about;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Button button_Calc;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripButton tsb_data_import;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
    }
}

