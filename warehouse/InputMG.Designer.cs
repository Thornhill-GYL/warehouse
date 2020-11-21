namespace warehouse
{
    partial class InputMG
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
            this.cbname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgtest = new System.Windows.Forms.DataGridView();
            this.nporder = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.instore = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberlb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbstandard = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.morerich = new System.Windows.Forms.RichTextBox();
            this.btcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nporder)).BeginInit();
            this.SuspendLayout();
            // 
            // cbname
            // 
            this.cbname.BackColor = System.Drawing.SystemColors.Window;
            this.cbname.FormattingEnabled = true;
            this.cbname.Location = new System.Drawing.Point(157, 22);
            this.cbname.Name = "cbname";
            this.cbname.Size = new System.Drawing.Size(121, 23);
            this.cbname.TabIndex = 0;
            this.cbname.SelectedIndexChanged += new System.EventHandler(this.cbname_SelectedIndexChanged);
            this.cbname.TextUpdate += new System.EventHandler(this.cbname_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "物品名称";
            // 
            // dgtest
            // 
            this.dgtest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtest.Location = new System.Drawing.Point(47, 207);
            this.dgtest.Name = "dgtest";
            this.dgtest.RowTemplate.Height = 27;
            this.dgtest.Size = new System.Drawing.Size(695, 197);
            this.dgtest.TabIndex = 3;
            // 
            // nporder
            // 
            this.nporder.Location = new System.Drawing.Point(416, 20);
            this.nporder.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nporder.Name = "nporder";
            this.nporder.Size = new System.Drawing.Size(120, 25);
            this.nporder.TabIndex = 4;
            this.nporder.ValueChanged += new System.EventHandler(this.nporder_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "序号";
            // 
            // instore
            // 
            this.instore.Location = new System.Drawing.Point(565, 22);
            this.instore.Name = "instore";
            this.instore.Size = new System.Drawing.Size(75, 23);
            this.instore.TabIndex = 6;
            this.instore.Text = "已入库";
            this.instore.UseVisualStyleBackColor = true;
            this.instore.Click += new System.EventHandler(this.instore_Click);
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(667, 21);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(75, 23);
            this.btnext.TabIndex = 7;
            this.btnext.Text = "下一个";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "入库年月";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(154, 71);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(55, 15);
            this.timelabel.TabIndex = 9;
            this.timelabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "单位";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Location = new System.Drawing.Point(352, 71);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(55, 15);
            this.unit.TabIndex = 11;
            this.unit.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "拟生成序号：";
            // 
            // numberlb
            // 
            this.numberlb.AutoSize = true;
            this.numberlb.Location = new System.Drawing.Point(194, 108);
            this.numberlb.Name = "numberlb";
            this.numberlb.Size = new System.Drawing.Size(55, 15);
            this.numberlb.TabIndex = 13;
            this.numberlb.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "剩余库存量：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "物品规格：";
            // 
            // tbstandard
            // 
            this.tbstandard.Location = new System.Drawing.Point(479, 105);
            this.tbstandard.Name = "tbstandard";
            this.tbstandard.Size = new System.Drawing.Size(263, 25);
            this.tbstandard.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "备注";
            // 
            // morerich
            // 
            this.morerich.Location = new System.Drawing.Point(152, 142);
            this.morerich.Name = "morerich";
            this.morerich.Size = new System.Drawing.Size(228, 46);
            this.morerich.TabIndex = 19;
            this.morerich.Text = "";
            // 
            // btcode
            // 
            this.btcode.Location = new System.Drawing.Point(479, 142);
            this.btcode.Name = "btcode";
            this.btcode.Size = new System.Drawing.Size(161, 46);
            this.btcode.TabIndex = 20;
            this.btcode.Text = "打印二维码标签";
            this.btcode.UseVisualStyleBackColor = true;
            this.btcode.Click += new System.EventHandler(this.btcode_Click);
            // 
            // InputMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btcode);
            this.Controls.Add(this.morerich);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbstandard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberlb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.instore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nporder);
            this.Controls.Add(this.dgtest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbname);
            this.Name = "InputMG";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nporder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgtest;
        private System.Windows.Forms.NumericUpDown nporder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button instore;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label numberlb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbstandard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox morerich;
        private System.Windows.Forms.Button btcode;
    }
}