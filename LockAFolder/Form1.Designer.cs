﻿namespace LockAFolder
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.u = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.TextBox();
            this.p2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "lock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "unlock";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // u
            // 
            this.u.Location = new System.Drawing.Point(96, 285);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(359, 123);
            this.u.TabIndex = 3;
            this.u.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(320, 20);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(138, 16);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(154, 20);
            this.p1.TabIndex = 6;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(301, 16);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(154, 20);
            this.p2.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 50);
            this.button6.TabIndex = 8;
            this.button6.Text = "exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 420);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.u);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(1000, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cloasifucan);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moving);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox u;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Button button6;
    }
}

