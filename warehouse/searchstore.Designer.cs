namespace warehouse
{
    partial class searchstore
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_product = new System.Windows.Forms.TextBox();
            this.cb_putnam = new System.Windows.Forms.ComboBox();
            this.cb_putloc = new System.Windows.Forms.ComboBox();
            this.cb_outname = new System.Windows.Forms.ComboBox();
            this.cb_outloc = new System.Windows.Forms.ComboBox();
            this.dp_put = new System.Windows.Forms.DateTimePicker();
            this.dp_out = new System.Windows.Forms.DateTimePicker();
            this.dgshow_all = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_put = new System.Windows.Forms.RadioButton();
            this.rb_out = new System.Windows.Forms.RadioButton();
            this.rbtime = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgshow_all)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "序列号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "入库人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "领用人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(282, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "物品名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(282, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "存储位置：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(282, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "物品去向：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(548, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "入库时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(548, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "出库时间：";
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(133, 38);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(121, 25);
            this.tb_num.TabIndex = 8;
            // 
            // tb_product
            // 
            this.tb_product.Location = new System.Drawing.Point(392, 37);
            this.tb_product.Name = "tb_product";
            this.tb_product.Size = new System.Drawing.Size(121, 25);
            this.tb_product.TabIndex = 9;
            // 
            // cb_putnam
            // 
            this.cb_putnam.FormattingEnabled = true;
            this.cb_putnam.Location = new System.Drawing.Point(133, 86);
            this.cb_putnam.Name = "cb_putnam";
            this.cb_putnam.Size = new System.Drawing.Size(121, 23);
            this.cb_putnam.TabIndex = 10;
            this.cb_putnam.TextUpdate += new System.EventHandler(this.cb_putnam_TextUpdate);
            // 
            // cb_putloc
            // 
            this.cb_putloc.FormattingEnabled = true;
            this.cb_putloc.Location = new System.Drawing.Point(392, 86);
            this.cb_putloc.Name = "cb_putloc";
            this.cb_putloc.Size = new System.Drawing.Size(121, 23);
            this.cb_putloc.TabIndex = 11;
            this.cb_putloc.TextUpdate += new System.EventHandler(this.cb_putloc_TextUpdate);
            // 
            // cb_outname
            // 
            this.cb_outname.FormattingEnabled = true;
            this.cb_outname.Location = new System.Drawing.Point(133, 138);
            this.cb_outname.Name = "cb_outname";
            this.cb_outname.Size = new System.Drawing.Size(121, 23);
            this.cb_outname.TabIndex = 12;
            this.cb_outname.TextUpdate += new System.EventHandler(this.cb_outname_TextUpdate);
            // 
            // cb_outloc
            // 
            this.cb_outloc.FormattingEnabled = true;
            this.cb_outloc.Location = new System.Drawing.Point(392, 134);
            this.cb_outloc.Name = "cb_outloc";
            this.cb_outloc.Size = new System.Drawing.Size(121, 23);
            this.cb_outloc.TabIndex = 13;
            this.cb_outloc.TextUpdate += new System.EventHandler(this.cb_outloc_TextUpdate);
            // 
            // dp_put
            // 
            this.dp_put.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dp_put.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_put.Location = new System.Drawing.Point(658, 34);
            this.dp_put.Name = "dp_put";
            this.dp_put.Size = new System.Drawing.Size(200, 28);
            this.dp_put.TabIndex = 14;
            // 
            // dp_out
            // 
            this.dp_out.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dp_out.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_out.Location = new System.Drawing.Point(658, 83);
            this.dp_out.Name = "dp_out";
            this.dp_out.Size = new System.Drawing.Size(200, 28);
            this.dp_out.TabIndex = 15;
            // 
            // dgshow_all
            // 
            this.dgshow_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgshow_all.Location = new System.Drawing.Point(24, 201);
            this.dgshow_all.Name = "dgshow_all";
            this.dgshow_all.RowTemplate.Height = 27;
            this.dgshow_all.Size = new System.Drawing.Size(849, 242);
            this.dgshow_all.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(798, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_put
            // 
            this.rb_put.AutoSize = true;
            this.rb_put.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_put.Location = new System.Drawing.Point(546, 137);
            this.rb_put.Name = "rb_put";
            this.rb_put.Size = new System.Drawing.Size(106, 23);
            this.rb_put.TabIndex = 18;
            this.rb_put.TabStop = true;
            this.rb_put.Text = "入库时间";
            this.rb_put.UseVisualStyleBackColor = true;
            // 
            // rb_out
            // 
            this.rb_out.AutoSize = true;
            this.rb_out.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rb_out.Location = new System.Drawing.Point(670, 137);
            this.rb_out.Name = "rb_out";
            this.rb_out.Size = new System.Drawing.Size(106, 23);
            this.rb_out.TabIndex = 19;
            this.rb_out.TabStop = true;
            this.rb_out.Text = "出库时间";
            this.rb_out.UseVisualStyleBackColor = true;
            // 
            // rbtime
            // 
            this.rbtime.AutoSize = true;
            this.rbtime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtime.Location = new System.Drawing.Point(670, 166);
            this.rbtime.Name = "rbtime";
            this.rbtime.Size = new System.Drawing.Size(125, 23);
            this.rbtime.TabIndex = 20;
            this.rbtime.TabStop = true;
            this.rbtime.Text = "不考虑时间";
            this.rbtime.UseVisualStyleBackColor = true;
            // 
            // searchstore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 455);
            this.Controls.Add(this.rbtime);
            this.Controls.Add(this.rb_out);
            this.Controls.Add(this.rb_put);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgshow_all);
            this.Controls.Add(this.dp_out);
            this.Controls.Add(this.dp_put);
            this.Controls.Add(this.cb_outloc);
            this.Controls.Add(this.cb_outname);
            this.Controls.Add(this.cb_putloc);
            this.Controls.Add(this.cb_putnam);
            this.Controls.Add(this.tb_product);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "searchstore";
            this.Text = "searchstore";
            this.Load += new System.EventHandler(this.searchstore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgshow_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_product;
        private System.Windows.Forms.ComboBox cb_putnam;
        private System.Windows.Forms.ComboBox cb_putloc;
        private System.Windows.Forms.ComboBox cb_outname;
        private System.Windows.Forms.ComboBox cb_outloc;
        private System.Windows.Forms.DateTimePicker dp_put;
        private System.Windows.Forms.DateTimePicker dp_out;
        private System.Windows.Forms.DataGridView dgshow_all;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_put;
        private System.Windows.Forms.RadioButton rb_out;
        private System.Windows.Forms.RadioButton rbtime;
    }
}