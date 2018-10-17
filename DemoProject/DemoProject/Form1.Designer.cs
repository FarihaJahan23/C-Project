namespace DemoProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserIdText = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserIdText
            // 
            this.UserIdText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UserIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UserIdText.Location = new System.Drawing.Point(274, 113);
            this.UserIdText.Multiline = true;
            this.UserIdText.Name = "UserIdText";
            this.UserIdText.Size = new System.Drawing.Size(145, 28);
            this.UserIdText.TabIndex = 0;
            this.UserIdText.Text = "userid";
            this.UserIdText.TextChanged += new System.EventHandler(this.UserNameText_TextChanged);
            this.UserIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameText_KeyDown);
            this.UserIdText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserNameText_KeyUp);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(77, 256);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(275, 79);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.ForeColor = System.Drawing.Color.Gray;
            this.PasswordText.Location = new System.Drawing.Point(274, 166);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(145, 29);
            this.PasswordText.TabIndex = 3;
            this.PasswordText.Text = "password";
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            this.PasswordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordText_KeyDown);
            this.PasswordText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PasswordText_KeyUp);
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Chartreuse;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.Location = new System.Drawing.Point(419, 256);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(263, 71);
            this.SignIn.TabIndex = 4;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "KIDZ PLAY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserIdText);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserIdText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Label label1;
    }
}