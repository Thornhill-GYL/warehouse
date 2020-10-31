namespace warehouse
{
    partial class outstore
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
            this.readEQ = new System.Windows.Forms.Button();
            this.readperson = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.lbnumber = new System.Windows.Forms.Label();
            this.lbscale = new System.Windows.Forms.Label();
            this.lbmsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btoutst = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbnumber = new System.Windows.Forms.TextBox();
            this.tbscale = new System.Windows.Forms.TextBox();
            this.rbmsg = new System.Windows.Forms.RichTextBox();
            this.tbloc = new System.Windows.Forms.TextBox();
            this.truename = new System.Windows.Forms.TextBox();
            this.cbloc = new System.Windows.Forms.ComboBox();
            this.lbtime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.testtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readEQ
            // 
            this.readEQ.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readEQ.Location = new System.Drawing.Point(138, 38);
            this.readEQ.Name = "readEQ";
            this.readEQ.Size = new System.Drawing.Size(179, 46);
            this.readEQ.TabIndex = 0;
            this.readEQ.Text = "读取物品二维码";
            this.readEQ.UseVisualStyleBackColor = true;
            this.readEQ.Click += new System.EventHandler(this.readEQ_Click);
            // 
            // readperson
            // 
            this.readperson.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readperson.Location = new System.Drawing.Point(495, 38);
            this.readperson.Name = "readperson";
            this.readperson.Size = new System.Drawing.Size(178, 46);
            this.readperson.TabIndex = 1;
            this.readperson.Text = "读取人员二维码";
            this.readperson.UseVisualStyleBackColor = true;
            this.readperson.Click += new System.EventHandler(this.readperson_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbname.Location = new System.Drawing.Point(51, 130);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(104, 19);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "物品名称：";
            // 
            // lbnumber
            // 
            this.lbnumber.AutoSize = true;
            this.lbnumber.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnumber.Location = new System.Drawing.Point(51, 185);
            this.lbnumber.Name = "lbnumber";
            this.lbnumber.Size = new System.Drawing.Size(85, 19);
            this.lbnumber.TabIndex = 3;
            this.lbnumber.Text = "序列号：";
            // 
            // lbscale
            // 
            this.lbscale.AutoSize = true;
            this.lbscale.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbscale.Location = new System.Drawing.Point(51, 248);
            this.lbscale.Name = "lbscale";
            this.lbscale.Size = new System.Drawing.Size(104, 19);
            this.lbscale.TabIndex = 4;
            this.lbscale.Text = "产品规格：";
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbmsg.Location = new System.Drawing.Point(51, 355);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(66, 19);
            this.lbmsg.TabIndex = 5;
            this.lbmsg.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(51, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "存储位置：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(426, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "领取人：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(426, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "物品去向：";
            // 
            // btoutst
            // 
            this.btoutst.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btoutst.Location = new System.Drawing.Point(593, 334);
            this.btoutst.Name = "btoutst";
            this.btoutst.Size = new System.Drawing.Size(118, 58);
            this.btoutst.TabIndex = 9;
            this.btoutst.Text = "出库";
            this.btoutst.UseVisualStyleBackColor = true;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(162, 130);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(155, 25);
            this.tbname.TabIndex = 10;
            // 
            // tbnumber
            // 
            this.tbnumber.Location = new System.Drawing.Point(162, 194);
            this.tbnumber.Name = "tbnumber";
            this.tbnumber.Size = new System.Drawing.Size(155, 25);
            this.tbnumber.TabIndex = 11;
            // 
            // tbscale
            // 
            this.tbscale.Location = new System.Drawing.Point(162, 248);
            this.tbscale.Name = "tbscale";
            this.tbscale.Size = new System.Drawing.Size(155, 25);
            this.tbscale.TabIndex = 12;
            // 
            // rbmsg
            // 
            this.rbmsg.Location = new System.Drawing.Point(162, 353);
            this.rbmsg.Name = "rbmsg";
            this.rbmsg.Size = new System.Drawing.Size(203, 64);
            this.rbmsg.TabIndex = 13;
            this.rbmsg.Text = "";
            // 
            // tbloc
            // 
            this.tbloc.Location = new System.Drawing.Point(162, 304);
            this.tbloc.Name = "tbloc";
            this.tbloc.Size = new System.Drawing.Size(155, 25);
            this.tbloc.TabIndex = 14;
            // 
            // truename
            // 
            this.truename.Location = new System.Drawing.Point(536, 139);
            this.truename.Name = "truename";
            this.truename.Size = new System.Drawing.Size(137, 25);
            this.truename.TabIndex = 15;
            // 
            // cbloc
            // 
            this.cbloc.FormattingEnabled = true;
            this.cbloc.Location = new System.Drawing.Point(536, 244);
            this.cbloc.Name = "cbloc";
            this.cbloc.Size = new System.Drawing.Size(137, 23);
            this.cbloc.TabIndex = 16;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(590, 417);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(55, 15);
            this.lbtime.TabIndex = 17;
            this.lbtime.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(427, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "仓库位置：";
            // 
            // testtb
            // 
            this.testtb.Location = new System.Drawing.Point(538, 193);
            this.testtb.Name = "testtb";
            this.testtb.Size = new System.Drawing.Size(135, 25);
            this.testtb.TabIndex = 19;
            // 
            // outstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.cbloc);
            this.Controls.Add(this.truename);
            this.Controls.Add(this.tbloc);
            this.Controls.Add(this.rbmsg);
            this.Controls.Add(this.tbscale);
            this.Controls.Add(this.tbnumber);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.btoutst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.lbscale);
            this.Controls.Add(this.lbnumber);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.readperson);
            this.Controls.Add(this.readEQ);
            this.Name = "outstore";
            this.Text = "outstore";
            this.Load += new System.EventHandler(this.outstore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readEQ;
        private System.Windows.Forms.Button readperson;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbnumber;
        private System.Windows.Forms.Label lbscale;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btoutst;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbnumber;
        private System.Windows.Forms.TextBox tbscale;
        private System.Windows.Forms.RichTextBox rbmsg;
        private System.Windows.Forms.TextBox tbloc;
        private System.Windows.Forms.TextBox truename;
        private System.Windows.Forms.ComboBox cbloc;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox testtb;
    }
}