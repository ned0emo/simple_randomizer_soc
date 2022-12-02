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
            this.label1 = new System.Windows.Forms.Label();
            this.weaponTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.armorTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.afTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.addonTextBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.ammoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.monsterTextBox = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.communityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.npcExecptTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soundTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
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
            this.scanButton = new System.Windows.Forms.Button();
            this.rusRadioButton = new System.Windows.Forms.RadioButton();
            this.engRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(741, 202);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Сохранить списки";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(741, 231);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(131, 23);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Загрузить списки";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(741, 12);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(131, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // loadDefaultButton
            // 
            this.loadDefaultButton.Location = new System.Drawing.Point(741, 260);
            this.loadDefaultButton.Name = "loadDefaultButton";
            this.loadDefaultButton.Size = new System.Drawing.Size(131, 23);
            this.loadDefaultButton.TabIndex = 3;
            this.loadDefaultButton.Text = "Списки по умолчанию";
            this.loadDefaultButton.UseVisualStyleBackColor = true;
            this.loadDefaultButton.Click += new System.EventHandler(this.loadDefaultButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Controls.Add(this.tabPage9);
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(723, 320);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.weaponTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оружие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список оружия и используемых в нем патронов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weaponTextBox
            // 
            this.weaponTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weaponTextBox.Location = new System.Drawing.Point(6, 36);
            this.weaponTextBox.Multiline = true;
            this.weaponTextBox.Name = "weaponTextBox";
            this.weaponTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.weaponTextBox.Size = new System.Drawing.Size(703, 252);
            this.weaponTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.armorTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(715, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Броня";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // armorTextBox
            // 
            this.armorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.armorTextBox.Location = new System.Drawing.Point(6, 7);
            this.armorTextBox.Multiline = true;
            this.armorTextBox.Name = "armorTextBox";
            this.armorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.armorTextBox.Size = new System.Drawing.Size(703, 280);
            this.armorTextBox.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.afTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(715, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Артефакты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // afTextBox
            // 
            this.afTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.afTextBox.Location = new System.Drawing.Point(6, 6);
            this.afTextBox.Multiline = true;
            this.afTextBox.Name = "afTextBox";
            this.afTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.afTextBox.Size = new System.Drawing.Size(703, 281);
            this.afTextBox.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.addonTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(715, 294);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Обвесы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // addonTextBox
            // 
            this.addonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addonTextBox.Location = new System.Drawing.Point(6, 7);
            this.addonTextBox.Multiline = true;
            this.addonTextBox.Name = "addonTextBox";
            this.addonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.addonTextBox.Size = new System.Drawing.Size(703, 280);
            this.addonTextBox.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.ammoTextBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(715, 294);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Патроны";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(703, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Список патронов и количества их в одной пачке";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ammoTextBox
            // 
            this.ammoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ammoTextBox.Location = new System.Drawing.Point(6, 35);
            this.ammoTextBox.Multiline = true;
            this.ammoTextBox.Name = "ammoTextBox";
            this.ammoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ammoTextBox.Size = new System.Drawing.Size(703, 252);
            this.ammoTextBox.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.itemTextBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(715, 294);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Расходники";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // itemTextBox
            // 
            this.itemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemTextBox.Location = new System.Drawing.Point(6, 6);
            this.itemTextBox.Multiline = true;
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.itemTextBox.Size = new System.Drawing.Size(703, 281);
            this.itemTextBox.TabIndex = 7;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.monsterTextBox);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(715, 294);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Части монстров";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // monsterTextBox
            // 
            this.monsterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monsterTextBox.Location = new System.Drawing.Point(6, 7);
            this.monsterTextBox.Multiline = true;
            this.monsterTextBox.Name = "monsterTextBox";
            this.monsterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.monsterTextBox.Size = new System.Drawing.Size(703, 280);
            this.monsterTextBox.TabIndex = 7;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label5);
            this.tabPage9.Controls.Add(this.communityTextBox);
            this.tabPage9.Controls.Add(this.label4);
            this.tabPage9.Controls.Add(this.npcExecptTextBox);
            this.tabPage9.Controls.Add(this.label3);
            this.tabPage9.Controls.Add(this.label2);
            this.tabPage9.Controls.Add(this.soundTextBox);
            this.tabPage9.Controls.Add(this.modelTextBox);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(715, 294);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "НПС";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(518, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Группировки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // communityTextBox
            // 
            this.communityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.communityTextBox.Location = new System.Drawing.Point(518, 178);
            this.communityTextBox.Multiline = true;
            this.communityTextBox.Name = "communityTextBox";
            this.communityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.communityTextBox.Size = new System.Drawing.Size(191, 110);
            this.communityTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(518, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Исключения";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npcExecptTextBox
            // 
            this.npcExecptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.npcExecptTextBox.Location = new System.Drawing.Point(518, 35);
            this.npcExecptTextBox.Multiline = true;
            this.npcExecptTextBox.Name = "npcExecptTextBox";
            this.npcExecptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.npcExecptTextBox.Size = new System.Drawing.Size(191, 110);
            this.npcExecptTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(262, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Список озвучки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Список моделей";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // soundTextBox
            // 
            this.soundTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.soundTextBox.Location = new System.Drawing.Point(262, 34);
            this.soundTextBox.Multiline = true;
            this.soundTextBox.Name = "soundTextBox";
            this.soundTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.soundTextBox.Size = new System.Drawing.Size(250, 253);
            this.soundTextBox.TabIndex = 8;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.Location = new System.Drawing.Point(6, 34);
            this.modelTextBox.Multiline = true;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.modelTextBox.Size = new System.Drawing.Size(250, 253);
            this.modelTextBox.TabIndex = 7;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Controls.Add(this.scanButton);
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
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(715, 294);
            this.tabPage8.TabIndex = 9;
            this.tabPage8.Text = "Дополнительно";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // translateCheckBox
            // 
            this.translateCheckBox.AutoSize = true;
            this.translateCheckBox.Location = new System.Drawing.Point(9, 134);
            this.translateCheckBox.Name = "translateCheckBox";
            this.translateCheckBox.Size = new System.Drawing.Size(194, 17);
            this.translateCheckBox.TabIndex = 12;
            this.translateCheckBox.Text = "Охлаждающий трахание перевод";
            this.translateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(703, 88);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // disableFreedomAngryCheckBox
            // 
            this.disableFreedomAngryCheckBox.AutoSize = true;
            this.disableFreedomAngryCheckBox.Location = new System.Drawing.Point(9, 264);
            this.disableFreedomAngryCheckBox.Name = "disableFreedomAngryCheckBox";
            this.disableFreedomAngryCheckBox.Size = new System.Drawing.Size(454, 17);
            this.disableFreedomAngryCheckBox.TabIndex = 10;
            this.disableFreedomAngryCheckBox.Text = "Отключить враждебность базы Свободы при наличии на ней НПС, враждебных к ГГ";
            this.disableFreedomAngryCheckBox.UseVisualStyleBackColor = true;
            // 
            // recommendLabel4
            // 
            this.recommendLabel4.AutoSize = true;
            this.recommendLabel4.Location = new System.Drawing.Point(469, 245);
            this.recommendLabel4.Name = "recommendLabel4";
            this.recommendLabel4.Size = new System.Drawing.Size(92, 13);
            this.recommendLabel4.TabIndex = 9;
            this.recommendLabel4.Text = "(Рекомендуется)";
            this.recommendLabel4.Visible = false;
            // 
            // recommendLabel2
            // 
            this.recommendLabel2.AutoSize = true;
            this.recommendLabel2.Location = new System.Drawing.Point(469, 198);
            this.recommendLabel2.Name = "recommendLabel2";
            this.recommendLabel2.Size = new System.Drawing.Size(92, 13);
            this.recommendLabel2.TabIndex = 8;
            this.recommendLabel2.Text = "(Рекомендуется)";
            this.recommendLabel2.Visible = false;
            // 
            // recommendLabel3
            // 
            this.recommendLabel3.AutoSize = true;
            this.recommendLabel3.Location = new System.Drawing.Point(469, 222);
            this.recommendLabel3.Name = "recommendLabel3";
            this.recommendLabel3.Size = new System.Drawing.Size(92, 13);
            this.recommendLabel3.TabIndex = 7;
            this.recommendLabel3.Text = "(Рекомендуется)";
            this.recommendLabel3.Visible = false;
            // 
            // recommendLabel1
            // 
            this.recommendLabel1.AutoSize = true;
            this.recommendLabel1.Location = new System.Drawing.Point(469, 265);
            this.recommendLabel1.Name = "recommendLabel1";
            this.recommendLabel1.Size = new System.Drawing.Size(92, 13);
            this.recommendLabel1.TabIndex = 6;
            this.recommendLabel1.Text = "(Рекомендуется)";
            this.recommendLabel1.Visible = false;
            // 
            // giveKnifeCheckBox
            // 
            this.giveKnifeCheckBox.AutoSize = true;
            this.giveKnifeCheckBox.Location = new System.Drawing.Point(9, 241);
            this.giveKnifeCheckBox.Name = "giveKnifeCheckBox";
            this.giveKnifeCheckBox.Size = new System.Drawing.Size(165, 17);
            this.giveKnifeCheckBox.TabIndex = 5;
            this.giveKnifeCheckBox.Text = "Дать ГГ нож в начале игры";
            this.giveKnifeCheckBox.UseVisualStyleBackColor = true;
            // 
            // respawnCheckBox
            // 
            this.respawnCheckBox.AutoSize = true;
            this.respawnCheckBox.Location = new System.Drawing.Point(9, 104);
            this.respawnCheckBox.Name = "respawnCheckBox";
            this.respawnCheckBox.Size = new System.Drawing.Size(198, 17);
            this.respawnCheckBox.TabIndex = 4;
            this.respawnCheckBox.Text = "Увеличить частоту респавна НПС";
            this.respawnCheckBox.UseVisualStyleBackColor = true;
            // 
            // barAlarmCheckBox
            // 
            this.barAlarmCheckBox.AutoSize = true;
            this.barAlarmCheckBox.Location = new System.Drawing.Point(9, 218);
            this.barAlarmCheckBox.Name = "barAlarmCheckBox";
            this.barAlarmCheckBox.Size = new System.Drawing.Size(310, 17);
            this.barAlarmCheckBox.TabIndex = 3;
            this.barAlarmCheckBox.Text = "Отключить тревогу в Баре, когда игрок кого-то убивает";
            this.barAlarmCheckBox.UseVisualStyleBackColor = true;
            // 
            // equipWeaponEverywhereCheckBox
            // 
            this.equipWeaponEverywhereCheckBox.AutoSize = true;
            this.equipWeaponEverywhereCheckBox.Location = new System.Drawing.Point(9, 194);
            this.equipWeaponEverywhereCheckBox.Name = "equipWeaponEverywhereCheckBox";
            this.equipWeaponEverywhereCheckBox.Size = new System.Drawing.Size(391, 17);
            this.equipWeaponEverywhereCheckBox.TabIndex = 2;
            this.equipWeaponEverywhereCheckBox.Text = "Возможномть достать оружие в баре, в бункере ученых и у Сидоровича";
            this.equipWeaponEverywhereCheckBox.UseVisualStyleBackColor = true;
            // 
            // communityCheckBox
            // 
            this.communityCheckBox.AutoSize = true;
            this.communityCheckBox.Location = new System.Drawing.Point(9, 164);
            this.communityCheckBox.Name = "communityCheckBox";
            this.communityCheckBox.Size = new System.Drawing.Size(169, 17);
            this.communityCheckBox.TabIndex = 0;
            this.communityCheckBox.Text = "Изменять группировку НПС";
            this.communityCheckBox.UseVisualStyleBackColor = true;
            this.communityCheckBox.CheckedChanged += new System.EventHandler(this.communityCheckBox_CheckedChanged);
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(742, 42);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(45, 17);
            this.allCheckBox.TabIndex = 7;
            this.allCheckBox.Text = "Все";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // treasureCheckBox
            // 
            this.treasureCheckBox.AutoSize = true;
            this.treasureCheckBox.Location = new System.Drawing.Point(742, 66);
            this.treasureCheckBox.Name = "treasureCheckBox";
            this.treasureCheckBox.Size = new System.Drawing.Size(69, 17);
            this.treasureCheckBox.TabIndex = 8;
            this.treasureCheckBox.Text = "Тайники";
            this.treasureCheckBox.UseVisualStyleBackColor = true;
            // 
            // afCheckBox
            // 
            this.afCheckBox.AutoSize = true;
            this.afCheckBox.Location = new System.Drawing.Point(742, 90);
            this.afCheckBox.Name = "afCheckBox";
            this.afCheckBox.Size = new System.Drawing.Size(83, 17);
            this.afCheckBox.TabIndex = 9;
            this.afCheckBox.Text = "Артефакты";
            this.afCheckBox.UseVisualStyleBackColor = true;
            // 
            // weaponCheckBox
            // 
            this.weaponCheckBox.AutoSize = true;
            this.weaponCheckBox.Location = new System.Drawing.Point(742, 114);
            this.weaponCheckBox.Name = "weaponCheckBox";
            this.weaponCheckBox.Size = new System.Drawing.Size(65, 17);
            this.weaponCheckBox.TabIndex = 10;
            this.weaponCheckBox.Text = "Оружие";
            this.weaponCheckBox.UseVisualStyleBackColor = true;
            // 
            // armorCheckBox
            // 
            this.armorCheckBox.AutoSize = true;
            this.armorCheckBox.Location = new System.Drawing.Point(742, 138);
            this.armorCheckBox.Name = "armorCheckBox";
            this.armorCheckBox.Size = new System.Drawing.Size(57, 17);
            this.armorCheckBox.TabIndex = 11;
            this.armorCheckBox.Text = "Броня";
            this.armorCheckBox.UseVisualStyleBackColor = true;
            // 
            // npcCheckBox
            // 
            this.npcCheckBox.AutoSize = true;
            this.npcCheckBox.Location = new System.Drawing.Point(742, 162);
            this.npcCheckBox.Name = "npcCheckBox";
            this.npcCheckBox.Size = new System.Drawing.Size(49, 17);
            this.npcCheckBox.TabIndex = 12;
            this.npcCheckBox.Text = "НПС";
            this.npcCheckBox.UseVisualStyleBackColor = true;
            // 
            // scanButton
            // 
            this.scanButton.Enabled = false;
            this.scanButton.Location = new System.Drawing.Point(565, 104);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(131, 23);
            this.scanButton.TabIndex = 12;
            this.scanButton.Text = "Сканировать";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Visible = false;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // rusRadioButton
            // 
            this.rusRadioButton.AutoSize = true;
            this.rusRadioButton.Checked = true;
            this.rusRadioButton.Location = new System.Drawing.Point(742, 315);
            this.rusRadioButton.Name = "rusRadioButton";
            this.rusRadioButton.Size = new System.Drawing.Size(47, 17);
            this.rusRadioButton.TabIndex = 13;
            this.rusRadioButton.TabStop = true;
            this.rusRadioButton.Text = "РУС";
            this.rusRadioButton.UseVisualStyleBackColor = true;
            this.rusRadioButton.CheckedChanged += new System.EventHandler(this.rusRadioButton_CheckedChanged);
            // 
            // engRadioButton
            // 
            this.engRadioButton.AutoSize = true;
            this.engRadioButton.Location = new System.Drawing.Point(795, 315);
            this.engRadioButton.Name = "engRadioButton";
            this.engRadioButton.Size = new System.Drawing.Size(48, 17);
            this.engRadioButton.TabIndex = 14;
            this.engRadioButton.Text = "ENG";
            this.engRadioButton.UseVisualStyleBackColor = true;
            this.engRadioButton.CheckedChanged += new System.EventHandler(this.engRadioButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(742, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Язык/Language:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(601, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "©ned0emo, ver 1.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 344);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.engRadioButton);
            this.Controls.Add(this.rusRadioButton);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Рандомайзер Тень Чернобыля";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox armorTextBox;
        private System.Windows.Forms.TextBox afTextBox;
        private System.Windows.Forms.TextBox addonTextBox;
        private System.Windows.Forms.TextBox ammoTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox monsterTextBox;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.CheckBox translateCheckBox;
        private System.Windows.Forms.RadioButton rusRadioButton;
        private System.Windows.Forms.RadioButton engRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

