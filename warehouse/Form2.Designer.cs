﻿namespace warehouse
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmsg = new System.Windows.Forms.TextBox();
            this.btgen = new System.Windows.Forms.Button();
            this.btget = new System.Windows.Forms.Button();
            this.rtshow = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(419, 38);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(470, 430);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "内容";
            // 
            // tbmsg
            // 
            this.tbmsg.Location = new System.Drawing.Point(168, 35);
            this.tbmsg.Name = "tbmsg";
            this.tbmsg.Size = new System.Drawing.Size(100, 25);
            this.tbmsg.TabIndex = 10;
            // 
            // btgen
            // 
            this.btgen.Location = new System.Drawing.Point(58, 85);
            this.btgen.Name = "btgen";
            this.btgen.Size = new System.Drawing.Size(201, 51);
            this.btgen.TabIndex = 11;
            this.btgen.Text = "生成";
            this.btgen.UseVisualStyleBackColor = true;
            this.btgen.Click += new System.EventHandler(this.btgen_Click);
            // 
            // btget
            // 
            this.btget.Location = new System.Drawing.Point(58, 175);
            this.btget.Name = "btget";
            this.btget.Size = new System.Drawing.Size(282, 59);
            this.btget.TabIndex = 12;
            this.btget.Text = "读取";
            this.btget.UseVisualStyleBackColor = true;
            this.btget.Click += new System.EventHandler(this.btget_Click);
            // 
            // rtshow
            // 
            this.rtshow.Location = new System.Drawing.Point(58, 305);
            this.rtshow.Name = "rtshow";
            this.rtshow.Size = new System.Drawing.Size(291, 90);
            this.rtshow.TabIndex = 13;
            this.rtshow.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 514);
            this.Controls.Add(this.rtshow);
            this.Controls.Add(this.btget);
            this.Controls.Add(this.btgen);
            this.Controls.Add(this.tbmsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmsg;
        private System.Windows.Forms.Button btgen;
        private System.Windows.Forms.Button btget;
        private System.Windows.Forms.RichTextBox rtshow;
    }
}