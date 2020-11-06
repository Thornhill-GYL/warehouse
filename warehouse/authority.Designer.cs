namespace warehouse
{
    partial class authority
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.usercode = new System.Windows.Forms.TextBox();
            this.btgo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(90, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(110, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(199, 63);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(137, 25);
            this.username.TabIndex = 2;
            // 
            // usercode
            // 
            this.usercode.Location = new System.Drawing.Point(199, 131);
            this.usercode.Name = "usercode";
            this.usercode.Size = new System.Drawing.Size(137, 25);
            this.usercode.TabIndex = 3;
            // 
            // btgo
            // 
            this.btgo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btgo.Location = new System.Drawing.Point(348, 188);
            this.btgo.Name = "btgo";
            this.btgo.Size = new System.Drawing.Size(98, 36);
            this.btgo.TabIndex = 4;
            this.btgo.Text = "确认";
            this.btgo.UseVisualStyleBackColor = true;
            this.btgo.Click += new System.EventHandler(this.btgo_Click);
            // 
            // authority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 242);
            this.Controls.Add(this.btgo);
            this.Controls.Add(this.usercode);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "authority";
            this.Text = "authority";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox usercode;
        private System.Windows.Forms.Button btgo;
    }
}