namespace Figuras
{
    partial class Triangle
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
            this.txtWidth = new System.Windows.Forms.Label();
            this.txtWidthTriangle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHeightTriangle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWidth
            // 
            this.txtWidth.AutoSize = true;
            this.txtWidth.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(45, 25);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(60, 34);
            this.txtWidth.TabIndex = 20;
            this.txtWidth.Text = "Ancho:";
            // 
            // txtWidthTriangle
            // 
            this.txtWidthTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidthTriangle.Location = new System.Drawing.Point(109, 30);
            this.txtWidthTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.txtWidthTriangle.Multiline = true;
            this.txtWidthTriangle.Name = "txtWidthTriangle";
            this.txtWidthTriangle.Size = new System.Drawing.Size(104, 20);
            this.txtWidthTriangle.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 34);
            this.label7.TabIndex = 21;
            this.label7.Text = "Alto:";
            // 
            // txtHeightTriangle
            // 
            this.txtHeightTriangle.AcceptsTab = true;
            this.txtHeightTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightTriangle.Location = new System.Drawing.Point(109, 68);
            this.txtHeightTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeightTriangle.Multiline = true;
            this.txtHeightTriangle.Name = "txtHeightTriangle";
            this.txtHeightTriangle.Size = new System.Drawing.Size(104, 20);
            this.txtHeightTriangle.TabIndex = 22;
            // 
            // Triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 122);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWidthTriangle);
            this.Controls.Add(this.txtHeightTriangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Triangle";
            this.Text = "Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtWidth;
        private System.Windows.Forms.TextBox txtWidthTriangle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeightTriangle;
    }
}