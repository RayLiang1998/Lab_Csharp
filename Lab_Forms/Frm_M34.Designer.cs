
namespace Lab_Forms
{
    partial class Frm_M34
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
            this.btn_read = new System.Windows.Forms.Button();
            this.txt_readwrite = new System.Windows.Forms.TextBox();
            this.btn_write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(52, 49);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(135, 62);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // txt_readwrite
            // 
            this.txt_readwrite.Location = new System.Drawing.Point(226, 30);
            this.txt_readwrite.Multiline = true;
            this.txt_readwrite.Name = "txt_readwrite";
            this.txt_readwrite.Size = new System.Drawing.Size(546, 384);
            this.txt_readwrite.TabIndex = 1;
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(52, 145);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(135, 62);
            this.btn_write.TabIndex = 2;
            this.btn_write.Text = "Write";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // Frm_M34
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.txt_readwrite);
            this.Controls.Add(this.btn_read);
            this.Name = "Frm_M34";
            this.Text = "Frm_M34";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox txt_readwrite;
        private System.Windows.Forms.Button btn_write;
    }
}