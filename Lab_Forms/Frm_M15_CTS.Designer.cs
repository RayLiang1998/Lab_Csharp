
namespace Lab_Forms
{
    partial class Frm_M15_CTS
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
            this.btn_callValue = new System.Windows.Forms.Button();
            this.txtb_ref = new System.Windows.Forms.TextBox();
            this.btn_ref = new System.Windows.Forms.Button();
            this.btn_callReference = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_callValue
            // 
            this.btn_callValue.Location = new System.Drawing.Point(52, 48);
            this.btn_callValue.Name = "btn_callValue";
            this.btn_callValue.Size = new System.Drawing.Size(192, 77);
            this.btn_callValue.TabIndex = 0;
            this.btn_callValue.Text = "Value Type";
            this.btn_callValue.UseVisualStyleBackColor = true;
            this.btn_callValue.Click += new System.EventHandler(this.btn_callValue_Click);
            // 
            // txtb_ref
            // 
            this.txtb_ref.Location = new System.Drawing.Point(306, 165);
            this.txtb_ref.Name = "txtb_ref";
            this.txtb_ref.Size = new System.Drawing.Size(192, 22);
            this.txtb_ref.TabIndex = 1;
            // 
            // btn_ref
            // 
            this.btn_ref.Location = new System.Drawing.Point(306, 48);
            this.btn_ref.Name = "btn_ref";
            this.btn_ref.Size = new System.Drawing.Size(192, 77);
            this.btn_ref.TabIndex = 2;
            this.btn_ref.Text = "Reference";
            this.btn_ref.UseVisualStyleBackColor = true;
            this.btn_ref.Click += new System.EventHandler(this.btn_ref_Click);
            // 
            // btn_callReference
            // 
            this.btn_callReference.Location = new System.Drawing.Point(52, 145);
            this.btn_callReference.Name = "btn_callReference";
            this.btn_callReference.Size = new System.Drawing.Size(192, 77);
            this.btn_callReference.TabIndex = 3;
            this.btn_callReference.Text = "Reference Type";
            this.btn_callReference.UseVisualStyleBackColor = true;
            //this.btn_callReference.Click += new System.EventHandler(this.btn_callReference_Click);
            // 
            // Frm_M15_CTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_callReference);
            this.Controls.Add(this.btn_ref);
            this.Controls.Add(this.txtb_ref);
            this.Controls.Add(this.btn_callValue);
            this.Name = "Frm_M15_CTS";
            this.Text = "Frm_M15_CTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_callValue;
        private System.Windows.Forms.TextBox txtb_ref;
        private System.Windows.Forms.Button btn_ref;
        private System.Windows.Forms.Button btn_callReference;
    }
}