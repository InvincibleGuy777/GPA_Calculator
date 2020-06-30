namespace GPA_Calculator_Plus
{
    partial class aboutForm
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
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_Info = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_aboutFormOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_title.Location = new System.Drawing.Point(12, 6);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(202, 47);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "About Me";
            // 
            // textBox_Info
            // 
            this.textBox_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textBox_Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Info.CausesValidation = false;
            this.textBox_Info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_Info.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox_Info.Location = new System.Drawing.Point(211, 67);
            this.textBox_Info.Multiline = true;
            this.textBox_Info.Name = "textBox_Info";
            this.textBox_Info.ReadOnly = true;
            this.textBox_Info.ShortcutsEnabled = false;
            this.textBox_Info.Size = new System.Drawing.Size(361, 363);
            this.textBox_Info.TabIndex = 7;
            this.textBox_Info.TabStop = false;
            this.textBox_Info.Text = "作者：圣☆哥\r\nTEL：15873361792\r\nQQ：2540588513@qq.com\r\nIDE: VisualStudio2017\r\n程序类型：Winfor" +
    "m(C#)\r\n作品名称：GPA计算器\r\n版本号：2.0.1\r\n作品序号：002\r\n完成时间：2020-06-28\r\n地点：西安交通大学东三#708\r\n\r\n\r\n\r" +
    "\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GPA_Calculator_Plus.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(65, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::GPA_Calculator_Plus.Properties.Resources.timor1;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(355, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // button_aboutFormOK
            // 
            this.button_aboutFormOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_aboutFormOK.FlatAppearance.BorderSize = 0;
            this.button_aboutFormOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_aboutFormOK.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold);
            this.button_aboutFormOK.Location = new System.Drawing.Point(487, 404);
            this.button_aboutFormOK.Name = "button_aboutFormOK";
            this.button_aboutFormOK.Size = new System.Drawing.Size(85, 34);
            this.button_aboutFormOK.TabIndex = 10;
            this.button_aboutFormOK.Text = "确定";
            this.button_aboutFormOK.UseVisualStyleBackColor = false;
            this.button_aboutFormOK.Click += new System.EventHandler(this.button_aboutFormOK_Click);
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.button_aboutFormOK);
            this.Controls.Add(this.textBox_Info);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_Info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_aboutFormOK;
    }
}