namespace warehouse
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buildQR = new System.Windows.Forms.Button();
            this.megbt = new System.Windows.Forms.Button();
            this.sysbt = new System.Windows.Forms.Button();
            this.storebt = new System.Windows.Forms.Button();
            this.outbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildQR
            // 
            this.buildQR.Location = new System.Drawing.Point(123, 196);
            this.buildQR.Name = "buildQR";
            this.buildQR.Size = new System.Drawing.Size(160, 75);
            this.buildQR.TabIndex = 0;
            this.buildQR.Text = "test_EQ";
            this.buildQR.UseVisualStyleBackColor = true;
            this.buildQR.Click += new System.EventHandler(this.buildQR_Click);
            // 
            // megbt
            // 
            this.megbt.Location = new System.Drawing.Point(123, 118);
            this.megbt.Name = "megbt";
            this.megbt.Size = new System.Drawing.Size(155, 61);
            this.megbt.TabIndex = 1;
            this.megbt.Text = "打印标签";
            this.megbt.UseVisualStyleBackColor = true;
            this.megbt.Click += new System.EventHandler(this.megbt_Click);
            // 
            // sysbt
            // 
            this.sysbt.Location = new System.Drawing.Point(122, 23);
            this.sysbt.Name = "sysbt";
            this.sysbt.Size = new System.Drawing.Size(156, 61);
            this.sysbt.TabIndex = 2;
            this.sysbt.Text = "系统设置";
            this.sysbt.UseVisualStyleBackColor = true;
            this.sysbt.Click += new System.EventHandler(this.sysbt_Click);
            // 
            // storebt
            // 
            this.storebt.Location = new System.Drawing.Point(127, 292);
            this.storebt.Name = "storebt";
            this.storebt.Size = new System.Drawing.Size(156, 84);
            this.storebt.TabIndex = 3;
            this.storebt.Text = "入库操作";
            this.storebt.UseVisualStyleBackColor = true;
            this.storebt.Click += new System.EventHandler(this.storebt_Click);
            // 
            // outbt
            // 
            this.outbt.Location = new System.Drawing.Point(127, 398);
            this.outbt.Name = "outbt";
            this.outbt.Size = new System.Drawing.Size(156, 74);
            this.outbt.TabIndex = 4;
            this.outbt.Text = "出库操作";
            this.outbt.UseVisualStyleBackColor = true;
            this.outbt.Click += new System.EventHandler(this.outbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 601);
            this.Controls.Add(this.outbt);
            this.Controls.Add(this.storebt);
            this.Controls.Add(this.sysbt);
            this.Controls.Add(this.megbt);
            this.Controls.Add(this.buildQR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buildQR;
        private System.Windows.Forms.Button megbt;
        private System.Windows.Forms.Button sysbt;
        private System.Windows.Forms.Button storebt;
        private System.Windows.Forms.Button outbt;
    }
}

