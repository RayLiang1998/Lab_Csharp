
namespace Lab_Forms
{
    partial class Frm_M29_GenericArray
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
            this.btn_add_tp = new System.Windows.Forms.Button();
            this.btn_removeat = new System.Windows.Forms.Button();
            this.btrn_clear = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lab_show = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_Eage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add_tp
            // 
            this.btn_add_tp.Location = new System.Drawing.Point(244, 156);
            this.btn_add_tp.Name = "btn_add_tp";
            this.btn_add_tp.Size = new System.Drawing.Size(122, 34);
            this.btn_add_tp.TabIndex = 19;
            this.btn_add_tp.Text = "Add Try Parse";
            this.btn_add_tp.UseVisualStyleBackColor = true;
            this.btn_add_tp.Click += new System.EventHandler(this.btn_add_tp_Click);
            // 
            // btn_removeat
            // 
            this.btn_removeat.Location = new System.Drawing.Point(77, 327);
            this.btn_removeat.Name = "btn_removeat";
            this.btn_removeat.Size = new System.Drawing.Size(122, 34);
            this.btn_removeat.TabIndex = 18;
            this.btn_removeat.Text = "RemoveAt";
            this.btn_removeat.UseVisualStyleBackColor = true;
            this.btn_removeat.Click += new System.EventHandler(this.btn_removeat_Click);
            // 
            // btrn_clear
            // 
            this.btrn_clear.Location = new System.Drawing.Point(77, 269);
            this.btrn_clear.Name = "btrn_clear";
            this.btrn_clear.Size = new System.Drawing.Size(122, 34);
            this.btrn_clear.TabIndex = 17;
            this.btrn_clear.Text = "Clear";
            this.btrn_clear.UseVisualStyleBackColor = true;
            this.btrn_clear.Click += new System.EventHandler(this.btrn_clear_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(77, 212);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(122, 34);
            this.btn_insert.TabIndex = 16;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // lab_show
            // 
            this.lab_show.AutoSize = true;
            this.lab_show.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_show.Location = new System.Drawing.Point(382, 42);
            this.lab_show.Name = "lab_show";
            this.lab_show.Size = new System.Drawing.Size(108, 24);
            this.lab_show.TabIndex = 15;
            this.lab_show.Text = "Employee: ";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(77, 156);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 34);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_Eage
            // 
            this.txt_Eage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Eage.Location = new System.Drawing.Point(98, 92);
            this.txt_Eage.Name = "txt_Eage";
            this.txt_Eage.Size = new System.Drawing.Size(141, 29);
            this.txt_Eage.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Age: ";
            // 
            // txt_Ename
            // 
            this.txt_Ename.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Ename.Location = new System.Drawing.Point(98, 39);
            this.txt_Ename.Name = "txt_Ename";
            this.txt_Ename.Size = new System.Drawing.Size(141, 29);
            this.txt_Ename.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name: ";
            // 
            // Frm_M29_GenericArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add_tp);
            this.Controls.Add(this.btn_removeat);
            this.Controls.Add(this.btrn_clear);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lab_show);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Eage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ename);
            this.Controls.Add(this.label1);
            this.Name = "Frm_M29_GenericArray";
            this.Text = "Frm_M29_GenericArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_tp;
        private System.Windows.Forms.Button btn_removeat;
        private System.Windows.Forms.Button btrn_clear;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lab_show;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_Eage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ename;
        private System.Windows.Forms.Label label1;
    }
}