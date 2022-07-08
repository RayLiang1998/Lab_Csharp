
namespace Lab_Forms
{
    partial class Frm_M20
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
            this.btn_conv = new System.Windows.Forms.Button();
            this.btn_bool = new System.Windows.Forms.Button();
            this.btn_tenary = new System.Windows.Forms.Button();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.btn_score = new System.Windows.Forms.Button();
            this.lab_grade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_do = new System.Windows.Forms.Button();
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_foreach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_conv
            // 
            this.btn_conv.Location = new System.Drawing.Point(54, 44);
            this.btn_conv.Name = "btn_conv";
            this.btn_conv.Size = new System.Drawing.Size(172, 72);
            this.btn_conv.TabIndex = 0;
            this.btn_conv.Text = "Convert";
            this.btn_conv.UseVisualStyleBackColor = true;
            this.btn_conv.Click += new System.EventHandler(this.btn_conv_Click);
            // 
            // btn_bool
            // 
            this.btn_bool.Location = new System.Drawing.Point(54, 166);
            this.btn_bool.Name = "btn_bool";
            this.btn_bool.Size = new System.Drawing.Size(172, 72);
            this.btn_bool.TabIndex = 1;
            this.btn_bool.Text = "!";
            this.btn_bool.UseVisualStyleBackColor = true;
            this.btn_bool.Click += new System.EventHandler(this.btn_bool_Click);
            // 
            // btn_tenary
            // 
            this.btn_tenary.Location = new System.Drawing.Point(54, 255);
            this.btn_tenary.Name = "btn_tenary";
            this.btn_tenary.Size = new System.Drawing.Size(172, 72);
            this.btn_tenary.TabIndex = 2;
            this.btn_tenary.Text = "!!!";
            this.btn_tenary.UseVisualStyleBackColor = true;
            this.btn_tenary.Click += new System.EventHandler(this.btn_tenary_Click);
            // 
            // txt_score
            // 
            this.txt_score.Location = new System.Drawing.Point(290, 44);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(182, 22);
            this.txt_score.TabIndex = 3;
            // 
            // btn_score
            // 
            this.btn_score.Location = new System.Drawing.Point(304, 93);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(150, 37);
            this.btn_score.TabIndex = 4;
            this.btn_score.Text = "Enter Score";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // lab_grade
            // 
            this.lab_grade.AutoSize = true;
            this.lab_grade.Location = new System.Drawing.Point(497, 50);
            this.lab_grade.Name = "lab_grade";
            this.lab_grade.Size = new System.Drawing.Size(39, 12);
            this.lab_grade.TabIndex = 5;
            this.lab_grade.Text = "Grade: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Switch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(595, 37);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(178, 28);
            this.btn_while.TabIndex = 7;
            this.btn_while.Text = "While";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_do
            // 
            this.btn_do.Location = new System.Drawing.Point(595, 93);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(178, 28);
            this.btn_do.TabIndex = 8;
            this.btn_do.Text = "Do";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(595, 151);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(178, 28);
            this.btn_for.TabIndex = 9;
            this.btn_for.Text = "For";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_foreach
            // 
            this.btn_foreach.Location = new System.Drawing.Point(616, 259);
            this.btn_foreach.Name = "btn_foreach";
            this.btn_foreach.Size = new System.Drawing.Size(140, 65);
            this.btn_foreach.TabIndex = 10;
            this.btn_foreach.Text = "Foreach";
            this.btn_foreach.UseVisualStyleBackColor = true;
            this.btn_foreach.Click += new System.EventHandler(this.btn_foreach_Click);
            // 
            // Frm_M20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_foreach);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_grade);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.btn_tenary);
            this.Controls.Add(this.btn_bool);
            this.Controls.Add(this.btn_conv);
            this.Name = "Frm_M20";
            this.Text = "Frm_M20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conv;
        private System.Windows.Forms.Button btn_bool;
        private System.Windows.Forms.Button btn_tenary;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.Label lab_grade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_foreach;
    }
}