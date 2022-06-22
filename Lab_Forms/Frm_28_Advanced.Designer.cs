
namespace Lab_Forms
{
    partial class Frm_28_Advanced
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
            this.btn_swap_int = new System.Windows.Forms.Button();
            this.btn_swap_string = new System.Windows.Forms.Button();
            this.btn_Gswap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_swap_int
            // 
            this.btn_swap_int.Location = new System.Drawing.Point(59, 56);
            this.btn_swap_int.Name = "btn_swap_int";
            this.btn_swap_int.Size = new System.Drawing.Size(209, 86);
            this.btn_swap_int.TabIndex = 0;
            this.btn_swap_int.Text = "Swap(a,b)";
            this.btn_swap_int.UseVisualStyleBackColor = true;
            this.btn_swap_int.Click += new System.EventHandler(this.btn_swap_int_Click);
            // 
            // btn_swap_string
            // 
            this.btn_swap_string.Location = new System.Drawing.Point(59, 170);
            this.btn_swap_string.Name = "btn_swap_string";
            this.btn_swap_string.Size = new System.Drawing.Size(209, 86);
            this.btn_swap_string.TabIndex = 1;
            this.btn_swap_string.Text = "Swap(string a, b)";
            this.btn_swap_string.UseVisualStyleBackColor = true;
            this.btn_swap_string.Click += new System.EventHandler(this.btn_swap_string_Click);
            // 
            // btn_Gswap
            // 
            this.btn_Gswap.Location = new System.Drawing.Point(59, 291);
            this.btn_Gswap.Name = "btn_Gswap";
            this.btn_Gswap.Size = new System.Drawing.Size(209, 86);
            this.btn_Gswap.TabIndex = 2;
            this.btn_Gswap.Text = "Generic Swap( a, b)";
            this.btn_Gswap.UseVisualStyleBackColor = true;
            this.btn_Gswap.Click += new System.EventHandler(this.btn_Gswap_Click);
            // 
            // Frm_28_Advanced
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Gswap);
            this.Controls.Add(this.btn_swap_string);
            this.Controls.Add(this.btn_swap_int);
            this.Name = "Frm_28_Advanced";
            this.Text = "Frm_28_Advanced";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_swap_int;
        private System.Windows.Forms.Button btn_swap_string;
        private System.Windows.Forms.Button btn_Gswap;
    }
}