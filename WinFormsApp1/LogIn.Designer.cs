namespace WinFormsApp1
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.CreatUserBuutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(130, 97);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(168, 23);
            this.UserLogin.TabIndex = 3;
            this.UserLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.Location = new System.Drawing.Point(130, 158);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(168, 23);
            this.PasswordLogin.TabIndex = 4;
            this.PasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PasswordLogin.UseSystemPasswordChar = true;
            // 
            // CreatUserBuutton
            // 
            this.CreatUserBuutton.Location = new System.Drawing.Point(130, 208);
            this.CreatUserBuutton.Name = "CreatUserBuutton";
            this.CreatUserBuutton.Size = new System.Drawing.Size(75, 23);
            this.CreatUserBuutton.TabIndex = 5;
            this.CreatUserBuutton.Text = "Create User";
            this.CreatUserBuutton.UseVisualStyleBackColor = true;
            this.CreatUserBuutton.Click += new System.EventHandler(this.CreatUserBuutton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.CreatUserBuutton);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.Button CreatUserBuutton;
    }
}
