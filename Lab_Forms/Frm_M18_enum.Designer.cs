
namespace Lab_Forms
{
    partial class Frm_M18_enum
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
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_varify_enum = new System.Windows.Forms.Button();
            this.btn_switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_product
            // 
            this.btn_product.Enabled = false;
            this.btn_product.Location = new System.Drawing.Point(585, 35);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(184, 87);
            this.btn_product.TabIndex = 0;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_varify_enum
            // 
            this.btn_varify_enum.Location = new System.Drawing.Point(35, 30);
            this.btn_varify_enum.Name = "btn_varify_enum";
            this.btn_varify_enum.Size = new System.Drawing.Size(185, 55);
            this.btn_varify_enum.TabIndex = 1;
            this.btn_varify_enum.Text = "Varity_Enumerator";
            this.btn_varify_enum.UseVisualStyleBackColor = true;
            this.btn_varify_enum.Click += new System.EventHandler(this.btn_varify_enum_Click);
            // 
            // btn_switch
            // 
            this.btn_switch.Location = new System.Drawing.Point(35, 109);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(185, 55);
            this.btn_switch.TabIndex = 2;
            this.btn_switch.Text = "Switch";
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // Frm_M18_enum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_switch);
            this.Controls.Add(this.btn_varify_enum);
            this.Controls.Add(this.btn_product);
            this.Name = "Frm_M18_enum";
            this.Text = "Frm_M18_enum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_varify_enum;
        private System.Windows.Forms.Button btn_switch;
    }
}