namespace Calendar
{
    partial class FormUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateUser));
            this.updateButton = new System.Windows.Forms.Button();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.userPictureLocation = new System.Windows.Forms.TextBox();
            this.userIsManager = new System.Windows.Forms.CheckBox();
            this.userBirthday = new System.Windows.Forms.DateTimePicker();
            this.userMail = new System.Windows.Forms.TextBox();
            this.userMobile = new System.Windows.Forms.TextBox();
            this.userTel = new System.Windows.Forms.TextBox();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
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
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.updateButton.Location = new System.Drawing.Point(726, 252);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(156, 65);
            this.updateButton.TabIndex = 92;
            this.updateButton.Text = "עדכן";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(1009, 178);
            this.comboBoxCities.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCities.TabIndex = 91;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 109);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(24, 75);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.browseButton.Size = new System.Drawing.Size(81, 28);
            this.browseButton.TabIndex = 89;
            this.browseButton.Text = "עיון...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
            // 
            // userPictureLocation
            // 
            this.userPictureLocation.Location = new System.Drawing.Point(113, 79);
            this.userPictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.userPictureLocation.Name = "userPictureLocation";
            this.userPictureLocation.Size = new System.Drawing.Size(316, 22);
            this.userPictureLocation.TabIndex = 88;
            // 
            // userIsManager
            // 
            this.userIsManager.AutoSize = true;
            this.userIsManager.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userIsManager.Location = new System.Drawing.Point(716, 223);
            this.userIsManager.Margin = new System.Windows.Forms.Padding(4);
            this.userIsManager.Name = "userIsManager";
            this.userIsManager.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userIsManager.Size = new System.Drawing.Size(66, 21);
            this.userIsManager.TabIndex = 87;
            this.userIsManager.Text = "מנהל?";
            this.userIsManager.UseVisualStyleBackColor = true;
            // 
            // userBirthday
            // 
            this.userBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.userBirthday.Location = new System.Drawing.Point(996, 87);
            this.userBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.userBirthday.Name = "userBirthday";
            this.userBirthday.Size = new System.Drawing.Size(135, 22);
            this.userBirthday.TabIndex = 86;
            // 
            // userMail
            // 
            this.userMail.Location = new System.Drawing.Point(576, 178);
            this.userMail.Margin = new System.Windows.Forms.Padding(4);
            this.userMail.Name = "userMail";
            this.userMail.Size = new System.Drawing.Size(132, 22);
            this.userMail.TabIndex = 84;
            // 
            // userMobile
            // 
            this.userMobile.Location = new System.Drawing.Point(576, 134);
            this.userMobile.Margin = new System.Windows.Forms.Padding(4);
            this.userMobile.Name = "userMobile";
            this.userMobile.Size = new System.Drawing.Size(132, 22);
            this.userMobile.TabIndex = 83;
            // 
            // userTel
            // 
            this.userTel.Location = new System.Drawing.Point(576, 87);
            this.userTel.Margin = new System.Windows.Forms.Padding(4);
            this.userTel.Name = "userTel";
            this.userTel.Size = new System.Drawing.Size(132, 22);
            this.userTel.TabIndex = 82;
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(1037, 134);
            this.userAddress.Margin = new System.Windows.Forms.Padding(4);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(132, 22);
            this.userAddress.TabIndex = 81;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(1368, 219);
            this.userPassword.Margin = new System.Windows.Forms.Padding(4);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(132, 22);
            this.userPassword.TabIndex = 80;
            this.userPassword.Visible = false;
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(1368, 175);
            this.userLastName.Margin = new System.Windows.Forms.Padding(4);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(132, 22);
            this.userLastName.TabIndex = 85;
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(1368, 138);
            this.userFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(132, 22);
            this.userFirstName.TabIndex = 78;
            // 
            // userID
            // 
            this.userID.Enabled = false;
            this.userID.Location = new System.Drawing.Point(1368, 87);
            this.userID.Margin = new System.Windows.Forms.Padding(4);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(132, 22);
            this.userID.TabIndex = 79;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1140, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 77;
            this.label6.Text = "תאריך לידה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(808, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "עדכון משתמש";
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
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.userPassword2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn11});
            this.dataGridView2.DataSource = this.tblUsersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(16, 358);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1697, 185);
            this.dataGridView2.TabIndex = 66;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // userPassword2
            // 
            this.userPassword2.DataPropertyName = "userPassword";
            this.userPassword2.HeaderText = "סיסמא";
            this.userPassword2.Name = "userPassword2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "userIsAdmin";
            this.dataGridViewCheckBoxColumn1.HeaderText = "מנהל";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "userPicture";
            this.dataGridViewTextBoxColumn11.HeaderText = "תמונה";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 82);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 72;
            this.label13.Text = "תמונה";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(1556, 223);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(44, 17);
            this.labelPassword.TabIndex = 71;
            this.labelPassword.Text = "סיסמא";
            this.labelPassword.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(752, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "מייל";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(755, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 69;
            this.label9.Text = "נייד";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "טלפון";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1199, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "עיר";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1543, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "שם פרטי";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1527, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "שם משפחה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1521, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "תעודת זהות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1179, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "כתובת";
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(1403, 277);
            this.firstButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(80, 41);
            this.firstButton.TabIndex = 96;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstButtonClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(1037, 277);
            this.lastButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(81, 41);
            this.lastButton.TabIndex = 95;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastButtonClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(1171, 277);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(83, 41);
            this.nextButton.TabIndex = 94;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(1275, 277);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(83, 41);
            this.prevButton.TabIndex = 93;
            this.prevButton.Text = "הקודם";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButtonClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(809, 334);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 97;
            this.label12.Text = "טבלת משתמשים";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteButton.Location = new System.Drawing.Point(889, 252);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 64);
            this.deleteButton.TabIndex = 115;
            this.deleteButton.Text = "מחק רשומה";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // FormUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1761, 569);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.updateButton);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUpdateUser";
            this.Text = "FormUpdateUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox userPictureLocation;
        private System.Windows.Forms.CheckBox userIsManager;
        private System.Windows.Forms.DateTimePicker userBirthday;
        private System.Windows.Forms.TextBox userMail;
        private System.Windows.Forms.TextBox userMobile;
        private System.Windows.Forms.TextBox userTel;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DataSetUsersTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button deleteButton;
    }
}