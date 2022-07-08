
namespace Lab_Forms
{
    partial class Frm_M32
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
            this.components = new System.ComponentModel.Container();
            this.btn_string = new System.Windows.Forms.Button();
            this.btn_stringB = new System.Windows.Forms.Button();
            this.btn_path = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_stringindex = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_strength = new System.Windows.Forms.Label();
            this.lab_validity = new System.Windows.Forms.Label();
            this.tmr_password = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_string
            // 
            this.btn_string.Location = new System.Drawing.Point(45, 44);
            this.btn_string.Name = "btn_string";
            this.btn_string.Size = new System.Drawing.Size(190, 75);
            this.btn_string.TabIndex = 0;
            this.btn_string.Text = "string";
            this.btn_string.UseVisualStyleBackColor = true;
            this.btn_string.Click += new System.EventHandler(this.btn_string_Click);
            // 
            // btn_stringB
            // 
            this.btn_stringB.Location = new System.Drawing.Point(45, 150);
            this.btn_stringB.Name = "btn_stringB";
            this.btn_stringB.Size = new System.Drawing.Size(190, 75);
            this.btn_stringB.TabIndex = 1;
            this.btn_stringB.Text = "string builder";
            this.btn_stringB.UseVisualStyleBackColor = true;
            this.btn_stringB.Click += new System.EventHandler(this.btn_stringB_Click);
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(45, 263);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(190, 75);
            this.btn_path.TabIndex = 2;
            this.btn_path.Text = "path";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(295, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_password.Location = new System.Drawing.Point(413, 61);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(184, 33);
            this.txt_password.TabIndex = 4;
            this.txt_password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_stringindex
            // 
            this.btn_stringindex.Location = new System.Drawing.Point(350, 277);
            this.btn_stringindex.Name = "btn_stringindex";
            this.btn_stringindex.Size = new System.Drawing.Size(139, 60);
            this.btn_stringindex.TabIndex = 5;
            this.btn_stringindex.Text = "string index";
            this.btn_stringindex.UseVisualStyleBackColor = true;
            this.btn_stringindex.Click += new System.EventHandler(this.btn_stringindex_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_id.Location = new System.Drawing.Point(413, 116);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(184, 33);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(295, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // lab_strength
            // 
            this.lab_strength.AutoSize = true;
            this.lab_strength.Location = new System.Drawing.Point(634, 64);
            this.lab_strength.Name = "lab_strength";
            this.lab_strength.Size = new System.Drawing.Size(96, 12);
            this.lab_strength.TabIndex = 8;
            this.lab_strength.Text = "Password Strength: ";
            // 
            // lab_validity
            // 
            this.lab_validity.AutoSize = true;
            this.lab_validity.Location = new System.Drawing.Point(634, 128);
            this.lab_validity.Name = "lab_validity";
            this.lab_validity.Size = new System.Drawing.Size(53, 12);
            this.lab_validity.TabIndex = 9;
            this.lab_validity.Text = "Invalid ID";
            // 
            // tmr_password
            // 
            this.tmr_password.Enabled = true;
            this.tmr_password.Interval = 200;
            this.tmr_password.Tick += new System.EventHandler(this.tmr_password_Tick);
            // 
            // Frm_M32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_validity);
            this.Controls.Add(this.lab_strength);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_stringindex);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.btn_stringB);
            this.Controls.Add(this.btn_string);
            this.Name = "Frm_M32";
            this.Text = "Frm_M32";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_string;
        private System.Windows.Forms.Button btn_stringB;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_stringindex;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_strength;
        private System.Windows.Forms.Label lab_validity;
        private System.Windows.Forms.Timer tmr_password;
    }
}