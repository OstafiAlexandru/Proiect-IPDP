namespace ProiectIPDP
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_NPass = new System.Windows.Forms.TextBox();
            this.txt_ConfirmP = new System.Windows.Forms.TextBox();
            this.txt_FirstN = new System.Windows.Forms.Label();
            this.txt_LastN = new System.Windows.Forms.Label();
            this.txt_Birthday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date of birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Confirm New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_NPass
            // 
            this.txt_NPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NPass.Location = new System.Drawing.Point(260, 206);
            this.txt_NPass.Name = "txt_NPass";
            this.txt_NPass.PasswordChar = '*';
            this.txt_NPass.Size = new System.Drawing.Size(213, 28);
            this.txt_NPass.TabIndex = 10;
            // 
            // txt_ConfirmP
            // 
            this.txt_ConfirmP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmP.Location = new System.Drawing.Point(260, 252);
            this.txt_ConfirmP.Name = "txt_ConfirmP";
            this.txt_ConfirmP.PasswordChar = '*';
            this.txt_ConfirmP.Size = new System.Drawing.Size(213, 28);
            this.txt_ConfirmP.TabIndex = 11;
            // 
            // txt_FirstN
            // 
            this.txt_FirstN.AutoSize = true;
            this.txt_FirstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstN.Location = new System.Drawing.Point(256, 75);
            this.txt_FirstN.Name = "txt_FirstN";
            this.txt_FirstN.Size = new System.Drawing.Size(0, 24);
            this.txt_FirstN.TabIndex = 12;
            // 
            // txt_LastN
            // 
            this.txt_LastN.AutoSize = true;
            this.txt_LastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastN.Location = new System.Drawing.Point(256, 115);
            this.txt_LastN.Name = "txt_LastN";
            this.txt_LastN.Size = new System.Drawing.Size(0, 24);
            this.txt_LastN.TabIndex = 13;
            // 
            // txt_Birthday
            // 
            this.txt_Birthday.AutoSize = true;
            this.txt_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Birthday.Location = new System.Drawing.Point(256, 161);
            this.txt_Birthday.Name = "txt_Birthday";
            this.txt_Birthday.Size = new System.Drawing.Size(0, 24);
            this.txt_Birthday.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Birthday);
            this.Controls.Add(this.txt_LastN);
            this.Controls.Add(this.txt_FirstN);
            this.Controls.Add(this.txt_ConfirmP);
            this.Controls.Add(this.txt_NPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Account Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_NPass;
        private System.Windows.Forms.TextBox txt_ConfirmP;
        private System.Windows.Forms.Label txt_FirstN;
        private System.Windows.Forms.Label txt_LastN;
        private System.Windows.Forms.Label txt_Birthday;
    }
}