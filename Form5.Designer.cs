namespace Intro
{
    partial class Form5
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
            this.Password = new System.Windows.Forms.TextBox();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passerror = new System.Windows.Forms.TextBox();
            this.matcherror = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(128, 57);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(273, 22);
            this.Password.TabIndex = 0;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Password2
            // 
            this.Password2.Location = new System.Drawing.Point(125, 135);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(276, 22);
            this.Password2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(111, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(4, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password";
            // 
            // passerror
            // 
            this.passerror.BackColor = System.Drawing.SystemColors.MenuText;
            this.passerror.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passerror.Location = new System.Drawing.Point(89, 85);
            this.passerror.Name = "passerror";
            this.passerror.ReadOnly = true;
            this.passerror.Size = new System.Drawing.Size(321, 15);
            this.passerror.TabIndex = 13;
            // 
            // matcherror
            // 
            this.matcherror.BackColor = System.Drawing.SystemColors.InfoText;
            this.matcherror.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matcherror.Location = new System.Drawing.Point(68, 163);
            this.matcherror.Name = "matcherror";
            this.matcherror.ReadOnly = true;
            this.matcherror.Size = new System.Drawing.Size(342, 15);
            this.matcherror.TabIndex = 14;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(410, 297);
            this.Controls.Add(this.matcherror);
            this.Controls.Add(this.passerror);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Password);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passerror;
        private System.Windows.Forms.TextBox matcherror;
    }
}