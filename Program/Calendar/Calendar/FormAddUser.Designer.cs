namespace Calendar
{
    partial class FormAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetUsers = new Calendar.DataSetUsers();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new Calendar.DataSetUsersTableAdapters.tblUsersTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.userTel = new System.Windows.Forms.TextBox();
            this.userMobile = new System.Windows.Forms.TextBox();
            this.userMail = new System.Windows.Forms.TextBox();
            this.userBirthday = new System.Windows.Forms.DateTimePicker();
            this.userIsManager = new System.Windows.Forms.CheckBox();
            this.userPictureLocation = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(800, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "הוספת משתמש";
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "DataSetUsers";
            this.dataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.dataSetUsers;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.userPassword1,
            this.dataGridViewTextBoxColumn11});
            this.dataGridView2.DataSource = this.tblUsersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 345);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(1697, 185);
            this.dataGridView2.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "userID";
            this.dataGridViewTextBoxColumn1.HeaderText = "תעודת זהות";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "userFirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "שם פרטי";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "userLastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "שם משפחה";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "userEngDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "תאריך לידה";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "userAddress";
            this.dataGridViewTextBoxColumn5.HeaderText = "כתובת";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "userCity";
            this.dataGridViewTextBoxColumn6.HeaderText = "עיר";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "userIsAdmin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "מנהל";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "userPhone";
            this.dataGridViewTextBoxColumn7.HeaderText = "טלפון";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "userMobile";
            this.dataGridViewTextBoxColumn8.HeaderText = "נייד";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "userMail";
            this.dataGridViewTextBoxColumn9.HeaderText = "מייל";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // userPassword1
            // 
            this.userPassword1.DataPropertyName = "userPassword";
            this.userPassword1.HeaderText = "סיסמא";
            this.userPassword1.Name = "userPassword1";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "userPicture";
            this.dataGridViewTextBoxColumn11.HeaderText = "תמונה";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1171, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "כתובת";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1513, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "תעודת זהות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1519, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "שם משפחה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1535, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "שם פרטי";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1132, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "תאריך לידה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1191, 164);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "עיר";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(735, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "טלפון";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(747, 123);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "נייד";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(744, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "מייל";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1548, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "סיסמא";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(443, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "תמונה";
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(1360, 73);
            this.userID.Margin = new System.Windows.Forms.Padding(4);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(132, 22);
            this.userID.TabIndex = 29;
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(1360, 123);
            this.userFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(132, 22);
            this.userFirstName.TabIndex = 29;
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(1360, 160);
            this.userLastName.Margin = new System.Windows.Forms.Padding(4);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(132, 22);
            this.userLastName.TabIndex = 29;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(1360, 204);
            this.userPassword.Margin = new System.Windows.Forms.Padding(4);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(132, 22);
            this.userPassword.TabIndex = 29;
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(1029, 119);
            this.userAddress.Margin = new System.Windows.Forms.Padding(4);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(132, 22);
            this.userAddress.TabIndex = 29;
            // 
            // userTel
            // 
            this.userTel.Location = new System.Drawing.Point(568, 73);
            this.userTel.Margin = new System.Windows.Forms.Padding(4);
            this.userTel.Name = "userTel";
            this.userTel.Size = new System.Drawing.Size(132, 22);
            this.userTel.TabIndex = 29;
            // 
            // userMobile
            // 
            this.userMobile.Location = new System.Drawing.Point(568, 119);
            this.userMobile.Margin = new System.Windows.Forms.Padding(4);
            this.userMobile.Name = "userMobile";
            this.userMobile.Size = new System.Drawing.Size(132, 22);
            this.userMobile.TabIndex = 29;
            // 
            // userMail
            // 
            this.userMail.Location = new System.Drawing.Point(568, 164);
            this.userMail.Margin = new System.Windows.Forms.Padding(4);
            this.userMail.Name = "userMail";
            this.userMail.Size = new System.Drawing.Size(132, 22);
            this.userMail.TabIndex = 29;
            // 
            // userBirthday
            // 
            this.userBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.userBirthday.Location = new System.Drawing.Point(988, 73);
            this.userBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(135, 22);
            this.userBirthday.TabIndex = 30;
            // 
            // userIsManager
            // 
            this.userIsManager.AutoSize = true;
            this.userIsManager.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userIsManager.Location = new System.Drawing.Point(708, 208);
            this.userIsManager.Margin = new System.Windows.Forms.Padding(4);
            this.userIsManager.Name = "userIsManager";
            this.userIsManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userIsManager.Size = new System.Drawing.Size(66, 21);
            this.userIsManager.TabIndex = 31;
            this.userIsManager.Text = "מנהל?";
            this.userIsManager.UseVisualStyleBackColor = true;
            // 
            // userPictureLocation
            // 
            this.userPictureLocation.Location = new System.Drawing.Point(105, 64);
            this.userPictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.userPictureLocation.Name = "userPictureLocation";
            this.userPictureLocation.Size = new System.Drawing.Size(316, 22);
            this.userPictureLocation.TabIndex = 32;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(16, 60);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.browseButton.Size = new System.Drawing.Size(81, 28);
            this.browseButton.TabIndex = 33;
            this.browseButton.Text = "עיון...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(1001, 164);
            this.comboBoxCities.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCities.TabIndex = 36;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addButton.Location = new System.Drawing.Point(805, 224);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 65);
            this.addButton.TabIndex = 64;
            this.addButton.Text = "הוסף";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(801, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 66;
            this.label12.Text = "טבלת משתמשים";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1761, 560);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.comboBoxCities);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.userPictureLocation);
            this.Controls.Add(this.userIsManager);
            this.Controls.Add(this.userBirthday);
            this.Controls.Add(this.userMail);
            this.Controls.Add(this.userMobile);
            this.Controls.Add(this.userTel);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DataSetUsersTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userTel;
        private System.Windows.Forms.TextBox userMobile;
        private System.Windows.Forms.TextBox userMail;
        private System.Windows.Forms.DateTimePicker userBirthday;
        private System.Windows.Forms.CheckBox userIsManager;
        private System.Windows.Forms.TextBox userPictureLocation;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label12;
    }
}