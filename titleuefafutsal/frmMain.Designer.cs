﻿namespace titleuefafutsal
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgvTeamGuest = new System.Windows.Forms.DataGridView();
            this.dgcPlayerGuestIsVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgcPlayerGuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPlayerGuestAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPlayerGuestNation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPlayerGuestFlag = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgcPlayerGuestNationShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPlayerGuestRanking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPlayerGuestHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPlayerGuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPlayerGuestID_TTTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.pbTeamGuestLogo = new System.Windows.Forms.PictureBox();
            this.tbTeamGuestCoach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTeamGuest = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbSemiFinal = new System.Windows.Forms.CheckBox();
            this.btnKillAll = new System.Windows.Forms.Button();
            this.rbPlayerGuest = new System.Windows.Forms.RadioButton();
            this.rbTeamsResult = new System.Windows.Forms.RadioButton();
            this.rbPlayerHome = new System.Windows.Forms.RadioButton();
            this.rbClearGraphics = new System.Windows.Forms.RadioButton();
            this.rbOfficials = new System.Windows.Forms.RadioButton();
            this.rbTeamGuest = new System.Windows.Forms.RadioButton();
            this.rbTeamHome = new System.Windows.Forms.RadioButton();
            this.rbCoachGuest = new System.Windows.Forms.RadioButton();
            this.rbCoachHome = new System.Windows.Forms.RadioButton();
            this.rbScoreBig = new System.Windows.Forms.RadioButton();
            this.rbEventTitle = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTeamHome = new System.Windows.Forms.DataGridView();
            this.dgcPlayerHomeIsVisble = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgcPlayerHomeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbTeamHomeLogo = new System.Windows.Forms.PictureBox();
            this.tbTeamHomeCoach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTeamHome = new System.Windows.Forms.ComboBox();
            this.ofdProject = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startXPressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamGuest)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamGuestLogo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamHome)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamHomeLogo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Location = new System.Drawing.Point(854, 62);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(362, 528);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Команда";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox9.Controls.Add(this.dgvTeamGuest);
            this.groupBox9.Location = new System.Drawing.Point(6, 105);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(349, 417);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Состав";
            // 
            // dgvTeamGuest
            // 
            this.dgvTeamGuest.AllowUserToAddRows = false;
            this.dgvTeamGuest.AllowUserToDeleteRows = false;
            this.dgvTeamGuest.AllowUserToResizeRows = false;
            this.dgvTeamGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcPlayerGuestIsVisible,
            this.dgcPlayerGuestName,
            this.dgcPlayerGuestAge,
            this.dgcPlayerGuestNation,
            this.dgcPlayerGuestFlag,
            this.dgcPlayerGuestNationShort,
            this.dgcPlayerGuestRanking,
            this.dgcPlayerGuestHand,
            this.dgcPlayerGuestID,
            this.dgcPlayerGuestID_TTTeam});
            this.dgvTeamGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamGuest.Location = new System.Drawing.Point(3, 16);
            this.dgvTeamGuest.MultiSelect = false;
            this.dgvTeamGuest.Name = "dgvTeamGuest";
            this.dgvTeamGuest.ReadOnly = true;
            this.dgvTeamGuest.RowHeadersVisible = false;
            this.dgvTeamGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamGuest.ShowEditingIcon = false;
            this.dgvTeamGuest.Size = new System.Drawing.Size(343, 398);
            this.dgvTeamGuest.TabIndex = 1;
            // 
            // dgcPlayerGuestIsVisible
            // 
            this.dgcPlayerGuestIsVisible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcPlayerGuestIsVisible.DataPropertyName = "IsVisible";
            this.dgcPlayerGuestIsVisible.FillWeight = 101.5228F;
            this.dgcPlayerGuestIsVisible.HeaderText = "Видим";
            this.dgcPlayerGuestIsVisible.Name = "dgcPlayerGuestIsVisible";
            this.dgcPlayerGuestIsVisible.ReadOnly = true;
            // 
            // dgcPlayerGuestName
            // 
            this.dgcPlayerGuestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcPlayerGuestName.DataPropertyName = "PlayerName";
            this.dgcPlayerGuestName.FillWeight = 99.49239F;
            this.dgcPlayerGuestName.HeaderText = "Имя";
            this.dgcPlayerGuestName.Name = "dgcPlayerGuestName";
            this.dgcPlayerGuestName.ReadOnly = true;
            // 
            // dgcPlayerGuestAge
            // 
            this.dgcPlayerGuestAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcPlayerGuestAge.DataPropertyName = "PlayerAge";
            this.dgcPlayerGuestAge.FillWeight = 99.49239F;
            this.dgcPlayerGuestAge.HeaderText = "Возраст";
            this.dgcPlayerGuestAge.Name = "dgcPlayerGuestAge";
            this.dgcPlayerGuestAge.ReadOnly = true;
            // 
            // dgcPlayerGuestNation
            // 
            this.dgcPlayerGuestNation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcPlayerGuestNation.DataPropertyName = "PlayerNation";
            this.dgcPlayerGuestNation.FillWeight = 99.49239F;
            this.dgcPlayerGuestNation.HeaderText = "Национальность";
            this.dgcPlayerGuestNation.Name = "dgcPlayerGuestNation";
            this.dgcPlayerGuestNation.ReadOnly = true;
            // 
            // dgcPlayerGuestFlag
            // 
            this.dgcPlayerGuestFlag.DataPropertyName = "PlayerFlag";
            this.dgcPlayerGuestFlag.HeaderText = "Флаг";
            this.dgcPlayerGuestFlag.Name = "dgcPlayerGuestFlag";
            this.dgcPlayerGuestFlag.ReadOnly = true;
            this.dgcPlayerGuestFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcPlayerGuestFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcPlayerGuestFlag.Visible = false;
            this.dgcPlayerGuestFlag.Width = 142;
            // 
            // dgcPlayerGuestNationShort
            // 
            this.dgcPlayerGuestNationShort.DataPropertyName = "PlayerNationShort";
            this.dgcPlayerGuestNationShort.HeaderText = "PlayerNationShort";
            this.dgcPlayerGuestNationShort.Name = "dgcPlayerGuestNationShort";
            this.dgcPlayerGuestNationShort.ReadOnly = true;
            this.dgcPlayerGuestNationShort.Visible = false;
            // 
            // dgcPlayerGuestRanking
            // 
            this.dgcPlayerGuestRanking.DataPropertyName = "PlayerRanking";
            this.dgcPlayerGuestRanking.HeaderText = "PlayerRanking";
            this.dgcPlayerGuestRanking.Name = "dgcPlayerGuestRanking";
            this.dgcPlayerGuestRanking.ReadOnly = true;
            this.dgcPlayerGuestRanking.Visible = false;
            // 
            // dgcPlayerGuestHand
            // 
            this.dgcPlayerGuestHand.DataPropertyName = "PlayerHand";
            this.dgcPlayerGuestHand.HeaderText = "PlayerHand";
            this.dgcPlayerGuestHand.Name = "dgcPlayerGuestHand";
            this.dgcPlayerGuestHand.ReadOnly = true;
            this.dgcPlayerGuestHand.Visible = false;
            // 
            // dgcPlayerGuestID
            // 
            this.dgcPlayerGuestID.DataPropertyName = "ID";
            this.dgcPlayerGuestID.HeaderText = "ID";
            this.dgcPlayerGuestID.Name = "dgcPlayerGuestID";
            this.dgcPlayerGuestID.ReadOnly = true;
            this.dgcPlayerGuestID.Visible = false;
            // 
            // dgcPlayerGuestID_TTTeam
            // 
            this.dgcPlayerGuestID_TTTeam.DataPropertyName = "ID_TTTeam";
            this.dgcPlayerGuestID_TTTeam.HeaderText = "ID_TTTeam";
            this.dgcPlayerGuestID_TTTeam.Name = "dgcPlayerGuestID_TTTeam";
            this.dgcPlayerGuestID_TTTeam.ReadOnly = true;
            this.dgcPlayerGuestID_TTTeam.Visible = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.pbTeamGuestLogo);
            this.groupBox10.Controls.Add(this.tbTeamGuestCoach);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label4);
            this.groupBox10.Controls.Add(this.cbTeamGuest);
            this.groupBox10.Location = new System.Drawing.Point(6, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(349, 80);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            // 
            // pbTeamGuestLogo
            // 
            this.pbTeamGuestLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTeamGuestLogo.Location = new System.Drawing.Point(293, 19);
            this.pbTeamGuestLogo.Name = "pbTeamGuestLogo";
            this.pbTeamGuestLogo.Size = new System.Drawing.Size(47, 47);
            this.pbTeamGuestLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeamGuestLogo.TabIndex = 4;
            this.pbTeamGuestLogo.TabStop = false;
            // 
            // tbTeamGuestCoach
            // 
            this.tbTeamGuestCoach.Location = new System.Drawing.Point(67, 46);
            this.tbTeamGuestCoach.Name = "tbTeamGuestCoach";
            this.tbTeamGuestCoach.ReadOnly = true;
            this.tbTeamGuestCoach.Size = new System.Drawing.Size(220, 20);
            this.tbTeamGuestCoach.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тренер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Название:";
            // 
            // cbTeamGuest
            // 
            this.cbTeamGuest.DisplayMember = "TeamName";
            this.cbTeamGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeamGuest.FormattingEnabled = true;
            this.cbTeamGuest.Location = new System.Drawing.Point(67, 19);
            this.cbTeamGuest.Name = "cbTeamGuest";
            this.cbTeamGuest.Size = new System.Drawing.Size(220, 21);
            this.cbTeamGuest.TabIndex = 0;
            this.cbTeamGuest.ValueMember = "ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Location = new System.Drawing.Point(371, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 528);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление графикой";
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.radioButton1);
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Controls.Add(this.cbSemiFinal);
            this.groupBox8.Controls.Add(this.btnKillAll);
            this.groupBox8.Controls.Add(this.rbPlayerGuest);
            this.groupBox8.Controls.Add(this.rbTeamsResult);
            this.groupBox8.Controls.Add(this.rbPlayerHome);
            this.groupBox8.Controls.Add(this.rbClearGraphics);
            this.groupBox8.Controls.Add(this.rbOfficials);
            this.groupBox8.Controls.Add(this.rbTeamGuest);
            this.groupBox8.Controls.Add(this.rbTeamHome);
            this.groupBox8.Controls.Add(this.rbCoachGuest);
            this.groupBox8.Controls.Add(this.rbCoachHome);
            this.groupBox8.Controls.Add(this.rbScoreBig);
            this.groupBox8.Controls.Add(this.rbEventTitle);
            this.groupBox8.Location = new System.Drawing.Point(6, 121);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(465, 401);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Титры";
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.FlatAppearance.BorderSize = 2;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(244, 199);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(215, 30);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.Text = "Таймаут";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.FlatAppearance.BorderSize = 2;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(6, 199);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(212, 30);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "Таймаут";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cbSemiFinal
            // 
            this.cbSemiFinal.AutoSize = true;
            this.cbSemiFinal.Location = new System.Drawing.Point(376, 27);
            this.cbSemiFinal.Name = "cbSemiFinal";
            this.cbSemiFinal.Size = new System.Drawing.Size(85, 17);
            this.cbSemiFinal.TabIndex = 16;
            this.cbSemiFinal.Text = "SEMI-FINAL";
            this.cbSemiFinal.UseVisualStyleBackColor = true;
            this.cbSemiFinal.CheckedChanged += new System.EventHandler(this.cbSemiFinal_CheckedChanged);
            // 
            // btnKillAll
            // 
            this.btnKillAll.Location = new System.Drawing.Point(6, 326);
            this.btnKillAll.Name = "btnKillAll";
            this.btnKillAll.Size = new System.Drawing.Size(453, 23);
            this.btnKillAll.TabIndex = 15;
            this.btnKillAll.Text = "УБРАТЬ ВСЕ НАХЕР!!!";
            this.btnKillAll.UseVisualStyleBackColor = true;
            this.btnKillAll.Click += new System.EventHandler(this.btnKillAll_Click);
            // 
            // rbPlayerGuest
            // 
            this.rbPlayerGuest.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerGuest.FlatAppearance.BorderSize = 2;
            this.rbPlayerGuest.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbPlayerGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPlayerGuest.Location = new System.Drawing.Point(244, 127);
            this.rbPlayerGuest.Name = "rbPlayerGuest";
            this.rbPlayerGuest.Size = new System.Drawing.Size(215, 30);
            this.rbPlayerGuest.TabIndex = 14;
            this.rbPlayerGuest.Text = "Игрок";
            this.rbPlayerGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPlayerGuest.UseVisualStyleBackColor = true;
            // 
            // rbTeamsResult
            // 
            this.rbTeamsResult.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTeamsResult.FlatAppearance.BorderSize = 2;
            this.rbTeamsResult.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbTeamsResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbTeamsResult.Location = new System.Drawing.Point(244, 163);
            this.rbTeamsResult.Name = "rbTeamsResult";
            this.rbTeamsResult.Size = new System.Drawing.Size(215, 30);
            this.rbTeamsResult.TabIndex = 13;
            this.rbTeamsResult.Text = "10_Результат команды";
            this.rbTeamsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTeamsResult.UseVisualStyleBackColor = true;
            // 
            // rbPlayerHome
            // 
            this.rbPlayerHome.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbPlayerHome.FlatAppearance.BorderSize = 2;
            this.rbPlayerHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbPlayerHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPlayerHome.Location = new System.Drawing.Point(6, 127);
            this.rbPlayerHome.Name = "rbPlayerHome";
            this.rbPlayerHome.Size = new System.Drawing.Size(212, 30);
            this.rbPlayerHome.TabIndex = 11;
            this.rbPlayerHome.Text = "Игрок";
            this.rbPlayerHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPlayerHome.UseVisualStyleBackColor = true;
            // 
            // rbClearGraphics
            // 
            this.rbClearGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbClearGraphics.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbClearGraphics.Checked = true;
            this.rbClearGraphics.FlatAppearance.BorderSize = 2;
            this.rbClearGraphics.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbClearGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbClearGraphics.Location = new System.Drawing.Point(6, 355);
            this.rbClearGraphics.Name = "rbClearGraphics";
            this.rbClearGraphics.Size = new System.Drawing.Size(453, 40);
            this.rbClearGraphics.TabIndex = 10;
            this.rbClearGraphics.TabStop = true;
            this.rbClearGraphics.Text = "Убрать графику";
            this.rbClearGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbClearGraphics.UseVisualStyleBackColor = true;
            this.rbClearGraphics.CheckedChanged += new System.EventHandler(this.rbClearGraphics_CheckedChanged);
            // 
            // rbOfficials
            // 
            this.rbOfficials.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOfficials.FlatAppearance.BorderSize = 2;
            this.rbOfficials.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbOfficials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOfficials.Location = new System.Drawing.Point(6, 163);
            this.rbOfficials.Name = "rbOfficials";
            this.rbOfficials.Size = new System.Drawing.Size(212, 30);
            this.rbOfficials.TabIndex = 8;
            this.rbOfficials.Text = "Судьи";
            this.rbOfficials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbOfficials.UseVisualStyleBackColor = true;
            this.rbOfficials.CheckedChanged += new System.EventHandler(this.rbOfficials_CheckedChanged);
            // 
            // rbTeamGuest
            // 
            this.rbTeamGuest.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTeamGuest.FlatAppearance.BorderSize = 2;
            this.rbTeamGuest.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbTeamGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbTeamGuest.Location = new System.Drawing.Point(244, 55);
            this.rbTeamGuest.Name = "rbTeamGuest";
            this.rbTeamGuest.Size = new System.Drawing.Size(215, 30);
            this.rbTeamGuest.TabIndex = 6;
            this.rbTeamGuest.Text = "Команда";
            this.rbTeamGuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbTeamGuest.UseVisualStyleBackColor = true;
            // 
            // rbTeamHome
            // 
            this.rbTeamHome.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTeamHome.FlatAppearance.BorderSize = 2;
            this.rbTeamHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbTeamHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbTeamHome.Location = new System.Drawing.Point(6, 55);
            this.rbTeamHome.Name = "rbTeamHome";
            this.rbTeamHome.Size = new System.Drawing.Size(212, 30);
            this.rbTeamHome.TabIndex = 5;
            this.rbTeamHome.Text = "Команда";
            this.rbTeamHome.UseVisualStyleBackColor = true;
            this.rbTeamHome.CheckedChanged += new System.EventHandler(this.rbTeamHome_CheckedChanged);
            // 
            // rbCoachGuest
            // 
            this.rbCoachGuest.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCoachGuest.FlatAppearance.BorderSize = 2;
            this.rbCoachGuest.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbCoachGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCoachGuest.Location = new System.Drawing.Point(244, 91);
            this.rbCoachGuest.Name = "rbCoachGuest";
            this.rbCoachGuest.Size = new System.Drawing.Size(215, 30);
            this.rbCoachGuest.TabIndex = 4;
            this.rbCoachGuest.Text = "Тренер";
            this.rbCoachGuest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbCoachGuest.UseVisualStyleBackColor = true;
            // 
            // rbCoachHome
            // 
            this.rbCoachHome.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCoachHome.FlatAppearance.BorderSize = 2;
            this.rbCoachHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbCoachHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCoachHome.Location = new System.Drawing.Point(6, 91);
            this.rbCoachHome.Name = "rbCoachHome";
            this.rbCoachHome.Size = new System.Drawing.Size(212, 30);
            this.rbCoachHome.TabIndex = 3;
            this.rbCoachHome.Text = "Тренер";
            this.rbCoachHome.UseVisualStyleBackColor = true;
            // 
            // rbScoreBig
            // 
            this.rbScoreBig.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbScoreBig.FlatAppearance.BorderSize = 2;
            this.rbScoreBig.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbScoreBig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbScoreBig.Location = new System.Drawing.Point(6, 235);
            this.rbScoreBig.Name = "rbScoreBig";
            this.rbScoreBig.Size = new System.Drawing.Size(453, 30);
            this.rbScoreBig.TabIndex = 2;
            this.rbScoreBig.Text = "Большой счет";
            this.rbScoreBig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbScoreBig.UseVisualStyleBackColor = true;
            this.rbScoreBig.CheckedChanged += new System.EventHandler(this.rbScoreBig_CheckedChanged);
            // 
            // rbEventTitle
            // 
            this.rbEventTitle.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEventTitle.FlatAppearance.BorderSize = 2;
            this.rbEventTitle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.rbEventTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEventTitle.Location = new System.Drawing.Point(6, 19);
            this.rbEventTitle.Name = "rbEventTitle";
            this.rbEventTitle.Size = new System.Drawing.Size(364, 30);
            this.rbEventTitle.TabIndex = 0;
            this.rbEventTitle.Text = "Заявочная";
            this.rbEventTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEventTitle.UseVisualStyleBackColor = true;
            this.rbEventTitle.CheckedChanged += new System.EventHandler(this.rbEventTitle_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(6, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(465, 80);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Игроки";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 528);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команда";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dgvTeamHome);
            this.groupBox3.Location = new System.Drawing.Point(6, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 417);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Состав";
            // 
            // dgvTeamHome
            // 
            this.dgvTeamHome.AllowUserToAddRows = false;
            this.dgvTeamHome.AllowUserToDeleteRows = false;
            this.dgvTeamHome.AllowUserToResizeRows = false;
            this.dgvTeamHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamHome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcPlayerHomeIsVisble,
            this.dgcPlayerHomeName});
            this.dgvTeamHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamHome.Location = new System.Drawing.Point(3, 16);
            this.dgvTeamHome.MultiSelect = false;
            this.dgvTeamHome.Name = "dgvTeamHome";
            this.dgvTeamHome.ReadOnly = true;
            this.dgvTeamHome.RowHeadersVisible = false;
            this.dgvTeamHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamHome.ShowEditingIcon = false;
            this.dgvTeamHome.Size = new System.Drawing.Size(343, 398);
            this.dgvTeamHome.TabIndex = 0;
            // 
            // dgcPlayerHomeIsVisble
            // 
            this.dgcPlayerHomeIsVisble.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcPlayerHomeIsVisble.DataPropertyName = "IsVisible";
            this.dgcPlayerHomeIsVisble.HeaderText = "Видим";
            this.dgcPlayerHomeIsVisble.Name = "dgcPlayerHomeIsVisble";
            this.dgcPlayerHomeIsVisble.ReadOnly = true;
            // 
            // dgcPlayerHomeName
            // 
            this.dgcPlayerHomeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgcPlayerHomeName.DataPropertyName = "PlayerName";
            this.dgcPlayerHomeName.HeaderText = "Имя";
            this.dgcPlayerHomeName.Name = "dgcPlayerHomeName";
            this.dgcPlayerHomeName.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbTeamHomeLogo);
            this.groupBox2.Controls.Add(this.tbTeamHomeCoach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbTeamHome);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // pbTeamHomeLogo
            // 
            this.pbTeamHomeLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTeamHomeLogo.Location = new System.Drawing.Point(293, 19);
            this.pbTeamHomeLogo.Name = "pbTeamHomeLogo";
            this.pbTeamHomeLogo.Size = new System.Drawing.Size(47, 47);
            this.pbTeamHomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeamHomeLogo.TabIndex = 4;
            this.pbTeamHomeLogo.TabStop = false;
            // 
            // tbTeamHomeCoach
            // 
            this.tbTeamHomeCoach.Location = new System.Drawing.Point(67, 46);
            this.tbTeamHomeCoach.Name = "tbTeamHomeCoach";
            this.tbTeamHomeCoach.ReadOnly = true;
            this.tbTeamHomeCoach.Size = new System.Drawing.Size(220, 20);
            this.tbTeamHomeCoach.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тренер:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // cbTeamHome
            // 
            this.cbTeamHome.DisplayMember = "TeamName";
            this.cbTeamHome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeamHome.FormattingEnabled = true;
            this.cbTeamHome.Location = new System.Drawing.Point(67, 19);
            this.cbTeamHome.Name = "cbTeamHome";
            this.cbTeamHome.Size = new System.Drawing.Size(220, 21);
            this.cbTeamHome.TabIndex = 0;
            this.cbTeamHome.ValueMember = "ID";
            // 
            // ofdProject
            // 
            this.ofdProject.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.teamsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1298, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startXPressionToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // startXPressionToolStripMenuItem
            // 
            this.startXPressionToolStripMenuItem.Name = "startXPressionToolStripMenuItem";
            this.startXPressionToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.startXPressionToolStripMenuItem.Text = "Запустить XPression";
            this.startXPressionToolStripMenuItem.Click += new System.EventHandler(this.startXPressionToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.settingsToolStripMenuItem.Text = "Настройки";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.teamsToolStripMenuItem.Text = "Команды";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 850);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamGuest)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamGuestLogo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamHome)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamHomeLogo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgvTeamGuest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcPlayerGuestIsVisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerGuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerGuestAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerGuestNation;
        private System.Windows.Forms.DataGridViewImageColumn dgcPlayerGuestFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerGuestNationShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerGuestRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerGuestHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerGuestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerGuestID_TTTeam;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.PictureBox pbTeamGuestLogo;
        private System.Windows.Forms.TextBox tbTeamGuestCoach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTeamGuest;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnKillAll;
        private System.Windows.Forms.RadioButton rbPlayerGuest;
        private System.Windows.Forms.RadioButton rbTeamsResult;
        private System.Windows.Forms.RadioButton rbPlayerHome;
        private System.Windows.Forms.RadioButton rbClearGraphics;
        private System.Windows.Forms.RadioButton rbOfficials;
        private System.Windows.Forms.RadioButton rbTeamGuest;
        private System.Windows.Forms.RadioButton rbTeamHome;
        private System.Windows.Forms.RadioButton rbCoachGuest;
        private System.Windows.Forms.RadioButton rbCoachHome;
        private System.Windows.Forms.RadioButton rbScoreBig;
        private System.Windows.Forms.RadioButton rbEventTitle;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTeamHome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbTeamHomeLogo;
        private System.Windows.Forms.TextBox tbTeamHomeCoach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeamHome;
        private System.Windows.Forms.OpenFileDialog ofdProject;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startXPressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbSemiFinal;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcPlayerHomeIsVisble;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPlayerHomeName;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
    }
}

