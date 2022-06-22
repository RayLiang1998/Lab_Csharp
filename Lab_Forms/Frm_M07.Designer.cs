
namespace Lab_Forms
{
    partial class Frm_M07
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
            this.btn_init = new System.Windows.Forms.Button();
            this.btn_reg0 = new System.Windows.Forms.Button();
            this.btn_reg1 = new System.Windows.Forms.Button();
            this.btn_reg2 = new System.Windows.Forms.Button();
            this.btn_deReg = new System.Windows.Forms.Button();
            this.txtb_org = new System.Windows.Forms.TextBox();
            this.cmb_disc = new System.Windows.Forms.ComboBox();
            this.btn_finalprice = new System.Windows.Forms.Button();
            this.btn_setp = new System.Windows.Forms.Button();
            this.btn_123 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(597, 49);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(179, 60);
            this.btn_init.TabIndex = 0;
            this.btn_init.Text = "initialization";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // btn_reg0
            // 
            this.btn_reg0.Location = new System.Drawing.Point(47, 41);
            this.btn_reg0.Name = "btn_reg0";
            this.btn_reg0.Size = new System.Drawing.Size(141, 41);
            this.btn_reg0.TabIndex = 1;
            this.btn_reg0.Text = "Register";
            this.btn_reg0.UseVisualStyleBackColor = true;
            this.btn_reg0.Click += new System.EventHandler(this.btn_reg0_Click);
            // 
            // btn_reg1
            // 
            this.btn_reg1.Location = new System.Drawing.Point(47, 88);
            this.btn_reg1.Name = "btn_reg1";
            this.btn_reg1.Size = new System.Drawing.Size(141, 41);
            this.btn_reg1.TabIndex = 2;
            this.btn_reg1.Text = "Register1";
            this.btn_reg1.UseVisualStyleBackColor = true;
            // 
            // btn_reg2
            // 
            this.btn_reg2.Location = new System.Drawing.Point(47, 135);
            this.btn_reg2.Name = "btn_reg2";
            this.btn_reg2.Size = new System.Drawing.Size(141, 41);
            this.btn_reg2.TabIndex = 3;
            this.btn_reg2.Text = "Register2";
            this.btn_reg2.UseVisualStyleBackColor = true;
            // 
            // btn_deReg
            // 
            this.btn_deReg.Location = new System.Drawing.Point(47, 182);
            this.btn_deReg.Name = "btn_deReg";
            this.btn_deReg.Size = new System.Drawing.Size(141, 41);
            this.btn_deReg.TabIndex = 4;
            this.btn_deReg.Text = "deRegister";
            this.btn_deReg.UseVisualStyleBackColor = true;
            this.btn_deReg.Click += new System.EventHandler(this.btn_deReg_Click);
            // 
            // txtb_org
            // 
            this.txtb_org.Location = new System.Drawing.Point(258, 41);
            this.txtb_org.Name = "txtb_org";
            this.txtb_org.Size = new System.Drawing.Size(142, 22);
            this.txtb_org.TabIndex = 5;
            // 
            // cmb_disc
            // 
            this.cmb_disc.FormattingEnabled = true;
            this.cmb_disc.Items.AddRange(new object[] {
            "50% off",
            "20% off"});
            this.cmb_disc.Location = new System.Drawing.Point(258, 81);
            this.cmb_disc.Name = "cmb_disc";
            this.cmb_disc.Size = new System.Drawing.Size(147, 20);
            this.cmb_disc.TabIndex = 6;
            this.cmb_disc.Text = "choose discount";
            // 
            // btn_finalprice
            // 
            this.btn_finalprice.Location = new System.Drawing.Point(258, 116);
            this.btn_finalprice.Name = "btn_finalprice";
            this.btn_finalprice.Size = new System.Drawing.Size(140, 23);
            this.btn_finalprice.TabIndex = 7;
            this.btn_finalprice.Text = "Calculate Final Price";
            this.btn_finalprice.UseVisualStyleBackColor = true;
            this.btn_finalprice.Click += new System.EventHandler(this.btn_finalprice_Click);
            // 
            // btn_setp
            // 
            this.btn_setp.Location = new System.Drawing.Point(597, 135);
            this.btn_setp.Name = "btn_setp";
            this.btn_setp.Size = new System.Drawing.Size(179, 60);
            this.btn_setp.TabIndex = 8;
            this.btn_setp.Text = "set property";
            this.btn_setp.UseVisualStyleBackColor = true;
            this.btn_setp.Click += new System.EventHandler(this.btn_setp_Click);
            // 
            // btn_123
            // 
            this.btn_123.Location = new System.Drawing.Point(597, 225);
            this.btn_123.Name = "btn_123";
            this.btn_123.Size = new System.Drawing.Size(179, 60);
            this.btn_123.TabIndex = 9;
            this.btn_123.Text = "123";
            this.btn_123.UseVisualStyleBackColor = true;
            this.btn_123.Click += new System.EventHandler(this.btn_123_Click);
            // 
            // Frm_M07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_123);
            this.Controls.Add(this.btn_setp);
            this.Controls.Add(this.btn_finalprice);
            this.Controls.Add(this.cmb_disc);
            this.Controls.Add(this.txtb_org);
            this.Controls.Add(this.btn_deReg);
            this.Controls.Add(this.btn_reg2);
            this.Controls.Add(this.btn_reg1);
            this.Controls.Add(this.btn_reg0);
            this.Controls.Add(this.btn_init);
            this.Name = "Frm_M07";
            this.Text = "Frm_M07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_reg0;
        private System.Windows.Forms.Button btn_reg1;
        private System.Windows.Forms.Button btn_reg2;
        private System.Windows.Forms.Button btn_deReg;
        private System.Windows.Forms.TextBox txtb_org;
        private System.Windows.Forms.ComboBox cmb_disc;
        private System.Windows.Forms.Button btn_finalprice;
        private System.Windows.Forms.Button btn_setp;
        private System.Windows.Forms.Button btn_123;
    }
}