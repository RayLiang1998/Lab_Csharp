
namespace Lab_Forms
{
    partial class Frm_M16
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
            this.btn_byVT = new System.Windows.Forms.Button();
            this.btn_byRT = new System.Windows.Forms.Button();
            this.btn_VtoR = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.btn_params = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_byVT
            // 
            this.btn_byVT.Location = new System.Drawing.Point(44, 36);
            this.btn_byVT.Name = "btn_byVT";
            this.btn_byVT.Size = new System.Drawing.Size(168, 57);
            this.btn_byVT.TabIndex = 0;
            this.btn_byVT.Text = "by Value Type";
            this.btn_byVT.UseVisualStyleBackColor = true;
            this.btn_byVT.Click += new System.EventHandler(this.btn_byVT_Click);
            // 
            // btn_byRT
            // 
            this.btn_byRT.Location = new System.Drawing.Point(44, 99);
            this.btn_byRT.Name = "btn_byRT";
            this.btn_byRT.Size = new System.Drawing.Size(168, 57);
            this.btn_byRT.TabIndex = 1;
            this.btn_byRT.Text = "by Reference Type";
            this.btn_byRT.UseVisualStyleBackColor = true;
            this.btn_byRT.Click += new System.EventHandler(this.btn_byRT_Click);
            // 
            // btn_VtoR
            // 
            this.btn_VtoR.Location = new System.Drawing.Point(44, 162);
            this.btn_VtoR.Name = "btn_VtoR";
            this.btn_VtoR.Size = new System.Drawing.Size(168, 57);
            this.btn_VtoR.TabIndex = 2;
            this.btn_VtoR.Text = "Value to Reference Type";
            this.btn_VtoR.UseVisualStyleBackColor = true;
            this.btn_VtoR.Click += new System.EventHandler(this.btn_VtoR_Click);
            // 
            // btn_out
            // 
            this.btn_out.Location = new System.Drawing.Point(44, 225);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(168, 57);
            this.btn_out.TabIndex = 3;
            this.btn_out.Text = "Out";
            this.btn_out.UseVisualStyleBackColor = true;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // btn_params
            // 
            this.btn_params.Location = new System.Drawing.Point(44, 288);
            this.btn_params.Name = "btn_params";
            this.btn_params.Size = new System.Drawing.Size(168, 57);
            this.btn_params.TabIndex = 4;
            this.btn_params.Text = "Params";
            this.btn_params.UseVisualStyleBackColor = true;
            this.btn_params.Click += new System.EventHandler(this.btn_params_Click);
            // 
            // Frm_M16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_params);
            this.Controls.Add(this.btn_out);
            this.Controls.Add(this.btn_VtoR);
            this.Controls.Add(this.btn_byRT);
            this.Controls.Add(this.btn_byVT);
            this.Name = "Frm_M16";
            this.Text = "Frm_M16";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_byVT;
        private System.Windows.Forms.Button btn_byRT;
        private System.Windows.Forms.Button btn_VtoR;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_params;
    }
}