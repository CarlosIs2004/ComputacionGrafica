namespace Figuras
{
    partial class frmRombo
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
            this.txtDWidth = new System.Windows.Forms.TextBox();
            this.txtDHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Diagonal Menor:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diagonal Mayor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDWidth
            // 
            this.txtDWidth.Location = new System.Drawing.Point(180, 109);
            this.txtDWidth.Name = "txtDWidth";
            this.txtDWidth.Size = new System.Drawing.Size(100, 20);
            this.txtDWidth.TabIndex = 9;
            this.txtDWidth.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtDHeight
            // 
            this.txtDHeight.Location = new System.Drawing.Point(180, 60);
            this.txtDHeight.Name = "txtDHeight";
            this.txtDHeight.Size = new System.Drawing.Size(100, 20);
            this.txtDHeight.TabIndex = 8;
            this.txtDHeight.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // frmRombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDWidth);
            this.Controls.Add(this.txtDHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRombo";
            this.Text = "frmRombo";
            this.Load += new System.EventHandler(this.frmRombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDWidth;
        private System.Windows.Forms.TextBox txtDHeight;
    }
}