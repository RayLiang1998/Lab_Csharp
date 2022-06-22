
namespace Lab_Forms
{
    partial class Frm_M12
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
            this.lab_count = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.gb_var = new System.Windows.Forms.GroupBox();
            this.btn_var1 = new System.Windows.Forms.Button();
            this.btn_var2 = new System.Windows.Forms.Button();
            this.gb_static = new System.Windows.Forms.GroupBox();
            this.btn_staticC = new System.Windows.Forms.Button();
            this.btn_instanceC = new System.Windows.Forms.Button();
            this.lab_IC = new System.Windows.Forms.Label();
            this.lab_SC = new System.Windows.Forms.Label();
            this.btn_ohf_m12 = new System.Windows.Forms.Button();
            this.gb_var.SuspendLayout();
            this.gb_static.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.Location = new System.Drawing.Point(46, 23);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(46, 12);
            this.lab_count.TabIndex = 0;
            this.lab_count.Text = "Count: 0";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(30, 59);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 42);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "+=";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_substract
            // 
            this.btn_substract.Location = new System.Drawing.Point(30, 117);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(108, 42);
            this.btn_substract.TabIndex = 2;
            this.btn_substract.Text = "-=";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // gb_var
            // 
            this.gb_var.Controls.Add(this.btn_var2);
            this.gb_var.Controls.Add(this.btn_var1);
            this.gb_var.Location = new System.Drawing.Point(273, 33);
            this.gb_var.Name = "gb_var";
            this.gb_var.Size = new System.Drawing.Size(339, 158);
            this.gb_var.TabIndex = 3;
            this.gb_var.TabStop = false;
            this.gb_var.Text = "Variables";
            // 
            // btn_var1
            // 
            this.btn_var1.Location = new System.Drawing.Point(41, 41);
            this.btn_var1.Name = "btn_var1";
            this.btn_var1.Size = new System.Drawing.Size(261, 43);
            this.btn_var1.TabIndex = 0;
            this.btn_var1.Text = "variable1";
            this.btn_var1.UseVisualStyleBackColor = true;
            this.btn_var1.Click += new System.EventHandler(this.btn_var1_Click);
            // 
            // btn_var2
            // 
            this.btn_var2.Location = new System.Drawing.Point(41, 102);
            this.btn_var2.Name = "btn_var2";
            this.btn_var2.Size = new System.Drawing.Size(261, 43);
            this.btn_var2.TabIndex = 1;
            this.btn_var2.Text = "variable2";
            this.btn_var2.UseVisualStyleBackColor = true;
            // 
            // gb_static
            // 
            this.gb_static.Controls.Add(this.lab_SC);
            this.gb_static.Controls.Add(this.lab_IC);
            this.gb_static.Controls.Add(this.btn_staticC);
            this.gb_static.Controls.Add(this.btn_instanceC);
            this.gb_static.Location = new System.Drawing.Point(273, 220);
            this.gb_static.Name = "gb_static";
            this.gb_static.Size = new System.Drawing.Size(411, 158);
            this.gb_static.TabIndex = 4;
            this.gb_static.TabStop = false;
            this.gb_static.Text = "Static";
            // 
            // btn_staticC
            // 
            this.btn_staticC.Location = new System.Drawing.Point(41, 102);
            this.btn_staticC.Name = "btn_staticC";
            this.btn_staticC.Size = new System.Drawing.Size(261, 43);
            this.btn_staticC.TabIndex = 1;
            this.btn_staticC.Text = "Static Count";
            this.btn_staticC.UseVisualStyleBackColor = true;
            this.btn_staticC.Click += new System.EventHandler(this.btn_staticC_Click);
            // 
            // btn_instanceC
            // 
            this.btn_instanceC.Location = new System.Drawing.Point(41, 41);
            this.btn_instanceC.Name = "btn_instanceC";
            this.btn_instanceC.Size = new System.Drawing.Size(261, 43);
            this.btn_instanceC.TabIndex = 0;
            this.btn_instanceC.Text = "Instance Count";
            this.btn_instanceC.UseVisualStyleBackColor = true;
            this.btn_instanceC.Click += new System.EventHandler(this.btn_instanceC_Click);
            // 
            // lab_IC
            // 
            this.lab_IC.AutoSize = true;
            this.lab_IC.Location = new System.Drawing.Point(315, 52);
            this.lab_IC.Name = "lab_IC";
            this.lab_IC.Size = new System.Drawing.Size(87, 12);
            this.lab_IC.TabIndex = 2;
            this.lab_IC.Text = "Instance Count: 0";
            // 
            // lab_SC
            // 
            this.lab_SC.AutoSize = true;
            this.lab_SC.Location = new System.Drawing.Point(315, 117);
            this.lab_SC.Name = "lab_SC";
            this.lab_SC.Size = new System.Drawing.Size(74, 12);
            this.lab_SC.TabIndex = 3;
            this.lab_SC.Text = "Static Count: 0";
            // 
            // btn_ohf_m12
            // 
            this.btn_ohf_m12.Location = new System.Drawing.Point(314, 384);
            this.btn_ohf_m12.Name = "btn_ohf_m12";
            this.btn_ohf_m12.Size = new System.Drawing.Size(261, 43);
            this.btn_ohf_m12.TabIndex = 4;
            this.btn_ohf_m12.Text = "Open Hello Form";
            this.btn_ohf_m12.UseVisualStyleBackColor = true;
            this.btn_ohf_m12.Click += new System.EventHandler(this.btn_ohf_m12_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ohf_m12);
            this.Controls.Add(this.gb_static);
            this.Controls.Add(this.gb_var);
            this.Controls.Add(this.btn_substract);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lab_count);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.gb_var.ResumeLayout(false);
            this.gb_static.ResumeLayout(false);
            this.gb_static.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_count;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.GroupBox gb_var;
        private System.Windows.Forms.Button btn_var2;
        private System.Windows.Forms.Button btn_var1;
        private System.Windows.Forms.GroupBox gb_static;
        private System.Windows.Forms.Button btn_staticC;
        private System.Windows.Forms.Button btn_instanceC;
        private System.Windows.Forms.Label lab_SC;
        private System.Windows.Forms.Label lab_IC;
        private System.Windows.Forms.Button btn_ohf_m12;
    }
}