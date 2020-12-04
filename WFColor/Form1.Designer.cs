namespace WFColor
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_16 = new System.Windows.Forms.TextBox();
            this.txt_rgb = new System.Windows.Forms.TextBox();
            this.copy = new System.Windows.Forms.Button();
            this.copyrgb = new System.Windows.Forms.Button();
            this.lbl02 = new System.Windows.Forms.Label();
            this.lbl01 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Location = new System.Drawing.Point(16, 30);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(23, 12);
            this.lbl_X.TabIndex = 2;
            this.lbl_X.Text = "X:0";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Location = new System.Drawing.Point(16, 51);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(23, 12);
            this.lbl_Y.TabIndex = 3;
            this.lbl_Y.Text = "Y:0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(58, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 48);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(126, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_16
            // 
            this.txt_16.Location = new System.Drawing.Point(16, 88);
            this.txt_16.Name = "txt_16";
            this.txt_16.ReadOnly = true;
            this.txt_16.Size = new System.Drawing.Size(100, 21);
            this.txt_16.TabIndex = 5;
            // 
            // txt_rgb
            // 
            this.txt_rgb.Location = new System.Drawing.Point(16, 144);
            this.txt_rgb.Name = "txt_rgb";
            this.txt_rgb.ReadOnly = true;
            this.txt_rgb.Size = new System.Drawing.Size(100, 21);
            this.txt_rgb.TabIndex = 6;
            // 
            // copy
            // 
            this.copy.Location = new System.Drawing.Point(37, 233);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(55, 23);
            this.copy.TabIndex = 7;
            this.copy.Text = "copy(&Q)";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // copyrgb
            // 
            this.copyrgb.Location = new System.Drawing.Point(142, 233);
            this.copyrgb.Name = "copyrgb";
            this.copyrgb.Size = new System.Drawing.Size(72, 23);
            this.copyrgb.TabIndex = 8;
            this.copyrgb.Text = "copy(&w)";
            this.copyrgb.UseVisualStyleBackColor = true;
            this.copyrgb.Click += new System.EventHandler(this.copyrgb_Click);
            // 
            // lbl02
            // 
            this.lbl02.AutoSize = true;
            this.lbl02.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl02.Location = new System.Drawing.Point(35, 168);
            this.lbl02.Name = "lbl02";
            this.lbl02.Size = new System.Drawing.Size(57, 11);
            this.lbl02.TabIndex = 9;
            this.lbl02.Text = "Alt+W复制";
            // 
            // lbl01
            // 
            this.lbl01.AutoSize = true;
            this.lbl01.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl01.Location = new System.Drawing.Point(35, 112);
            this.lbl01.Name = "lbl01";
            this.lbl01.Size = new System.Drawing.Size(57, 11);
            this.lbl01.TabIndex = 10;
            this.lbl01.Text = "Alt+Q复制";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 204);
            this.Controls.Add(this.lbl01);
            this.Controls.Add(this.lbl02);
            this.Controls.Add(this.copyrgb);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.txt_rgb);
            this.Controls.Add(this.txt_16);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Y);
            this.Controls.Add(this.lbl_X);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "取色器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_16;
        private System.Windows.Forms.TextBox txt_rgb;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button copyrgb;
        private System.Windows.Forms.Label lbl02;
        private System.Windows.Forms.Label lbl01;
    }
}

