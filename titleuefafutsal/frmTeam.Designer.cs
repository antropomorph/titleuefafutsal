namespace titleuefafutsal
{
    partial class frmTeam
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
            System.Windows.Forms.Label clubNameLabel;
            System.Windows.Forms.Label clubNameShortLabel;
            System.Windows.Forms.Label clubCoachLabel;
            System.Windows.Forms.Label clubCoachTitleLabel;
            System.Windows.Forms.Label clubLogoLabel;
            System.Windows.Forms.Label clubColorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeam));
            this.cdTeam = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.clubColorTextBox = new System.Windows.Forms.TextBox();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new titleuefafutsal.databaseDataSet();
            this.clubLogoTextBox = new System.Windows.Forms.TextBox();
            this.clubCoachTitleTextBox = new System.Windows.Forms.TextBox();
            this.clubCoachTextBox = new System.Windows.Forms.TextBox();
            this.clubNameShortTextBox = new System.Windows.Forms.TextBox();
            this.clubNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.playerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.playerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamTableAdapter = new titleuefafutsal.databaseDataSetTableAdapters.TeamTableAdapter();
            this.tableAdapterManager = new titleuefafutsal.databaseDataSetTableAdapters.TableAdapterManager();
            this.playerTableAdapter = new titleuefafutsal.databaseDataSetTableAdapters.PlayerTableAdapter();
            this.teamBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.teamBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            clubNameLabel = new System.Windows.Forms.Label();
            clubNameShortLabel = new System.Windows.Forms.Label();
            clubCoachLabel = new System.Windows.Forms.Label();
            clubCoachTitleLabel = new System.Windows.Forms.Label();
            clubLogoLabel = new System.Windows.Forms.Label();
            clubColorLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingNavigator)).BeginInit();
            this.teamBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // clubNameLabel
            // 
            clubNameLabel.AutoSize = true;
            clubNameLabel.Location = new System.Drawing.Point(6, 16);
            clubNameLabel.Name = "clubNameLabel";
            clubNameLabel.Size = new System.Drawing.Size(60, 13);
            clubNameLabel.TabIndex = 0;
            clubNameLabel.Text = "Название:";
            // 
            // clubNameShortLabel
            // 
            clubNameShortLabel.AutoSize = true;
            clubNameShortLabel.Location = new System.Drawing.Point(279, 16);
            clubNameShortLabel.Name = "clubNameShortLabel";
            clubNameShortLabel.Size = new System.Drawing.Size(57, 13);
            clubNameShortLabel.TabIndex = 2;
            clubNameShortLabel.Text = "короткое:";
            // 
            // clubCoachLabel
            // 
            clubCoachLabel.AutoSize = true;
            clubCoachLabel.Location = new System.Drawing.Point(6, 42);
            clubCoachLabel.Name = "clubCoachLabel";
            clubCoachLabel.Size = new System.Drawing.Size(47, 13);
            clubCoachLabel.TabIndex = 4;
            clubCoachLabel.Text = "Тренер:";
            // 
            // clubCoachTitleLabel
            // 
            clubCoachTitleLabel.AutoSize = true;
            clubCoachTitleLabel.Location = new System.Drawing.Point(279, 42);
            clubCoachTitleLabel.Name = "clubCoachTitleLabel";
            clubCoachTitleLabel.Size = new System.Drawing.Size(65, 13);
            clubCoachTitleLabel.TabIndex = 6;
            clubCoachTitleLabel.Text = "должность:";
            // 
            // clubLogoLabel
            // 
            clubLogoLabel.AutoSize = true;
            clubLogoLabel.Location = new System.Drawing.Point(6, 68);
            clubLogoLabel.Name = "clubLogoLabel";
            clubLogoLabel.Size = new System.Drawing.Size(52, 13);
            clubLogoLabel.TabIndex = 8;
            clubLogoLabel.Text = "Логотип:";
            // 
            // clubColorLabel
            // 
            clubColorLabel.AutoSize = true;
            clubColorLabel.Location = new System.Drawing.Point(279, 71);
            clubColorLabel.Name = "clubColorLabel";
            clubColorLabel.Size = new System.Drawing.Size(35, 13);
            clubColorLabel.TabIndex = 10;
            clubColorLabel.Text = "Цвет:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(511, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(606, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdLogo
            // 
            this.ofdLogo.Filter = "PNG|*.png";
            this.ofdLogo.RestoreDirectory = true;
            this.ofdLogo.Title = "Выбор логотипа";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLogo);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(clubColorLabel);
            this.groupBox2.Controls.Add(this.clubColorTextBox);
            this.groupBox2.Controls.Add(clubLogoLabel);
            this.groupBox2.Controls.Add(this.clubLogoTextBox);
            this.groupBox2.Controls.Add(clubCoachTitleLabel);
            this.groupBox2.Controls.Add(this.clubCoachTitleTextBox);
            this.groupBox2.Controls.Add(clubCoachLabel);
            this.groupBox2.Controls.Add(this.clubCoachTextBox);
            this.groupBox2.Controls.Add(clubNameShortLabel);
            this.groupBox2.Controls.Add(this.clubNameShortTextBox);
            this.groupBox2.Controls.Add(clubNameLabel);
            this.groupBox2.Controls.Add(this.clubNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 97);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnLogo
            // 
            this.btnLogo.Location = new System.Drawing.Point(244, 62);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(24, 24);
            this.btnLogo.TabIndex = 13;
            this.btnLogo.Text = "...";
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(456, 60);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(24, 24);
            this.btnColor.TabIndex = 12;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // clubColorTextBox
            // 
            this.clubColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "ClubColor", true));
            this.clubColorTextBox.Location = new System.Drawing.Point(350, 64);
            this.clubColorTextBox.Name = "clubColorTextBox";
            this.clubColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.clubColorTextBox.TabIndex = 11;
            this.clubColorTextBox.TextChanged += new System.EventHandler(this.clubColorTextBox_TextChanged);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.databaseDataSet;
            this.teamBindingSource.CurrentChanged += new System.EventHandler(this.teamBindingSource_CurrentChanged);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clubLogoTextBox
            // 
            this.clubLogoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "ClubLogo", true));
            this.clubLogoTextBox.Location = new System.Drawing.Point(74, 65);
            this.clubLogoTextBox.Name = "clubLogoTextBox";
            this.clubLogoTextBox.Size = new System.Drawing.Size(164, 20);
            this.clubLogoTextBox.TabIndex = 9;
            // 
            // clubCoachTitleTextBox
            // 
            this.clubCoachTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "ClubCoachTitle", true));
            this.clubCoachTitleTextBox.Location = new System.Drawing.Point(350, 39);
            this.clubCoachTitleTextBox.Name = "clubCoachTitleTextBox";
            this.clubCoachTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.clubCoachTitleTextBox.TabIndex = 7;
            // 
            // clubCoachTextBox
            // 
            this.clubCoachTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "ClubCoach", true));
            this.clubCoachTextBox.Location = new System.Drawing.Point(74, 39);
            this.clubCoachTextBox.Name = "clubCoachTextBox";
            this.clubCoachTextBox.Size = new System.Drawing.Size(193, 20);
            this.clubCoachTextBox.TabIndex = 5;
            // 
            // clubNameShortTextBox
            // 
            this.clubNameShortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "ClubNameShort", true));
            this.clubNameShortTextBox.Location = new System.Drawing.Point(350, 13);
            this.clubNameShortTextBox.Name = "clubNameShortTextBox";
            this.clubNameShortTextBox.Size = new System.Drawing.Size(100, 20);
            this.clubNameShortTextBox.TabIndex = 3;
            // 
            // clubNameTextBox
            // 
            this.clubNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teamBindingSource, "ClubName", true));
            this.clubNameTextBox.Location = new System.Drawing.Point(74, 13);
            this.clubNameTextBox.Name = "clubNameTextBox";
            this.clubNameTextBox.Size = new System.Drawing.Size(193, 20);
            this.clubNameTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 447);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команда";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.teamBindingSource;
            this.comboBox1.DisplayMember = "ClubName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.ValueMember = "IDClub";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bindingNavigator1);
            this.groupBox3.Controls.Add(this.playerDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(6, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 299);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Состав";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.playerBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.playerBindingNavigatorSaveItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(665, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.databaseDataSet;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // playerBindingNavigatorSaveItem
            // 
            this.playerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playerBindingNavigatorSaveItem.Image")));
            this.playerBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playerBindingNavigatorSaveItem.Name = "playerBindingNavigatorSaveItem";
            this.playerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.playerBindingNavigatorSaveItem.Text = "playerBindingNavigatorSaveItem";
            this.playerBindingNavigatorSaveItem.Click += new System.EventHandler(this.playerBindingNavigatorSaveItem_Click);
            // 
            // playerDataGridView
            // 
            this.playerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDataGridView.AutoGenerateColumns = false;
            this.playerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.playerDataGridView.DataSource = this.playerBindingSource;
            this.playerDataGridView.Location = new System.Drawing.Point(6, 46);
            this.playerDataGridView.MultiSelect = false;
            this.playerDataGridView.Name = "playerDataGridView";
            this.playerDataGridView.Size = new System.Drawing.Size(658, 246);
            this.playerDataGridView.TabIndex = 0;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsVisible";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Видим";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 50;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PlayerPosition";
            this.dataGridViewTextBoxColumn6.FillWeight = 170.068F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Позиция";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Позиция в списке";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlayerName";
            this.dataGridViewTextBoxColumn2.FillWeight = 82.48299F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Имя";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PlayerSurname";
            this.dataGridViewTextBoxColumn3.FillWeight = 82.48299F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "Фамилия";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PlayerNumber";
            this.dataGridViewTextBoxColumn4.FillWeight = 82.48299F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Номер игрока";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PlayerRole";
            this.dataGridViewTextBoxColumn5.FillWeight = 82.48299F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Амплуа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Амплуа";
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlayerTableAdapter = this.playerTableAdapter;
            this.tableAdapterManager.TeamTableAdapter = this.teamTableAdapter;
            this.tableAdapterManager.UpdateOrder = titleuefafutsal.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // teamBindingNavigator
            // 
            this.teamBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.teamBindingNavigator.BindingSource = this.teamBindingSource;
            this.teamBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teamBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.teamBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.teamBindingNavigatorSaveItem});
            this.teamBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teamBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teamBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teamBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teamBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teamBindingNavigator.Name = "teamBindingNavigator";
            this.teamBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teamBindingNavigator.Size = new System.Drawing.Size(696, 25);
            this.teamBindingNavigator.TabIndex = 9;
            this.teamBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // teamBindingNavigatorSaveItem
            // 
            this.teamBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.teamBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("teamBindingNavigatorSaveItem.Image")));
            this.teamBindingNavigatorSaveItem.Name = "teamBindingNavigatorSaveItem";
            this.teamBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.teamBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.teamBindingNavigatorSaveItem.Click += new System.EventHandler(this.teamBindingNavigatorSaveItem_Click);
            // 
            // frmTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 518);
            this.Controls.Add(this.teamBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTeam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeam_FormClosing);
            this.Load += new System.EventHandler(this.frmTeam_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingNavigator)).EndInit();
            this.teamBindingNavigator.ResumeLayout(false);
            this.teamBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog cdTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog ofdLogo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private databaseDataSetTableAdapters.TeamTableAdapter teamTableAdapter;
        private databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teamBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton teamBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox clubColorTextBox;
        private System.Windows.Forms.TextBox clubLogoTextBox;
        private System.Windows.Forms.TextBox clubCoachTitleTextBox;
        private System.Windows.Forms.TextBox clubCoachTextBox;
        private System.Windows.Forms.TextBox clubNameShortTextBox;
        private System.Windows.Forms.TextBox clubNameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private databaseDataSetTableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridView playerDataGridView;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton playerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}