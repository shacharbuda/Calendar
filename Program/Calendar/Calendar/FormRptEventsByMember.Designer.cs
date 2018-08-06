namespace Calendar
{
    partial class FormRptEventsByMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRptEventsByMember));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prevButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEngDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIsAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUsers = new Calendar.DataSetUsers();
            this.tblUsersTableAdapter = new Calendar.DataSetUsersTableAdapters.tblUsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "תמונה";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "שעה";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "תאריך";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "שם אירוע";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "מספר מזהה";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "סוג אירוע";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ת.ז. בעל האירוע";
            this.columnHeader1.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(733, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 118;
            this.label1.Text = "דו\"ח אירועים ע\"פ מספר משתמש";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.clearButton.Location = new System.Drawing.Point(1504, 618);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(176, 68);
            this.clearButton.TabIndex = 117;
            this.clearButton.Text = "נקה דו\"ח";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "משך בדקות";
            this.columnHeader7.Width = 100;
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseColorButton.Location = new System.Drawing.Point(1299, 618);
            this.chooseColorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(163, 68);
            this.chooseColorButton.TabIndex = 116;
            this.chooseColorButton.Text = "בחר צבע";
            this.chooseColorButton.UseVisualStyleBackColor = true;
            this.chooseColorButton.Click += new System.EventHandler(this.ChooseColorButtonClick);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(647, 624);
            this.firstButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(80, 41);
            this.firstButton.TabIndex = 115;
            this.firstButton.Text = "ראשון";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstButtonClick);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(259, 624);
            this.lastButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(81, 41);
            this.lastButton.TabIndex = 114;
            this.lastButton.Text = "אחרון";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastButtonClick);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(392, 624);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(83, 41);
            this.nextButton.TabIndex = 113;
            this.nextButton.Text = "הבא";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Location = new System.Drawing.Point(956, 58);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(825, 544);
            this.listView1.TabIndex = 111;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // prevButton
            // 
            this.prevButton.Enabled = false;
            this.prevButton.Location = new System.Drawing.Point(496, 624);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(83, 41);
            this.prevButton.TabIndex = 112;
            this.prevButton.Text = "הקודם";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButtonClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userFirstNameDataGridViewTextBoxColumn,
            this.userLastNameDataGridViewTextBoxColumn,
            this.userEngDateDataGridViewTextBoxColumn,
            this.userAddressDataGridViewTextBoxColumn,
            this.userCityDataGridViewTextBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.userMobileDataGridViewTextBoxColumn,
            this.userMailDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userIsAdminDataGridViewCheckBoxColumn,
            this.userPictureDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblUsersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-3, 58);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(949, 560);
            this.dataGridView2.TabIndex = 110;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "תז";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // userFirstNameDataGridViewTextBoxColumn
            // 
            this.userFirstNameDataGridViewTextBoxColumn.DataPropertyName = "userFirstName";
            this.userFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.userFirstNameDataGridViewTextBoxColumn.Name = "userFirstNameDataGridViewTextBoxColumn";
            // 
            // userLastNameDataGridViewTextBoxColumn
            // 
            this.userLastNameDataGridViewTextBoxColumn.DataPropertyName = "userLastName";
            this.userLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.userLastNameDataGridViewTextBoxColumn.Name = "userLastNameDataGridViewTextBoxColumn";
            // 
            // userEngDateDataGridViewTextBoxColumn
            // 
            this.userEngDateDataGridViewTextBoxColumn.DataPropertyName = "userEngDate";
            this.userEngDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.userEngDateDataGridViewTextBoxColumn.Name = "userEngDateDataGridViewTextBoxColumn";
            // 
            // userAddressDataGridViewTextBoxColumn
            // 
            this.userAddressDataGridViewTextBoxColumn.DataPropertyName = "userAddress";
            this.userAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.userAddressDataGridViewTextBoxColumn.Name = "userAddressDataGridViewTextBoxColumn";
            // 
            // userCityDataGridViewTextBoxColumn
            // 
            this.userCityDataGridViewTextBoxColumn.DataPropertyName = "userCity";
            this.userCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.userCityDataGridViewTextBoxColumn.Name = "userCityDataGridViewTextBoxColumn";
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "userPhone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            // 
            // userMobileDataGridViewTextBoxColumn
            // 
            this.userMobileDataGridViewTextBoxColumn.DataPropertyName = "userMobile";
            this.userMobileDataGridViewTextBoxColumn.HeaderText = "פלאפון";
            this.userMobileDataGridViewTextBoxColumn.Name = "userMobileDataGridViewTextBoxColumn";
            // 
            // userMailDataGridViewTextBoxColumn
            // 
            this.userMailDataGridViewTextBoxColumn.DataPropertyName = "userMail";
            this.userMailDataGridViewTextBoxColumn.HeaderText = "מייל";
            this.userMailDataGridViewTextBoxColumn.Name = "userMailDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "סיסמא";
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // userIsAdminDataGridViewCheckBoxColumn
            // 
            this.userIsAdminDataGridViewCheckBoxColumn.DataPropertyName = "userIsAdmin";
            this.userIsAdminDataGridViewCheckBoxColumn.HeaderText = "מנהל?";
            this.userIsAdminDataGridViewCheckBoxColumn.Name = "userIsAdminDataGridViewCheckBoxColumn";
            // 
            // userPictureDataGridViewTextBoxColumn
            // 
            this.userPictureDataGridViewTextBoxColumn.DataPropertyName = "userPicture";
            this.userPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.userPictureDataGridViewTextBoxColumn.Name = "userPictureDataGridViewTextBoxColumn";
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.dataSetUsers;
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "DataSetUsers";
            this.dataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // FormRptEventsByMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1799, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.chooseColorButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRptEventsByMember";
            this.Text = "FormRptEventsByMember";
            this.Load += new System.EventHandler(this.FormRpyEventsByMemberID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DataSetUsersTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEngDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userIsAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPictureDataGridViewTextBoxColumn;

    }
}