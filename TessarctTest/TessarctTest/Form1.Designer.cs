
namespace TessarctTest
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.path_txtBox = new System.Windows.Forms.TextBox();
            this.ocr_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14F);
            this.textBox1.Location = new System.Drawing.Point(34, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaximumSize = new System.Drawing.Size(600, 599);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(600, 532);
            this.textBox1.TabIndex = 1;
            // 
            // path_txtBox
            // 
            this.path_txtBox.AllowDrop = true;
            this.path_txtBox.Font = new System.Drawing.Font("Calibri", 10F);
            this.path_txtBox.Location = new System.Drawing.Point(34, 11);
            this.path_txtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path_txtBox.Name = "path_txtBox";
            this.path_txtBox.Size = new System.Drawing.Size(514, 28);
            this.path_txtBox.TabIndex = 2;
            this.path_txtBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.path_txtBox_DragDrop);
            this.path_txtBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.path_txtBox_DragEnter);
            // 
            // ocr_btn
            // 
            this.ocr_btn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocr_btn.Location = new System.Drawing.Point(554, 9);
            this.ocr_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ocr_btn.Name = "ocr_btn";
            this.ocr_btn.Size = new System.Drawing.Size(80, 28);
            this.ocr_btn.TabIndex = 3;
            this.ocr_btn.Text = "OCR";
            this.ocr_btn.UseVisualStyleBackColor = true;
            this.ocr_btn.Click += new System.EventHandler(this.ocr_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 590);
            this.Controls.Add(this.ocr_btn);
            this.Controls.Add(this.path_txtBox);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "OCR Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox path_txtBox;
        private System.Windows.Forms.Button ocr_btn;
    }
}

