namespace Figuras
{
    partial class frmDeltoide
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
            this.txtDelWidth = new System.Windows.Forms.TextBox();
            this.txtDelHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Diagonal Menor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Diagonal Mayor:";
            // 
            // txtDelWidth
            // 
            this.txtDelWidth.Location = new System.Drawing.Point(173, 126);
            this.txtDelWidth.Name = "txtDelWidth";
            this.txtDelWidth.Size = new System.Drawing.Size(100, 20);
            this.txtDelWidth.TabIndex = 13;
            // 
            // txtDelHeight
            // 
            this.txtDelHeight.Location = new System.Drawing.Point(173, 77);
            this.txtDelHeight.Name = "txtDelHeight";
            this.txtDelHeight.Size = new System.Drawing.Size(100, 20);
            this.txtDelHeight.TabIndex = 12;
            // 
            // frmDeltoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDelWidth);
            this.Controls.Add(this.txtDelHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeltoide";
            this.Text = "frmDeltoide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDelWidth;
        private System.Windows.Forms.TextBox txtDelHeight;
    }
}