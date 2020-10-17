namespace warehouse
{
    partial class Setsystem
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
            this.cbpersonname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btperson = new System.Windows.Forms.Button();
            this.btitem = new System.Windows.Forms.Button();
            this.btstore = new System.Windows.Forms.Button();
            this.btmsg = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbtest = new System.Windows.Forms.TextBox();
            this.tbback = new System.Windows.Forms.TextBox();
            this.tbproduct = new System.Windows.Forms.TextBox();
            this.tbstoreloc = new System.Windows.Forms.TextBox();
            this.tbpersonloc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbpersonname
            // 
            this.cbpersonname.FormattingEnabled = true;
            this.cbpersonname.Location = new System.Drawing.Point(132, 75);
            this.cbpersonname.Name = "cbpersonname";
            this.cbpersonname.Size = new System.Drawing.Size(121, 23);
            this.cbpersonname.TabIndex = 0;
            this.cbpersonname.TextUpdate += new System.EventHandler(this.cbpersonname_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名：";
            // 
            // btperson
            // 
            this.btperson.Location = new System.Drawing.Point(88, 120);
            this.btperson.Name = "btperson";
            this.btperson.Size = new System.Drawing.Size(191, 39);
            this.btperson.TabIndex = 2;
            this.btperson.Text = "打印身份卡";
            this.btperson.UseVisualStyleBackColor = true;
            this.btperson.Click += new System.EventHandler(this.btperson_Click);
            // 
            // btitem
            // 
            this.btitem.Location = new System.Drawing.Point(88, 201);
            this.btitem.Name = "btitem";
            this.btitem.Size = new System.Drawing.Size(191, 39);
            this.btitem.TabIndex = 3;
            this.btitem.Text = "录入物品清单";
            this.btitem.UseVisualStyleBackColor = true;
            this.btitem.Click += new System.EventHandler(this.btitem_Click);
            // 
            // btstore
            // 
            this.btstore.Location = new System.Drawing.Point(88, 316);
            this.btstore.Name = "btstore";
            this.btstore.Size = new System.Drawing.Size(191, 35);
            this.btstore.TabIndex = 4;
            this.btstore.Text = "录入仓库信息";
            this.btstore.UseVisualStyleBackColor = true;
            this.btstore.Click += new System.EventHandler(this.btstore_Click);
            // 
            // btmsg
            // 
            this.btmsg.Location = new System.Drawing.Point(88, 413);
            this.btmsg.Name = "btmsg";
            this.btmsg.Size = new System.Drawing.Size(191, 32);
            this.btmsg.TabIndex = 5;
            this.btmsg.Text = "录入人员信息";
            this.btmsg.UseVisualStyleBackColor = true;
            this.btmsg.Click += new System.EventHandler(this.btmsg_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbtest
            // 
            this.tbtest.Location = new System.Drawing.Point(88, 32);
            this.tbtest.Name = "tbtest";
            this.tbtest.Size = new System.Drawing.Size(238, 25);
            this.tbtest.TabIndex = 6;
            // 
            // tbback
            // 
            this.tbback.Location = new System.Drawing.Point(141, 165);
            this.tbback.Name = "tbback";
            this.tbback.Size = new System.Drawing.Size(100, 25);
            this.tbback.TabIndex = 7;
            // 
            // tbproduct
            // 
            this.tbproduct.Location = new System.Drawing.Point(88, 261);
            this.tbproduct.Name = "tbproduct";
            this.tbproduct.Size = new System.Drawing.Size(191, 25);
            this.tbproduct.TabIndex = 8;
            // 
            // tbstoreloc
            // 
            this.tbstoreloc.Location = new System.Drawing.Point(88, 370);
            this.tbstoreloc.Name = "tbstoreloc";
            this.tbstoreloc.Size = new System.Drawing.Size(191, 25);
            this.tbstoreloc.TabIndex = 9;
            // 
            // tbpersonloc
            // 
            this.tbpersonloc.Location = new System.Drawing.Point(88, 469);
            this.tbpersonloc.Name = "tbpersonloc";
            this.tbpersonloc.Size = new System.Drawing.Size(191, 25);
            this.tbpersonloc.TabIndex = 10;
            // 
            // Setsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 522);
            this.Controls.Add(this.tbpersonloc);
            this.Controls.Add(this.tbstoreloc);
            this.Controls.Add(this.tbproduct);
            this.Controls.Add(this.tbback);
            this.Controls.Add(this.tbtest);
            this.Controls.Add(this.btmsg);
            this.Controls.Add(this.btstore);
            this.Controls.Add(this.btitem);
            this.Controls.Add(this.btperson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbpersonname);
            this.Name = "Setsystem";
            this.Text = "Setsystem";
            this.Load += new System.EventHandler(this.Setsystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbpersonname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btperson;
        private System.Windows.Forms.Button btitem;
        private System.Windows.Forms.Button btstore;
        private System.Windows.Forms.Button btmsg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbtest;
        private System.Windows.Forms.TextBox tbback;
        private System.Windows.Forms.TextBox tbproduct;
        private System.Windows.Forms.TextBox tbstoreloc;
        private System.Windows.Forms.TextBox tbpersonloc;
    }
}