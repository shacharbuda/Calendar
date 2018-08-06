namespace Calendar
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idNumber = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.welcomeButton = new System.Windows.Forms.Button();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "מספר ת\"ז";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "סיסמא";
            // 
            // idNumber
            // 
            this.idNumber.Location = new System.Drawing.Point(155, 84);
            this.idNumber.Margin = new System.Windows.Forms.Padding(4);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(79, 22);
            this.idNumber.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(101, 145);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(132, 22);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(155, 188);
            this.checkButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(64, 28);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "כניסה";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButtonClick);
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(435, 107);
            this.logoPicture.Margin = new System.Windows.Forms.Padding(4);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(198, 71);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logoPicture.TabIndex = 9;
            this.logoPicture.TabStop = false;
            // 
            // welcomeButton
            // 
            this.welcomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.welcomeButton.Location = new System.Drawing.Point(45, 62);
            this.welcomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeButton.Name = "welcomeButton";
            this.welcomeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.welcomeButton.Size = new System.Drawing.Size(301, 182);
            this.welcomeButton.TabIndex = 7;
            this.welcomeButton.Text = "להמשך...";
            this.welcomeButton.UseVisualStyleBackColor = true;
            this.welcomeButton.Visible = false;
            this.welcomeButton.Click += new System.EventHandler(this.WelcomeButtonClick);
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(435, 22);
            this.userPicture.Margin = new System.Windows.Forms.Padding(4);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(289, 256);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicture.TabIndex = 8;
            this.userPicture.TabStop = false;
            this.userPicture.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(187, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "התחברות למערכת";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(771, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.welcomeButton);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.idNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idNumber;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Button welcomeButton;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Label label3;
    }
}