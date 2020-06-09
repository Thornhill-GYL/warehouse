namespace warehouse
{
    partial class personEQ
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
            this.imgeq = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgeq)).BeginInit();
            this.SuspendLayout();
            // 
            // imgeq
            // 
            this.imgeq.Location = new System.Drawing.Point(41, 26);
            this.imgeq.Name = "imgeq";
            this.imgeq.Size = new System.Drawing.Size(407, 365);
            this.imgeq.TabIndex = 10;
            this.imgeq.TabStop = false;
            // 
            // personEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 427);
            this.Controls.Add(this.imgeq);
            this.Name = "personEQ";
            this.Text = "personEQ";
            this.Load += new System.EventHandler(this.personEQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgeq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgeq;
    }
}