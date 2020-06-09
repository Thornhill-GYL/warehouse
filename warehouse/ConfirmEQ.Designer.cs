namespace warehouse
{
    partial class ConfirmEQ
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
            this.label1 = new System.Windows.Forms.Label();
            this.cfname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cfnumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cfstandard = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cfmore = new System.Windows.Forms.Label();
            this.btgen = new System.Windows.Forms.Button();
            this.pbcode = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbcode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "物品名称：";
            // 
            // cfname
            // 
            this.cfname.AutoSize = true;
            this.cfname.Location = new System.Drawing.Point(195, 65);
            this.cfname.Name = "cfname";
            this.cfname.Size = new System.Drawing.Size(55, 15);
            this.cfname.TabIndex = 1;
            this.cfname.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "序列号：";
            // 
            // cfnumber
            // 
            this.cfnumber.AutoSize = true;
            this.cfnumber.Location = new System.Drawing.Point(198, 118);
            this.cfnumber.Name = "cfnumber";
            this.cfnumber.Size = new System.Drawing.Size(55, 15);
            this.cfnumber.TabIndex = 3;
            this.cfnumber.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "规格：";
            // 
            // cfstandard
            // 
            this.cfstandard.AutoSize = true;
            this.cfstandard.Location = new System.Drawing.Point(198, 167);
            this.cfstandard.Name = "cfstandard";
            this.cfstandard.Size = new System.Drawing.Size(55, 15);
            this.cfstandard.TabIndex = 5;
            this.cfstandard.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "备注：";
            // 
            // cfmore
            // 
            this.cfmore.AutoSize = true;
            this.cfmore.Location = new System.Drawing.Point(198, 232);
            this.cfmore.Name = "cfmore";
            this.cfmore.Size = new System.Drawing.Size(55, 15);
            this.cfmore.TabIndex = 7;
            this.cfmore.Text = "label5";
            // 
            // btgen
            // 
            this.btgen.Location = new System.Drawing.Point(77, 299);
            this.btgen.Name = "btgen";
            this.btgen.Size = new System.Drawing.Size(148, 43);
            this.btgen.TabIndex = 8;
            this.btgen.Text = "打印二维码";
            this.btgen.UseVisualStyleBackColor = true;
            this.btgen.Click += new System.EventHandler(this.btgen_Click);
            // 
            // pbcode
            // 
            this.pbcode.Location = new System.Drawing.Point(363, 55);
            this.pbcode.Name = "pbcode";
            this.pbcode.Size = new System.Drawing.Size(407, 365);
            this.pbcode.TabIndex = 9;
            this.pbcode.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ConfirmEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbcode);
            this.Controls.Add(this.btgen);
            this.Controls.Add(this.cfmore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cfstandard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cfnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cfname);
            this.Controls.Add(this.label1);
            this.Name = "ConfirmEQ";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cfname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cfnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cfstandard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cfmore;
        private System.Windows.Forms.Button btgen;
        private System.Windows.Forms.PictureBox pbcode;
        private System.Windows.Forms.Timer timer;
    }
}