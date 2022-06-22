
namespace Lab_Forms
{
    partial class Frm_M26_array
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
            this.btn_esta_arr = new System.Windows.Forms.Button();
            this.btn_md_arr = new System.Windows.Forms.Button();
            this.btn_return_arr = new System.Windows.Forms.Button();
            this.byn_arrr_mem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_esta_arr
            // 
            this.btn_esta_arr.Location = new System.Drawing.Point(48, 48);
            this.btn_esta_arr.Name = "btn_esta_arr";
            this.btn_esta_arr.Size = new System.Drawing.Size(163, 64);
            this.btn_esta_arr.TabIndex = 0;
            this.btn_esta_arr.Text = "Establish Array";
            this.btn_esta_arr.UseVisualStyleBackColor = true;
            this.btn_esta_arr.Click += new System.EventHandler(this.btn_esta_arr_Click);
            // 
            // btn_md_arr
            // 
            this.btn_md_arr.Location = new System.Drawing.Point(48, 135);
            this.btn_md_arr.Name = "btn_md_arr";
            this.btn_md_arr.Size = new System.Drawing.Size(163, 64);
            this.btn_md_arr.TabIndex = 1;
            this.btn_md_arr.Text = "Establish Multidimentional Array";
            this.btn_md_arr.UseVisualStyleBackColor = true;
            this.btn_md_arr.Click += new System.EventHandler(this.btn_md_arr_Click);
            // 
            // btn_return_arr
            // 
            this.btn_return_arr.Location = new System.Drawing.Point(48, 223);
            this.btn_return_arr.Name = "btn_return_arr";
            this.btn_return_arr.Size = new System.Drawing.Size(163, 64);
            this.btn_return_arr.TabIndex = 2;
            this.btn_return_arr.Text = "Return Array";
            this.btn_return_arr.UseVisualStyleBackColor = true;
            this.btn_return_arr.Click += new System.EventHandler(this.btn_return_arr_Click);
            // 
            // byn_arrr_mem
            // 
            this.byn_arrr_mem.Location = new System.Drawing.Point(48, 308);
            this.byn_arrr_mem.Name = "byn_arrr_mem";
            this.byn_arrr_mem.Size = new System.Drawing.Size(163, 64);
            this.byn_arrr_mem.TabIndex = 3;
            this.byn_arrr_mem.Text = "Array Member";
            this.byn_arrr_mem.UseVisualStyleBackColor = true;
            this.byn_arrr_mem.Click += new System.EventHandler(this.byn_arrr_mem_Click);
            // 
            // Frm_M26_array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.byn_arrr_mem);
            this.Controls.Add(this.btn_return_arr);
            this.Controls.Add(this.btn_md_arr);
            this.Controls.Add(this.btn_esta_arr);
            this.Name = "Frm_M26_array";
            this.Text = "Frm_M26_array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_esta_arr;
        private System.Windows.Forms.Button btn_md_arr;
        private System.Windows.Forms.Button btn_return_arr;
        private System.Windows.Forms.Button byn_arrr_mem;
    }
}