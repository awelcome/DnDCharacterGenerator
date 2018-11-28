namespace DnDCharacterMaker
{
    partial class NewCharacterPage
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
            this.raceComboBox = new System.Windows.Forms.ComboBox();
            this.newCharacterLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.subraceLabel = new System.Windows.Forms.Label();
            this.subraceComboBox = new System.Windows.Forms.ComboBox();
            this.barbarianButton = new System.Windows.Forms.Button();
            this.bardButton = new System.Windows.Forms.Button();
            this.clericButton = new System.Windows.Forms.Button();
            this.monkButton = new System.Windows.Forms.Button();
            this.fighterButton = new System.Windows.Forms.Button();
            this.druidButton = new System.Windows.Forms.Button();
            this.rogueButton = new System.Windows.Forms.Button();
            this.rangerButton = new System.Windows.Forms.Button();
            this.paladinButton = new System.Windows.Forms.Button();
            this.wizardButton = new System.Windows.Forms.Button();
            this.warlockButton = new System.Windows.Forms.Button();
            this.sorcererButton = new System.Windows.Forms.Button();
            this.levelNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.levelNum)).BeginInit();
            this.SuspendLayout();
            // 
            // raceComboBox
            // 
            this.raceComboBox.FormattingEnabled = true;
            this.raceComboBox.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elf",
            "Halfling",
            "Half-Orc",
            "Human",
            "Tiefling"});
            this.raceComboBox.Location = new System.Drawing.Point(175, 124);
            this.raceComboBox.Name = "raceComboBox";
            this.raceComboBox.Size = new System.Drawing.Size(196, 21);
            this.raceComboBox.TabIndex = 0;
            this.raceComboBox.SelectedIndexChanged += new System.EventHandler(this.raceComboBox_SelectedIndexChanged);
            // 
            // newCharacterLabel
            // 
            this.newCharacterLabel.AutoSize = true;
            this.newCharacterLabel.Font = new System.Drawing.Font("Papyrus", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCharacterLabel.ForeColor = System.Drawing.Color.White;
            this.newCharacterLabel.Location = new System.Drawing.Point(252, 26);
            this.newCharacterLabel.Name = "newCharacterLabel";
            this.newCharacterLabel.Size = new System.Drawing.Size(303, 64);
            this.newCharacterLabel.TabIndex = 1;
            this.newCharacterLabel.Text = "New Character";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.BackColor = System.Drawing.Color.Black;
            this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceLabel.ForeColor = System.Drawing.Color.White;
            this.raceLabel.Location = new System.Drawing.Point(122, 126);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(47, 20);
            this.raceLabel.TabIndex = 3;
            this.raceLabel.Text = "Race";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Black;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(478, 126);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(46, 20);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Level";
            // 
            // subraceLabel
            // 
            this.subraceLabel.AutoSize = true;
            this.subraceLabel.BackColor = System.Drawing.Color.Black;
            this.subraceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subraceLabel.ForeColor = System.Drawing.Color.White;
            this.subraceLabel.Location = new System.Drawing.Point(100, 158);
            this.subraceLabel.Name = "subraceLabel";
            this.subraceLabel.Size = new System.Drawing.Size(69, 20);
            this.subraceLabel.TabIndex = 5;
            this.subraceLabel.Text = "Subrace";
            this.subraceLabel.Visible = false;
            // 
            // subraceComboBox
            // 
            this.subraceComboBox.FormattingEnabled = true;
            this.subraceComboBox.Location = new System.Drawing.Point(175, 157);
            this.subraceComboBox.Name = "subraceComboBox";
            this.subraceComboBox.Size = new System.Drawing.Size(196, 21);
            this.subraceComboBox.TabIndex = 6;
            this.subraceComboBox.Visible = false;
            // 
            // barbarianButton
            // 
            this.barbarianButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barbarianButton.ForeColor = System.Drawing.Color.Red;
            this.barbarianButton.Location = new System.Drawing.Point(27, 211);
            this.barbarianButton.Name = "barbarianButton";
            this.barbarianButton.Size = new System.Drawing.Size(212, 81);
            this.barbarianButton.TabIndex = 7;
            this.barbarianButton.Text = "Barbarian";
            this.barbarianButton.UseVisualStyleBackColor = true;
            this.barbarianButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // bardButton
            // 
            this.bardButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bardButton.ForeColor = System.Drawing.Color.Red;
            this.bardButton.Location = new System.Drawing.Point(304, 211);
            this.bardButton.Name = "bardButton";
            this.bardButton.Size = new System.Drawing.Size(212, 81);
            this.bardButton.TabIndex = 8;
            this.bardButton.Text = "Bard";
            this.bardButton.UseVisualStyleBackColor = true;
            this.bardButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // clericButton
            // 
            this.clericButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clericButton.ForeColor = System.Drawing.Color.Red;
            this.clericButton.Location = new System.Drawing.Point(565, 211);
            this.clericButton.Name = "clericButton";
            this.clericButton.Size = new System.Drawing.Size(212, 81);
            this.clericButton.TabIndex = 9;
            this.clericButton.Text = "Cleric";
            this.clericButton.UseVisualStyleBackColor = true;
            this.clericButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // monkButton
            // 
            this.monkButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monkButton.ForeColor = System.Drawing.Color.Red;
            this.monkButton.Location = new System.Drawing.Point(565, 313);
            this.monkButton.Name = "monkButton";
            this.monkButton.Size = new System.Drawing.Size(212, 81);
            this.monkButton.TabIndex = 12;
            this.monkButton.Text = "Monk";
            this.monkButton.UseVisualStyleBackColor = true;
            this.monkButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // fighterButton
            // 
            this.fighterButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fighterButton.ForeColor = System.Drawing.Color.Red;
            this.fighterButton.Location = new System.Drawing.Point(304, 313);
            this.fighterButton.Name = "fighterButton";
            this.fighterButton.Size = new System.Drawing.Size(212, 81);
            this.fighterButton.TabIndex = 11;
            this.fighterButton.Text = "Fighter";
            this.fighterButton.UseVisualStyleBackColor = true;
            this.fighterButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // druidButton
            // 
            this.druidButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.druidButton.ForeColor = System.Drawing.Color.Red;
            this.druidButton.Location = new System.Drawing.Point(27, 313);
            this.druidButton.Name = "druidButton";
            this.druidButton.Size = new System.Drawing.Size(212, 81);
            this.druidButton.TabIndex = 10;
            this.druidButton.Text = "Druid";
            this.druidButton.UseVisualStyleBackColor = true;
            this.druidButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // rogueButton
            // 
            this.rogueButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rogueButton.ForeColor = System.Drawing.Color.Red;
            this.rogueButton.Location = new System.Drawing.Point(565, 415);
            this.rogueButton.Name = "rogueButton";
            this.rogueButton.Size = new System.Drawing.Size(212, 81);
            this.rogueButton.TabIndex = 15;
            this.rogueButton.Text = "Rogue";
            this.rogueButton.UseVisualStyleBackColor = true;
            this.rogueButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // rangerButton
            // 
            this.rangerButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangerButton.ForeColor = System.Drawing.Color.Red;
            this.rangerButton.Location = new System.Drawing.Point(304, 415);
            this.rangerButton.Name = "rangerButton";
            this.rangerButton.Size = new System.Drawing.Size(212, 81);
            this.rangerButton.TabIndex = 14;
            this.rangerButton.Text = "Ranger";
            this.rangerButton.UseVisualStyleBackColor = true;
            this.rangerButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // paladinButton
            // 
            this.paladinButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paladinButton.ForeColor = System.Drawing.Color.Red;
            this.paladinButton.Location = new System.Drawing.Point(27, 415);
            this.paladinButton.Name = "paladinButton";
            this.paladinButton.Size = new System.Drawing.Size(212, 81);
            this.paladinButton.TabIndex = 13;
            this.paladinButton.Text = "Paladin";
            this.paladinButton.UseVisualStyleBackColor = true;
            this.paladinButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // wizardButton
            // 
            this.wizardButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardButton.ForeColor = System.Drawing.Color.Red;
            this.wizardButton.Location = new System.Drawing.Point(565, 516);
            this.wizardButton.Name = "wizardButton";
            this.wizardButton.Size = new System.Drawing.Size(212, 81);
            this.wizardButton.TabIndex = 18;
            this.wizardButton.Text = "Wizard";
            this.wizardButton.UseVisualStyleBackColor = true;
            this.wizardButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // warlockButton
            // 
            this.warlockButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warlockButton.ForeColor = System.Drawing.Color.Red;
            this.warlockButton.Location = new System.Drawing.Point(304, 516);
            this.warlockButton.Name = "warlockButton";
            this.warlockButton.Size = new System.Drawing.Size(212, 81);
            this.warlockButton.TabIndex = 17;
            this.warlockButton.Text = "Warlock";
            this.warlockButton.UseVisualStyleBackColor = true;
            this.warlockButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // sorcererButton
            // 
            this.sorcererButton.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorcererButton.ForeColor = System.Drawing.Color.Red;
            this.sorcererButton.Location = new System.Drawing.Point(27, 516);
            this.sorcererButton.Name = "sorcererButton";
            this.sorcererButton.Size = new System.Drawing.Size(212, 81);
            this.sorcererButton.TabIndex = 16;
            this.sorcererButton.Text = "Sorcerer";
            this.sorcererButton.UseVisualStyleBackColor = true;
            this.sorcererButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // levelNum
            // 
            this.levelNum.Location = new System.Drawing.Point(530, 126);
            this.levelNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.levelNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelNum.Name = "levelNum";
            this.levelNum.Size = new System.Drawing.Size(120, 20);
            this.levelNum.TabIndex = 19;
            this.levelNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.levelNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NewCharacterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.levelNum);
            this.Controls.Add(this.wizardButton);
            this.Controls.Add(this.warlockButton);
            this.Controls.Add(this.sorcererButton);
            this.Controls.Add(this.rogueButton);
            this.Controls.Add(this.rangerButton);
            this.Controls.Add(this.paladinButton);
            this.Controls.Add(this.monkButton);
            this.Controls.Add(this.fighterButton);
            this.Controls.Add(this.druidButton);
            this.Controls.Add(this.clericButton);
            this.Controls.Add(this.bardButton);
            this.Controls.Add(this.barbarianButton);
            this.Controls.Add(this.subraceComboBox);
            this.Controls.Add(this.subraceLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.newCharacterLabel);
            this.Controls.Add(this.raceComboBox);
            this.Name = "NewCharacterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Character";
            ((System.ComponentModel.ISupportInitialize)(this.levelNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox raceComboBox;
        private System.Windows.Forms.Label newCharacterLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label subraceLabel;
        private System.Windows.Forms.ComboBox subraceComboBox;
        private System.Windows.Forms.Button barbarianButton;
        private System.Windows.Forms.Button bardButton;
        private System.Windows.Forms.Button clericButton;
        private System.Windows.Forms.Button monkButton;
        private System.Windows.Forms.Button fighterButton;
        private System.Windows.Forms.Button druidButton;
        private System.Windows.Forms.Button rogueButton;
        private System.Windows.Forms.Button rangerButton;
        private System.Windows.Forms.Button paladinButton;
        private System.Windows.Forms.Button wizardButton;
        private System.Windows.Forms.Button warlockButton;
        private System.Windows.Forms.Button sorcererButton;
        private System.Windows.Forms.NumericUpDown levelNum;
    }
}