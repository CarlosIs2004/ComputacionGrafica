namespace Figuras
{
    partial class frmRomboide
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeightRom = new System.Windows.Forms.TextBox();
            this.txtWidthRom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Altura:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Base :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHeightRom
            // 
            this.txtHeightRom.Location = new System.Drawing.Point(168, 95);
            this.txtHeightRom.Name = "txtHeightRom";
            this.txtHeightRom.Size = new System.Drawing.Size(100, 20);
            this.txtHeightRom.TabIndex = 13;
            this.txtHeightRom.TextChanged += new System.EventHandler(this.txtDWidth_TextChanged);
            // 
            // txtWidthRom
            // 
            this.txtWidthRom.Location = new System.Drawing.Point(168, 46);
            this.txtWidthRom.Name = "txtWidthRom";
            this.txtWidthRom.Size = new System.Drawing.Size(100, 20);
            this.txtWidthRom.TabIndex = 12;
            this.txtWidthRom.TextChanged += new System.EventHandler(this.txtDHeight_TextChanged);
            // 
            // frmRomboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeightRom);
            this.Controls.Add(this.txtWidthRom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRomboide";
            this.Text = "frmRomboide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeightRom;
        private System.Windows.Forms.TextBox txtWidthRom;
    }
}