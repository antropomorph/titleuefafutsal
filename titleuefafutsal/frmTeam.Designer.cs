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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeam));
            this.cdTeam = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.miDeleteTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.miAddTeam = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ofdLogo = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLogo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTeamNameShort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTeamCoachTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTeamNationShort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTeamNation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbTeamCoach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_TTTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTeamList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sbAddPlayer = new System.Windows.Forms.ToolStripButton();
            this.sbEditPlayer = new System.Windows.Forms.ToolStripButton();
            this.sbDeletePlayer = new System.Windows.Forms.ToolStripButton();
            this.dgvTeamList = new System.Windows.Forms.DataGridView();
            this.isVisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.playerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNationShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerRanking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(517, 631);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 631);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // miDeleteTeam
            // 
            this.miDeleteTeam.Name = "miDeleteTeam";
            this.miDeleteTeam.Size = new System.Drawing.Size(180, 22);
            this.miDeleteTeam.Text = "Удалить команду";
            // 
            // miAddTeam
            // 
            this.miAddTeam.Name = "miAddTeam";
            this.miAddTeam.Size = new System.Drawing.Size(180, 22);
            this.miAddTeam.Text = "Добавить команду";
            this.miAddTeam.Click += new System.EventHandler(this.miAddTeam_Click);
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddTeam,
            this.miDeleteTeam});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ofdLogo
            // 
            this.ofdLogo.Filter = "PNG|*.png";
            this.ofdLogo.RestoreDirectory = true;
            this.ofdLogo.Title = "Выбор логотипа";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(419, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 22);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Цвет:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tbLogo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbTeamNameShort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbTeamCoachTitle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbTeamNationShort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbTeamNation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbTeamName);
            this.groupBox2.Controls.Add(this.pbLogo);
            this.groupBox2.Controls.Add(this.tbTeamCoach);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 159);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tbLogo
            // 
            this.tbLogo.Location = new System.Drawing.Point(100, 123);
            this.tbLogo.Name = "tbLogo";
            this.tbLogo.Size = new System.Drawing.Size(280, 20);
            this.tbLogo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Логотип:";
            // 
            // tbTeamNameShort
            // 
            this.tbTeamNameShort.Location = new System.Drawing.Point(308, 19);
            this.tbTeamNameShort.Name = "tbTeamNameShort";
            this.tbTeamNameShort.Size = new System.Drawing.Size(72, 20);
            this.tbTeamNameShort.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "короткое:";
            // 
            // tbTeamCoachTitle
            // 
            this.tbTeamCoachTitle.Location = new System.Drawing.Point(100, 97);
            this.tbTeamCoachTitle.Name = "tbTeamCoachTitle";
            this.tbTeamCoachTitle.Size = new System.Drawing.Size(280, 20);
            this.tbTeamCoachTitle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Должность:";
            // 
            // tbTeamNationShort
            // 
            this.tbTeamNationShort.Location = new System.Drawing.Point(308, 45);
            this.tbTeamNationShort.Name = "tbTeamNationShort";
            this.tbTeamNationShort.Size = new System.Drawing.Size(72, 20);
            this.tbTeamNationShort.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "короткое:";
            // 
            // tbTeamNation
            // 
            this.tbTeamNation.Location = new System.Drawing.Point(100, 45);
            this.tbTeamNation.Name = "tbTeamNation";
            this.tbTeamNation.Size = new System.Drawing.Size(139, 20);
            this.tbTeamNation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Страна:";
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(100, 19);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(139, 20);
            this.tbTeamName.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLogo.Location = new System.Drawing.Point(386, 19);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(98, 98);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // tbTeamCoach
            // 
            this.tbTeamCoach.Location = new System.Drawing.Point(100, 71);
            this.tbTeamCoach.Name = "tbTeamCoach";
            this.tbTeamCoach.Size = new System.Drawing.Size(280, 20);
            this.tbTeamCoach.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
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
            // ID_TTTeam
            // 
            this.ID_TTTeam.DataPropertyName = "ID_TTTeam";
            this.ID_TTTeam.HeaderText = "ID_TTTeam";
            this.ID_TTTeam.Name = "ID_TTTeam";
            this.ID_TTTeam.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // playerFlag
            // 
            this.playerFlag.DataPropertyName = "PlayerFlag";
            this.playerFlag.HeaderText = "Флаг";
            this.playerFlag.Name = "playerFlag";
            this.playerFlag.ReadOnly = true;
            this.playerFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbTeamList);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 577);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команда";
            // 
            // cbTeamList
            // 
            this.cbTeamList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTeamList.FormattingEnabled = true;
            this.cbTeamList.Location = new System.Drawing.Point(106, 0);
            this.cbTeamList.Name = "cbTeamList";
            this.cbTeamList.Size = new System.Drawing.Size(269, 21);
            this.cbTeamList.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.toolStrip1);
            this.groupBox3.Controls.Add(this.dgvTeamList);
            this.groupBox3.Location = new System.Drawing.Point(6, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 395);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Состав";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbAddPlayer,
            this.sbEditPlayer,
            this.sbDeletePlayer});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(727, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sbAddPlayer
            // 
            this.sbAddPlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbAddPlayer.Image = ((System.Drawing.Image)(resources.GetObject("sbAddPlayer.Image")));
            this.sbAddPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbAddPlayer.Name = "sbAddPlayer";
            this.sbAddPlayer.Size = new System.Drawing.Size(23, 22);
            this.sbAddPlayer.Text = "toolStripButton1";
            // 
            // sbEditPlayer
            // 
            this.sbEditPlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbEditPlayer.Image = ((System.Drawing.Image)(resources.GetObject("sbEditPlayer.Image")));
            this.sbEditPlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbEditPlayer.Name = "sbEditPlayer";
            this.sbEditPlayer.Size = new System.Drawing.Size(23, 22);
            this.sbEditPlayer.Text = "toolStripButton2";
            // 
            // sbDeletePlayer
            // 
            this.sbDeletePlayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sbDeletePlayer.Image = ((System.Drawing.Image)(resources.GetObject("sbDeletePlayer.Image")));
            this.sbDeletePlayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbDeletePlayer.Name = "sbDeletePlayer";
            this.sbDeletePlayer.Size = new System.Drawing.Size(23, 22);
            this.sbDeletePlayer.Text = "toolStripButton3";
            // 
            // dgvTeamList
            // 
            this.dgvTeamList.AllowUserToAddRows = false;
            this.dgvTeamList.AllowUserToDeleteRows = false;
            this.dgvTeamList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isVisible,
            this.playerName,
            this.playerAge,
            this.playerNation,
            this.playerNationShort,
            this.playerRanking,
            this.playerHand,
            this.playerFlag,
            this.ID,
            this.ID_TTTeam});
            this.dgvTeamList.Location = new System.Drawing.Point(6, 44);
            this.dgvTeamList.MultiSelect = false;
            this.dgvTeamList.Name = "dgvTeamList";
            this.dgvTeamList.ReadOnly = true;
            this.dgvTeamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamList.Size = new System.Drawing.Size(724, 345);
            this.dgvTeamList.TabIndex = 0;
            // 
            // isVisible
            // 
            this.isVisible.DataPropertyName = "IsVisible";
            this.isVisible.HeaderText = "Участвует";
            this.isVisible.Name = "isVisible";
            this.isVisible.ReadOnly = true;
            // 
            // playerName
            // 
            this.playerName.DataPropertyName = "PlayerName";
            this.playerName.HeaderText = "Имя игрока";
            this.playerName.Name = "playerName";
            this.playerName.ReadOnly = true;
            // 
            // playerAge
            // 
            this.playerAge.DataPropertyName = "PlayerAge";
            this.playerAge.HeaderText = "Возраст";
            this.playerAge.Name = "playerAge";
            this.playerAge.ReadOnly = true;
            // 
            // playerNation
            // 
            this.playerNation.DataPropertyName = "PlayerNation";
            this.playerNation.HeaderText = "Национальность";
            this.playerNation.Name = "playerNation";
            this.playerNation.ReadOnly = true;
            // 
            // playerNationShort
            // 
            this.playerNationShort.DataPropertyName = "PlayerNationShort";
            this.playerNationShort.HeaderText = "Национальность сокр.";
            this.playerNationShort.Name = "playerNationShort";
            this.playerNationShort.ReadOnly = true;
            // 
            // playerRanking
            // 
            this.playerRanking.DataPropertyName = "PlayerRanking";
            this.playerRanking.HeaderText = "Ранг";
            this.playerRanking.Name = "playerRanking";
            this.playerRanking.ReadOnly = true;
            // 
            // playerHand
            // 
            this.playerHand.DataPropertyName = "PlayerHand";
            this.playerHand.HeaderText = "Лево/праворукий";
            this.playerHand.Name = "playerHand";
            this.playerHand.ReadOnly = true;
            // 
            // frmTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTeam";
            this.Text = "frmTeam";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog cdTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem miDeleteTeam;
        private System.Windows.Forms.ToolStripMenuItem miAddTeam;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog ofdLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLogo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTeamNameShort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTeamCoachTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTeamNationShort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTeamNation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbTeamCoach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TTTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerFlag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTeamList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton sbAddPlayer;
        private System.Windows.Forms.ToolStripButton sbEditPlayer;
        private System.Windows.Forms.ToolStripButton sbDeletePlayer;
        private System.Windows.Forms.DataGridView dgvTeamList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isVisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNation;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNationShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerHand;
    }
}