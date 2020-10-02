namespace warehouse
{
    partial class donestore
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
            this.btreadEQ = new System.Windows.Forms.Button();
            this.tempmsg = new System.Windows.Forms.RichTextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.lbnumber = new System.Windows.Forms.Label();
            this.tbnumber = new System.Windows.Forms.TextBox();
            this.lbscale = new System.Windows.Forms.Label();
            this.lbmsg = new System.Windows.Forms.Label();
            this.tbscale = new System.Windows.Forms.TextBox();
            this.rbmsg = new System.Windows.Forms.RichTextBox();
            this.btperson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbperson = new System.Windows.Forms.Label();
            this.inperson = new System.Windows.Forms.RichTextBox();
            this.truename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btreadEQ
            // 
            this.btreadEQ.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btreadEQ.Location = new System.Drawing.Point(48, 31);
            this.btreadEQ.Name = "btreadEQ";
            this.btreadEQ.Size = new System.Drawing.Size(229, 39);
            this.btreadEQ.TabIndex = 0;
            this.btreadEQ.Text = "读取二维码";
            this.btreadEQ.UseVisualStyleBackColor = true;
            this.btreadEQ.Click += new System.EventHandler(this.btreadEQ_Click);
            // 
            // tempmsg
            // 
            this.tempmsg.Location = new System.Drawing.Point(401, 31);
            this.tempmsg.Name = "tempmsg";
            this.tempmsg.Size = new System.Drawing.Size(210, 137);
            this.tempmsg.TabIndex = 1;
            this.tempmsg.Text = "";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbname.Location = new System.Drawing.Point(64, 128);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(104, 19);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "物品名称：";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(177, 122);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(182, 25);
            this.tbname.TabIndex = 3;
            // 
            // lbnumber
            // 
            this.lbnumber.AutoSize = true;
            this.lbnumber.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbnumber.Location = new System.Drawing.Point(68, 191);
            this.lbnumber.Name = "lbnumber";
            this.lbnumber.Size = new System.Drawing.Size(85, 19);
            this.lbnumber.TabIndex = 4;
            this.lbnumber.Text = "序列号：";
            // 
            // tbnumber
            // 
            this.tbnumber.Location = new System.Drawing.Point(177, 185);
            this.tbnumber.Name = "tbnumber";
            this.tbnumber.Size = new System.Drawing.Size(182, 25);
            this.tbnumber.TabIndex = 5;
            // 
            // lbscale
            // 
            this.lbscale.AutoSize = true;
            this.lbscale.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbscale.Location = new System.Drawing.Point(58, 244);
            this.lbscale.Name = "lbscale";
            this.lbscale.Size = new System.Drawing.Size(95, 19);
            this.lbscale.TabIndex = 7;
            this.lbscale.Text = "产品规格:";
            // 
            // lbmsg
            // 
            this.lbmsg.AutoSize = true;
            this.lbmsg.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbmsg.Location = new System.Drawing.Point(68, 296);
            this.lbmsg.Name = "lbmsg";
            this.lbmsg.Size = new System.Drawing.Size(57, 19);
            this.lbmsg.TabIndex = 8;
            this.lbmsg.Text = "备注:";
            // 
            // tbscale
            // 
            this.tbscale.Location = new System.Drawing.Point(177, 238);
            this.tbscale.Name = "tbscale";
            this.tbscale.Size = new System.Drawing.Size(182, 25);
            this.tbscale.TabIndex = 10;
            // 
            // rbmsg
            // 
            this.rbmsg.Location = new System.Drawing.Point(177, 296);
            this.rbmsg.Name = "rbmsg";
            this.rbmsg.Size = new System.Drawing.Size(182, 71);
            this.rbmsg.TabIndex = 11;
            this.rbmsg.Text = "";
            // 
            // btperson
            // 
            this.btperson.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btperson.Location = new System.Drawing.Point(401, 203);
            this.btperson.Name = "btperson";
            this.btperson.Size = new System.Drawing.Size(125, 33);
            this.btperson.TabIndex = 12;
            this.btperson.Text = "扫描身份卡";
            this.btperson.UseVisualStyleBackColor = true;
            this.btperson.Click += new System.EventHandler(this.btperson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(423, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "入库人：";
            // 
            // lbperson
            // 
            this.lbperson.AutoSize = true;
            this.lbperson.Location = new System.Drawing.Point(635, 217);
            this.lbperson.Name = "lbperson";
            this.lbperson.Size = new System.Drawing.Size(15, 15);
            this.lbperson.TabIndex = 14;
            this.lbperson.Text = " ";
            // 
            // inperson
            // 
            this.inperson.Location = new System.Drawing.Point(427, 295);
            this.inperson.Name = "inperson";
            this.inperson.Size = new System.Drawing.Size(184, 32);
            this.inperson.TabIndex = 15;
            this.inperson.Text = "";
            // 
            // truename
            // 
            this.truename.Location = new System.Drawing.Point(515, 254);
            this.truename.Name = "truename";
            this.truename.Size = new System.Drawing.Size(135, 25);
            this.truename.TabIndex = 16;
            // 
            // donestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.truename);
            this.Controls.Add(this.inperson);
            this.Controls.Add(this.lbperson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btperson);
            this.Controls.Add(this.rbmsg);
            this.Controls.Add(this.tbscale);
            this.Controls.Add(this.lbmsg);
            this.Controls.Add(this.lbscale);
            this.Controls.Add(this.tbnumber);
            this.Controls.Add(this.lbnumber);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.tempmsg);
            this.Controls.Add(this.btreadEQ);
            this.Name = "donestore";
            this.Text = "donestore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btreadEQ;
        private System.Windows.Forms.RichTextBox tempmsg;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label lbnumber;
        private System.Windows.Forms.TextBox tbnumber;
        private System.Windows.Forms.Label lbscale;
        private System.Windows.Forms.Label lbmsg;
        private System.Windows.Forms.TextBox tbscale;
        private System.Windows.Forms.RichTextBox rbmsg;
        private System.Windows.Forms.Button btperson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbperson;
        private System.Windows.Forms.RichTextBox inperson;
        private System.Windows.Forms.TextBox truename;
    }
}