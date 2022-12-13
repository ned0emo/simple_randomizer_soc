namespace TreasuresSoC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.loadDefaultButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.weaponGuideButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ammoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponTextBox = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.itemGuideButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.armorTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.afTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.otherTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.npcGuideButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.communityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.npcExecptTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soundTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.translateCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.disableFreedomAngryCheckBox = new System.Windows.Forms.CheckBox();
            this.recommendLabel4 = new System.Windows.Forms.Label();
            this.recommendLabel2 = new System.Windows.Forms.Label();
            this.recommendLabel3 = new System.Windows.Forms.Label();
            this.recommendLabel1 = new System.Windows.Forms.Label();
            this.giveKnifeCheckBox = new System.Windows.Forms.CheckBox();
            this.respawnCheckBox = new System.Windows.Forms.CheckBox();
            this.barAlarmCheckBox = new System.Windows.Forms.CheckBox();
            this.equipWeaponEverywhereCheckBox = new System.Windows.Forms.CheckBox();
            this.communityCheckBox = new System.Windows.Forms.CheckBox();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.treasureCheckBox = new System.Windows.Forms.CheckBox();
            this.afCheckBox = new System.Windows.Forms.CheckBox();
            this.weaponCheckBox = new System.Windows.Forms.CheckBox();
            this.armorCheckBox = new System.Windows.Forms.CheckBox();
            this.npcCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(988, 249);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 28);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить списки";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(988, 284);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(175, 28);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Загрузить списки";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(988, 15);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(175, 28);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // loadDefaultButton
            // 
            this.loadDefaultButton.Location = new System.Drawing.Point(988, 320);
            this.loadDefaultButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadDefaultButton.Name = "loadDefaultButton";
            this.loadDefaultButton.Size = new System.Drawing.Size(175, 28);
            this.loadDefaultButton.TabIndex = 3;
            this.loadDefaultButton.Text = "Списки по умолчанию";
            this.loadDefaultButton.UseVisualStyleBackColor = true;
            this.loadDefaultButton.Click += new System.EventHandler(this.loadDefaultButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage9);
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(964, 636);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.weaponGuideButton);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.ammoTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.weaponTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(956, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оружие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // weaponGuideButton
            // 
            this.weaponGuideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weaponGuideButton.Location = new System.Drawing.Point(914, 11);
            this.weaponGuideButton.Name = "weaponGuideButton";
            this.weaponGuideButton.Size = new System.Drawing.Size(30, 30);
            this.weaponGuideButton.TabIndex = 9;
            this.weaponGuideButton.Text = "?";
            this.weaponGuideButton.UseVisualStyleBackColor = true;
            this.weaponGuideButton.Click += new System.EventHandler(this.weaponGuideButton_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(937, 28);
            this.label10.TabIndex = 8;
            this.label10.Text = "Список патронов и количества их в одной пачке";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ammoTextBox
            // 
            this.ammoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ammoTextBox.Location = new System.Drawing.Point(8, 335);
            this.ammoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ammoTextBox.Multiline = true;
            this.ammoTextBox.Name = "ammoTextBox";
            this.ammoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ammoTextBox.Size = new System.Drawing.Size(936, 263);
            this.ammoTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список оружия и используемых в нем патронов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weaponTextBox
            // 
            this.weaponTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weaponTextBox.Location = new System.Drawing.Point(8, 44);
            this.weaponTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.weaponTextBox.Multiline = true;
            this.weaponTextBox.Name = "weaponTextBox";
            this.weaponTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.weaponTextBox.Size = new System.Drawing.Size(936, 255);
            this.weaponTextBox.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.itemGuideButton);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.armorTextBox);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.afTextBox);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.otherTextBox);
            this.tabPage6.Controls.Add(this.itemTextBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(956, 607);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Предметы";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // itemGuideButton
            // 
            this.itemGuideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemGuideButton.Location = new System.Drawing.Point(918, 6);
            this.itemGuideButton.Name = "itemGuideButton";
            this.itemGuideButton.Size = new System.Drawing.Size(30, 30);
            this.itemGuideButton.TabIndex = 16;
            this.itemGuideButton.Text = "?";
            this.itemGuideButton.UseVisualStyleBackColor = true;
            this.itemGuideButton.Click += new System.EventHandler(this.itemGuideButton_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(476, 289);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(472, 28);
            this.label12.TabIndex = 15;
            this.label12.Text = "Список брони";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // armorTextBox
            // 
            this.armorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.armorTextBox.Location = new System.Drawing.Point(476, 321);
            this.armorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.armorTextBox.Multiline = true;
            this.armorTextBox.Name = "armorTextBox";
            this.armorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.armorTextBox.Size = new System.Drawing.Size(472, 278);
            this.armorTextBox.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 289);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(455, 28);
            this.label11.TabIndex = 13;
            this.label11.Text = "Список артефактов";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // afTextBox
            // 
            this.afTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.afTextBox.Location = new System.Drawing.Point(8, 321);
            this.afTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.afTextBox.Multiline = true;
            this.afTextBox.Name = "afTextBox";
            this.afTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.afTextBox.Size = new System.Drawing.Size(455, 278);
            this.afTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(471, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(477, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "Список прочего";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(455, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Список расходников";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otherTextBox
            // 
            this.otherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otherTextBox.Location = new System.Drawing.Point(476, 41);
            this.otherTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.otherTextBox.Multiline = true;
            this.otherTextBox.Name = "otherTextBox";
            this.otherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.otherTextBox.Size = new System.Drawing.Size(472, 240);
            this.otherTextBox.TabIndex = 8;
            // 
            // itemTextBox
            // 
            this.itemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemTextBox.Location = new System.Drawing.Point(8, 41);
            this.itemTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemTextBox.Multiline = true;
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.itemTextBox.Size = new System.Drawing.Size(455, 240);
            this.itemTextBox.TabIndex = 7;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.npcGuideButton);
            this.tabPage9.Controls.Add(this.label5);
            this.tabPage9.Controls.Add(this.communityTextBox);
            this.tabPage9.Controls.Add(this.label4);
            this.tabPage9.Controls.Add(this.npcExecptTextBox);
            this.tabPage9.Controls.Add(this.label3);
            this.tabPage9.Controls.Add(this.label2);
            this.tabPage9.Controls.Add(this.soundTextBox);
            this.tabPage9.Controls.Add(this.modelTextBox);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage9.Size = new System.Drawing.Size(956, 607);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "НПС";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // npcGuideButton
            // 
            this.npcGuideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.npcGuideButton.Location = new System.Drawing.Point(914, 9);
            this.npcGuideButton.Name = "npcGuideButton";
            this.npcGuideButton.Size = new System.Drawing.Size(30, 30);
            this.npcGuideButton.TabIndex = 15;
            this.npcGuideButton.Text = "?";
            this.npcGuideButton.UseVisualStyleBackColor = true;
            this.npcGuideButton.Click += new System.EventHandler(this.npcGuideButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(689, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Группировки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // communityTextBox
            // 
            this.communityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.communityTextBox.Location = new System.Drawing.Point(691, 342);
            this.communityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.communityTextBox.Multiline = true;
            this.communityTextBox.Name = "communityTextBox";
            this.communityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.communityTextBox.Size = new System.Drawing.Size(253, 257);
            this.communityTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(691, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Исключения";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npcExecptTextBox
            // 
            this.npcExecptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.npcExecptTextBox.Location = new System.Drawing.Point(691, 43);
            this.npcExecptTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.npcExecptTextBox.Multiline = true;
            this.npcExecptTextBox.Name = "npcExecptTextBox";
            this.npcExecptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.npcExecptTextBox.Size = new System.Drawing.Size(253, 263);
            this.npcExecptTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(349, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Список озвучки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Список моделей";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soundTextBox
            // 
            this.soundTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soundTextBox.Location = new System.Drawing.Point(349, 42);
            this.soundTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.soundTextBox.Multiline = true;
            this.soundTextBox.Name = "soundTextBox";
            this.soundTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.soundTextBox.Size = new System.Drawing.Size(332, 557);
            this.soundTextBox.TabIndex = 8;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.Location = new System.Drawing.Point(8, 42);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.modelTextBox.Multiline = true;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.modelTextBox.Size = new System.Drawing.Size(332, 557);
            this.modelTextBox.TabIndex = 7;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.textBox1);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.translateCheckBox);
            this.tabPage8.Controls.Add(this.label6);
            this.tabPage8.Controls.Add(this.disableFreedomAngryCheckBox);
            this.tabPage8.Controls.Add(this.recommendLabel4);
            this.tabPage8.Controls.Add(this.recommendLabel2);
            this.tabPage8.Controls.Add(this.recommendLabel3);
            this.tabPage8.Controls.Add(this.recommendLabel1);
            this.tabPage8.Controls.Add(this.giveKnifeCheckBox);
            this.tabPage8.Controls.Add(this.respawnCheckBox);
            this.tabPage8.Controls.Add(this.barAlarmCheckBox);
            this.tabPage8.Controls.Add(this.equipWeaponEverywhereCheckBox);
            this.tabPage8.Controls.Add(this.communityCheckBox);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage8.Size = new System.Drawing.Size(956, 607);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "Дополнительно";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 578);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(417, 22);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "https://github.com/ned0emo/simple_randomizer_soc";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(375, 582);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "©ned0emo, ver 1.2";
            // 
            // translateCheckBox
            // 
            this.translateCheckBox.AutoSize = true;
            this.translateCheckBox.Location = new System.Drawing.Point(12, 333);
            this.translateCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.translateCheckBox.Name = "translateCheckBox";
            this.translateCheckBox.Size = new System.Drawing.Size(249, 21);
            this.translateCheckBox.TabIndex = 12;
            this.translateCheckBox.Text = "Охлаждающий трахание перевод";
            this.translateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(937, 318);
            this.label6.TabIndex = 11;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // disableFreedomAngryCheckBox
            // 
            this.disableFreedomAngryCheckBox.AutoSize = true;
            this.disableFreedomAngryCheckBox.Location = new System.Drawing.Point(12, 493);
            this.disableFreedomAngryCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.disableFreedomAngryCheckBox.Name = "disableFreedomAngryCheckBox";
            this.disableFreedomAngryCheckBox.Size = new System.Drawing.Size(587, 21);
            this.disableFreedomAngryCheckBox.TabIndex = 10;
            this.disableFreedomAngryCheckBox.Text = "Отключить враждебность базы Свободы при наличии на ней НПС, враждебных к ГГ";
            this.disableFreedomAngryCheckBox.UseVisualStyleBackColor = true;
            // 
            // recommendLabel4
            // 
            this.recommendLabel4.AutoSize = true;
            this.recommendLabel4.Location = new System.Drawing.Point(625, 470);
            this.recommendLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recommendLabel4.Name = "recommendLabel4";
            this.recommendLabel4.Size = new System.Drawing.Size(120, 17);
            this.recommendLabel4.TabIndex = 9;
            this.recommendLabel4.Text = "(Рекомендуется)";
            this.recommendLabel4.Visible = false;
            // 
            // recommendLabel2
            // 
            this.recommendLabel2.AutoSize = true;
            this.recommendLabel2.Location = new System.Drawing.Point(625, 412);
            this.recommendLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recommendLabel2.Name = "recommendLabel2";
            this.recommendLabel2.Size = new System.Drawing.Size(120, 17);
            this.recommendLabel2.TabIndex = 8;
            this.recommendLabel2.Text = "(Рекомендуется)";
            this.recommendLabel2.Visible = false;
            // 
            // recommendLabel3
            // 
            this.recommendLabel3.AutoSize = true;
            this.recommendLabel3.Location = new System.Drawing.Point(625, 441);
            this.recommendLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recommendLabel3.Name = "recommendLabel3";
            this.recommendLabel3.Size = new System.Drawing.Size(120, 17);
            this.recommendLabel3.TabIndex = 7;
            this.recommendLabel3.Text = "(Рекомендуется)";
            this.recommendLabel3.Visible = false;
            // 
            // recommendLabel1
            // 
            this.recommendLabel1.AutoSize = true;
            this.recommendLabel1.Location = new System.Drawing.Point(625, 494);
            this.recommendLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recommendLabel1.Name = "recommendLabel1";
            this.recommendLabel1.Size = new System.Drawing.Size(120, 17);
            this.recommendLabel1.TabIndex = 6;
            this.recommendLabel1.Text = "(Рекомендуется)";
            this.recommendLabel1.Visible = false;
            // 
            // giveKnifeCheckBox
            // 
            this.giveKnifeCheckBox.AutoSize = true;
            this.giveKnifeCheckBox.Location = new System.Drawing.Point(12, 465);
            this.giveKnifeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.giveKnifeCheckBox.Name = "giveKnifeCheckBox";
            this.giveKnifeCheckBox.Size = new System.Drawing.Size(210, 21);
            this.giveKnifeCheckBox.TabIndex = 5;
            this.giveKnifeCheckBox.Text = "Дать ГГ нож в начале игры";
            this.giveKnifeCheckBox.UseVisualStyleBackColor = true;
            // 
            // respawnCheckBox
            // 
            this.respawnCheckBox.AutoSize = true;
            this.respawnCheckBox.Location = new System.Drawing.Point(12, 268);
            this.respawnCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.respawnCheckBox.Name = "respawnCheckBox";
            this.respawnCheckBox.Size = new System.Drawing.Size(255, 21);
            this.respawnCheckBox.TabIndex = 4;
            this.respawnCheckBox.Text = "Увеличить частоту респавна НПС";
            this.respawnCheckBox.UseVisualStyleBackColor = true;
            // 
            // barAlarmCheckBox
            // 
            this.barAlarmCheckBox.AutoSize = true;
            this.barAlarmCheckBox.Location = new System.Drawing.Point(12, 436);
            this.barAlarmCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.barAlarmCheckBox.Name = "barAlarmCheckBox";
            this.barAlarmCheckBox.Size = new System.Drawing.Size(398, 21);
            this.barAlarmCheckBox.TabIndex = 3;
            this.barAlarmCheckBox.Text = "Отключить тревогу в Баре, когда игрок кого-то убивает";
            this.barAlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // equipWeaponEverywhereCheckBox
            // 
            this.equipWeaponEverywhereCheckBox.AutoSize = true;
            this.equipWeaponEverywhereCheckBox.Location = new System.Drawing.Point(12, 407);
            this.equipWeaponEverywhereCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.equipWeaponEverywhereCheckBox.Name = "equipWeaponEverywhereCheckBox";
            this.equipWeaponEverywhereCheckBox.Size = new System.Drawing.Size(505, 21);
            this.equipWeaponEverywhereCheckBox.TabIndex = 2;
            this.equipWeaponEverywhereCheckBox.Text = "Возможномть достать оружие в баре, в бункере ученых и у Сидоровича";
            this.equipWeaponEverywhereCheckBox.UseVisualStyleBackColor = true;
            // 
            // communityCheckBox
            // 
            this.communityCheckBox.AutoSize = true;
            this.communityCheckBox.Location = new System.Drawing.Point(12, 370);
            this.communityCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.communityCheckBox.Name = "communityCheckBox";
            this.communityCheckBox.Size = new System.Drawing.Size(212, 21);
            this.communityCheckBox.TabIndex = 0;
            this.communityCheckBox.Text = "Изменять группировку НПС";
            this.communityCheckBox.UseVisualStyleBackColor = true;
            this.communityCheckBox.CheckedChanged += new System.EventHandler(this.communityCheckBox_CheckedChanged);
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(989, 52);
            this.allCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(54, 21);
            this.allCheckBox.TabIndex = 7;
            this.allCheckBox.Text = "Все";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // treasureCheckBox
            // 
            this.treasureCheckBox.AutoSize = true;
            this.treasureCheckBox.Location = new System.Drawing.Point(989, 81);
            this.treasureCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.treasureCheckBox.Name = "treasureCheckBox";
            this.treasureCheckBox.Size = new System.Drawing.Size(86, 21);
            this.treasureCheckBox.TabIndex = 8;
            this.treasureCheckBox.Text = "Тайники";
            this.treasureCheckBox.UseVisualStyleBackColor = true;
            // 
            // afCheckBox
            // 
            this.afCheckBox.AutoSize = true;
            this.afCheckBox.Location = new System.Drawing.Point(989, 111);
            this.afCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.afCheckBox.Name = "afCheckBox";
            this.afCheckBox.Size = new System.Drawing.Size(105, 21);
            this.afCheckBox.TabIndex = 9;
            this.afCheckBox.Text = "Артефакты";
            this.afCheckBox.UseVisualStyleBackColor = true;
            // 
            // weaponCheckBox
            // 
            this.weaponCheckBox.AutoSize = true;
            this.weaponCheckBox.Location = new System.Drawing.Point(989, 140);
            this.weaponCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.weaponCheckBox.Name = "weaponCheckBox";
            this.weaponCheckBox.Size = new System.Drawing.Size(81, 21);
            this.weaponCheckBox.TabIndex = 10;
            this.weaponCheckBox.Text = "Оружие";
            this.weaponCheckBox.UseVisualStyleBackColor = true;
            // 
            // armorCheckBox
            // 
            this.armorCheckBox.AutoSize = true;
            this.armorCheckBox.Location = new System.Drawing.Point(989, 170);
            this.armorCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.armorCheckBox.Name = "armorCheckBox";
            this.armorCheckBox.Size = new System.Drawing.Size(71, 21);
            this.armorCheckBox.TabIndex = 11;
            this.armorCheckBox.Text = "Броня";
            this.armorCheckBox.UseVisualStyleBackColor = true;
            // 
            // npcCheckBox
            // 
            this.npcCheckBox.AutoSize = true;
            this.npcCheckBox.Location = new System.Drawing.Point(989, 199);
            this.npcCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.npcCheckBox.Name = "npcCheckBox";
            this.npcCheckBox.Size = new System.Drawing.Size(59, 21);
            this.npcCheckBox.TabIndex = 12;
            this.npcCheckBox.Text = "НПС";
            this.npcCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 664);
            this.Controls.Add(this.npcCheckBox);
            this.Controls.Add(this.armorCheckBox);
            this.Controls.Add(this.weaponCheckBox);
            this.Controls.Add(this.afCheckBox);
            this.Controls.Add(this.treasureCheckBox);
            this.Controls.Add(this.allCheckBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.loadDefaultButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Рандомайзер Тень Чернобыля";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button loadDefaultButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox weaponTextBox;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.CheckBox allCheckBox;
        private System.Windows.Forms.CheckBox treasureCheckBox;
        private System.Windows.Forms.CheckBox afCheckBox;
        private System.Windows.Forms.CheckBox weaponCheckBox;
        private System.Windows.Forms.CheckBox armorCheckBox;
        private System.Windows.Forms.CheckBox npcCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox npcExecptTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soundTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox communityTextBox;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.CheckBox giveKnifeCheckBox;
        private System.Windows.Forms.CheckBox respawnCheckBox;
        private System.Windows.Forms.CheckBox barAlarmCheckBox;
        private System.Windows.Forms.CheckBox equipWeaponEverywhereCheckBox;
        private System.Windows.Forms.CheckBox communityCheckBox;
        private System.Windows.Forms.CheckBox disableFreedomAngryCheckBox;
        private System.Windows.Forms.Label recommendLabel4;
        private System.Windows.Forms.Label recommendLabel2;
        private System.Windows.Forms.Label recommendLabel3;
        private System.Windows.Forms.Label recommendLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox translateCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ammoTextBox;
        private System.Windows.Forms.TextBox otherTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox afTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox armorTextBox;
        private System.Windows.Forms.Button weaponGuideButton;
        private System.Windows.Forms.Button itemGuideButton;
        private System.Windows.Forms.Button npcGuideButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

