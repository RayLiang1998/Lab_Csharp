
namespace Lab_Forms
{
    partial class Frm_M04_OHF
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
            this.btn_OHF = new System.Windows.Forms.Button();
            this.btn_Method1 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn03 = new System.Windows.Forms.Button();
            this.btn_age = new System.Windows.Forms.Button();
            this.btn_encap = new System.Windows.Forms.Button();
            this.btn_parcial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OHF
            // 
            this.btn_OHF.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_OHF.Location = new System.Drawing.Point(542, 85);
            this.btn_OHF.Name = "btn_OHF";
            this.btn_OHF.Size = new System.Drawing.Size(207, 78);
            this.btn_OHF.TabIndex = 0;
            this.btn_OHF.Text = "Open Hello Form";
            this.btn_OHF.UseVisualStyleBackColor = true;
            this.btn_OHF.Click += new System.EventHandler(this.btn_OHF_Click);
            // 
            // btn_Method1
            // 
            this.btn_Method1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Method1.Location = new System.Drawing.Point(542, 207);
            this.btn_Method1.Name = "btn_Method1";
            this.btn_Method1.Size = new System.Drawing.Size(207, 78);
            this.btn_Method1.TabIndex = 1;
            this.btn_Method1.Text = "Method 1";
            this.btn_Method1.UseVisualStyleBackColor = true;
            this.btn_Method1.Click += new System.EventHandler(this.btn_Method1_Click);
            // 
            // btn01
            // 
            this.btn01.Location = new System.Drawing.Point(51, 100);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(95, 50);
            this.btn01.TabIndex = 2;
            this.btn01.Text = "button01";
            this.btn01.UseVisualStyleBackColor = true;
            this.btn01.Click += new System.EventHandler(this.btn01_Click);
            // 
            // btn02
            // 
            this.btn02.Location = new System.Drawing.Point(51, 166);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(95, 50);
            this.btn02.TabIndex = 3;
            this.btn02.Text = "button02";
            this.btn02.UseVisualStyleBackColor = true;
            this.btn02.Click += new System.EventHandler(this.btn02_Click);
            // 
            // btn03
            // 
            this.btn03.Location = new System.Drawing.Point(51, 235);
            this.btn03.Name = "btn03";
            this.btn03.Size = new System.Drawing.Size(95, 50);
            this.btn03.TabIndex = 4;
            this.btn03.Text = "button03";
            this.btn03.UseVisualStyleBackColor = true;
            this.btn03.Click += new System.EventHandler(this.btn03_Click);
            // 
            // btn_age
            // 
            this.btn_age.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_age.Location = new System.Drawing.Point(542, 329);
            this.btn_age.Name = "btn_age";
            this.btn_age.Size = new System.Drawing.Size(207, 78);
            this.btn_age.TabIndex = 5;
            this.btn_age.Text = "Enter Age";
            this.btn_age.UseVisualStyleBackColor = true;
            this.btn_age.Click += new System.EventHandler(this.btn_age_Click);
            // 
            // btn_encap
            // 
            this.btn_encap.Location = new System.Drawing.Point(51, 307);
            this.btn_encap.Name = "btn_encap";
            this.btn_encap.Size = new System.Drawing.Size(95, 50);
            this.btn_encap.TabIndex = 6;
            this.btn_encap.Text = "Encapsulation";
            this.btn_encap.UseVisualStyleBackColor = true;
            this.btn_encap.Click += new System.EventHandler(this.btn_encap_Click);
            // 
            // btn_parcial
            // 
            this.btn_parcial.Location = new System.Drawing.Point(51, 378);
            this.btn_parcial.Name = "btn_parcial";
            this.btn_parcial.Size = new System.Drawing.Size(95, 50);
            this.btn_parcial.TabIndex = 7;
            this.btn_parcial.Text = "Parcial Class test";
            this.btn_parcial.UseVisualStyleBackColor = true;
            this.btn_parcial.Click += new System.EventHandler(this.btn_parcial_Click);
            // 
            // Frm_M04_OHF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_parcial);
            this.Controls.Add(this.btn_encap);
            this.Controls.Add(this.btn_age);
            this.Controls.Add(this.btn03);
            this.Controls.Add(this.btn02);
            this.Controls.Add(this.btn01);
            this.Controls.Add(this.btn_Method1);
            this.Controls.Add(this.btn_OHF);
            this.Name = "Frm_M04_OHF";
            this.Text = "Form_OpenHelloForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OHF;
        private System.Windows.Forms.Button btn_Method1;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn03;
        private System.Windows.Forms.Button btn_age;
        private System.Windows.Forms.Button btn_encap;
        private System.Windows.Forms.Button btn_parcial;
    }
}