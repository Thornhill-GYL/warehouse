namespace warehouse
{
    partial class Form2
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.cb_version = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_pixel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_pic = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_line = new System.Windows.Forms.ComboBox();
            this.QRpic = new System.Windows.Forms.PictureBox();
            this.msg_str = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.w_line_y = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_encoder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRpic)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_version
            // 
            this.cb_version.FormattingEnabled = true;
            this.cb_version.Items.AddRange(new object[] {
            "5"});
            this.cb_version.Location = new System.Drawing.Point(134, 41);
            this.cb_version.Name = "cb_version";
            this.cb_version.Size = new System.Drawing.Size(121, 23);
            this.cb_version.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "版本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "像素：";
            // 
            // cb_pixel
            // 
            this.cb_pixel.FormattingEnabled = true;
            this.cb_pixel.Items.AddRange(new object[] {
            "7"});
            this.cb_pixel.Location = new System.Drawing.Point(505, 41);
            this.cb_pixel.Name = "cb_pixel";
            this.cb_pixel.Size = new System.Drawing.Size(121, 23);
            this.cb_pixel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "图标尺寸：";
            // 
            // cb_pic
            // 
            this.cb_pic.FormattingEnabled = true;
            this.cb_pic.Items.AddRange(new object[] {
            "20"});
            this.cb_pic.Location = new System.Drawing.Point(134, 86);
            this.cb_pic.Name = "cb_pic";
            this.cb_pic.Size = new System.Drawing.Size(121, 23);
            this.cb_pic.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "图标标线：";
            // 
            // cb_line
            // 
            this.cb_line.FormattingEnabled = true;
            this.cb_line.Items.AddRange(new object[] {
            "5"});
            this.cb_line.Location = new System.Drawing.Point(505, 86);
            this.cb_line.Name = "cb_line";
            this.cb_line.Size = new System.Drawing.Size(121, 23);
            this.cb_line.TabIndex = 7;
            // 
            // QRpic
            // 
            this.QRpic.Location = new System.Drawing.Point(457, 125);
            this.QRpic.Name = "QRpic";
            this.QRpic.Size = new System.Drawing.Size(401, 341);
            this.QRpic.TabIndex = 8;
            this.QRpic.TabStop = false;
            // 
            // msg_str
            // 
            this.msg_str.Location = new System.Drawing.Point(31, 185);
            this.msg_str.Name = "msg_str";
            this.msg_str.Size = new System.Drawing.Size(302, 223);
            this.msg_str.TabIndex = 9;
            this.msg_str.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "白边：";
            // 
            // w_line_y
            // 
            this.w_line_y.AutoSize = true;
            this.w_line_y.Location = new System.Drawing.Point(86, 142);
            this.w_line_y.Name = "w_line_y";
            this.w_line_y.Size = new System.Drawing.Size(43, 19);
            this.w_line_y.TabIndex = 11;
            this.w_line_y.TabStop = true;
            this.w_line_y.Text = "有";
            this.w_line_y.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(164, 141);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "无";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(258, 443);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_encoder
            // 
            this.btn_encoder.Location = new System.Drawing.Point(28, 443);
            this.btn_encoder.Name = "btn_encoder";
            this.btn_encoder.Size = new System.Drawing.Size(75, 23);
            this.btn_encoder.TabIndex = 14;
            this.btn_encoder.Text = "生成";
            this.btn_encoder.UseVisualStyleBackColor = true;
            this.btn_encoder.Click += new System.EventHandler(this.btn_encoder_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 514);
            this.Controls.Add(this.btn_encoder);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.w_line_y);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.msg_str);
            this.Controls.Add(this.QRpic);
            this.Controls.Add(this.cb_line);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_pic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_pixel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_version);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            //((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ComboBox cb_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_pixel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_pic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_line;
        private System.Windows.Forms.PictureBox QRpic;
        private System.Windows.Forms.RichTextBox msg_str;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton w_line_y;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_encoder;
    }
}