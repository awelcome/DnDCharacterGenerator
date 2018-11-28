namespace DnDCharacterMaker
{
    partial class GeneratedCharacterPage
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.proficiencyLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.conLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.wisLabel = new System.Windows.Forms.Label();
            this.chaLabel = new System.Windows.Forms.Label();
            this.strNum = new System.Windows.Forms.NumericUpDown();
            this.dexNum = new System.Windows.Forms.NumericUpDown();
            this.conNum = new System.Windows.Forms.NumericUpDown();
            this.intNum = new System.Windows.Forms.NumericUpDown();
            this.wisNum = new System.Windows.Forms.NumericUpDown();
            this.chaNum = new System.Windows.Forms.NumericUpDown();
            this.strModLabel = new System.Windows.Forms.Label();
            this.dexModLabel = new System.Windows.Forms.Label();
            this.conModLabel = new System.Windows.Forms.Label();
            this.intModLabel = new System.Windows.Forms.Label();
            this.wisModLabel = new System.Windows.Forms.Label();
            this.chaModLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(43, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(101, 31);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.ForeColor = System.Drawing.Color.White;
            this.classLabel.Location = new System.Drawing.Point(43, 91);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(98, 31);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "Class: ";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(464, 45);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(94, 31);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "Level: ";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.ForeColor = System.Drawing.Color.White;
            this.hpLabel.Location = new System.Drawing.Point(464, 91);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(67, 31);
            this.hpLabel.TabIndex = 3;
            this.hpLabel.Text = "HP: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(150, 56);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(202, 20);
            this.nameTextbox.TabIndex = 5;
            // 
            // proficiencyLabel
            // 
            this.proficiencyLabel.AutoSize = true;
            this.proficiencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proficiencyLabel.ForeColor = System.Drawing.Color.White;
            this.proficiencyLabel.Location = new System.Drawing.Point(225, 175);
            this.proficiencyLabel.Name = "proficiencyLabel";
            this.proficiencyLabel.Size = new System.Drawing.Size(266, 31);
            this.proficiencyLabel.TabIndex = 6;
            this.proficiencyLabel.Text = "Proficiency Modifier: ";
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strLabel.ForeColor = System.Drawing.Color.White;
            this.strLabel.Location = new System.Drawing.Point(144, 244);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(64, 31);
            this.strLabel.TabIndex = 7;
            this.strLabel.Text = "Str: ";
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexLabel.ForeColor = System.Drawing.Color.White;
            this.dexLabel.Location = new System.Drawing.Point(144, 296);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(70, 31);
            this.dexLabel.TabIndex = 8;
            this.dexLabel.Text = "Dex:";
            // 
            // conLabel
            // 
            this.conLabel.AutoSize = true;
            this.conLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conLabel.ForeColor = System.Drawing.Color.White;
            this.conLabel.Location = new System.Drawing.Point(144, 350);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(72, 31);
            this.conLabel.TabIndex = 9;
            this.conLabel.Text = "Con:";
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intLabel.ForeColor = System.Drawing.Color.White;
            this.intLabel.Location = new System.Drawing.Point(449, 244);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(53, 31);
            this.intLabel.TabIndex = 10;
            this.intLabel.Text = "Int:";
            // 
            // wisLabel
            // 
            this.wisLabel.AutoSize = true;
            this.wisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisLabel.ForeColor = System.Drawing.Color.White;
            this.wisLabel.Location = new System.Drawing.Point(449, 296);
            this.wisLabel.Name = "wisLabel";
            this.wisLabel.Size = new System.Drawing.Size(67, 31);
            this.wisLabel.TabIndex = 11;
            this.wisLabel.Text = "Wis:";
            // 
            // chaLabel
            // 
            this.chaLabel.AutoSize = true;
            this.chaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaLabel.ForeColor = System.Drawing.Color.White;
            this.chaLabel.Location = new System.Drawing.Point(449, 350);
            this.chaLabel.Name = "chaLabel";
            this.chaLabel.Size = new System.Drawing.Size(72, 31);
            this.chaLabel.TabIndex = 12;
            this.chaLabel.Text = "Cha:";
            // 
            // strNum
            // 
            this.strNum.Location = new System.Drawing.Point(214, 255);
            this.strNum.Name = "strNum";
            this.strNum.Size = new System.Drawing.Size(44, 20);
            this.strNum.TabIndex = 13;
            this.strNum.ValueChanged += new System.EventHandler(this.statNum_ValueChanged);
            // 
            // dexNum
            // 
            this.dexNum.Location = new System.Drawing.Point(214, 307);
            this.dexNum.Name = "dexNum";
            this.dexNum.Size = new System.Drawing.Size(44, 20);
            this.dexNum.TabIndex = 14;
            this.dexNum.ValueChanged += new System.EventHandler(this.statNum_ValueChanged);
            // 
            // conNum
            // 
            this.conNum.Location = new System.Drawing.Point(214, 361);
            this.conNum.Name = "conNum";
            this.conNum.Size = new System.Drawing.Size(44, 20);
            this.conNum.TabIndex = 15;
            this.conNum.ValueChanged += new System.EventHandler(this.statNum_ValueChanged);
            // 
            // intNum
            // 
            this.intNum.Location = new System.Drawing.Point(522, 255);
            this.intNum.Name = "intNum";
            this.intNum.Size = new System.Drawing.Size(44, 20);
            this.intNum.TabIndex = 16;
            this.intNum.ValueChanged += new System.EventHandler(this.statNum_ValueChanged);
            // 
            // wisNum
            // 
            this.wisNum.Location = new System.Drawing.Point(522, 309);
            this.wisNum.Name = "wisNum";
            this.wisNum.Size = new System.Drawing.Size(44, 20);
            this.wisNum.TabIndex = 17;
            this.wisNum.ValueChanged += new System.EventHandler(this.statNum_ValueChanged);
            // 
            // chaNum
            // 
            this.chaNum.Location = new System.Drawing.Point(522, 361);
            this.chaNum.Name = "chaNum";
            this.chaNum.Size = new System.Drawing.Size(44, 20);
            this.chaNum.TabIndex = 18;
            this.chaNum.ValueChanged += new System.EventHandler(this.statNum_ValueChanged);
            // 
            // strModLabel
            // 
            this.strModLabel.AutoSize = true;
            this.strModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strModLabel.ForeColor = System.Drawing.Color.White;
            this.strModLabel.Location = new System.Drawing.Point(278, 244);
            this.strModLabel.Name = "strModLabel";
            this.strModLabel.Size = new System.Drawing.Size(30, 31);
            this.strModLabel.TabIndex = 19;
            this.strModLabel.Text = "+";
            // 
            // dexModLabel
            // 
            this.dexModLabel.AutoSize = true;
            this.dexModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexModLabel.ForeColor = System.Drawing.Color.White;
            this.dexModLabel.Location = new System.Drawing.Point(278, 296);
            this.dexModLabel.Name = "dexModLabel";
            this.dexModLabel.Size = new System.Drawing.Size(30, 31);
            this.dexModLabel.TabIndex = 20;
            this.dexModLabel.Text = "+";
            // 
            // conModLabel
            // 
            this.conModLabel.AutoSize = true;
            this.conModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conModLabel.ForeColor = System.Drawing.Color.White;
            this.conModLabel.Location = new System.Drawing.Point(278, 350);
            this.conModLabel.Name = "conModLabel";
            this.conModLabel.Size = new System.Drawing.Size(30, 31);
            this.conModLabel.TabIndex = 21;
            this.conModLabel.Text = "+";
            this.conModLabel.Click += new System.EventHandler(this.conScoreLabel_Click);
            // 
            // intModLabel
            // 
            this.intModLabel.AutoSize = true;
            this.intModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intModLabel.ForeColor = System.Drawing.Color.White;
            this.intModLabel.Location = new System.Drawing.Point(586, 244);
            this.intModLabel.Name = "intModLabel";
            this.intModLabel.Size = new System.Drawing.Size(30, 31);
            this.intModLabel.TabIndex = 22;
            this.intModLabel.Text = "+";
            // 
            // wisModLabel
            // 
            this.wisModLabel.AutoSize = true;
            this.wisModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisModLabel.ForeColor = System.Drawing.Color.White;
            this.wisModLabel.Location = new System.Drawing.Point(586, 298);
            this.wisModLabel.Name = "wisModLabel";
            this.wisModLabel.Size = new System.Drawing.Size(30, 31);
            this.wisModLabel.TabIndex = 23;
            this.wisModLabel.Text = "+";
            // 
            // chaModLabel
            // 
            this.chaModLabel.AutoSize = true;
            this.chaModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaModLabel.ForeColor = System.Drawing.Color.White;
            this.chaModLabel.Location = new System.Drawing.Point(586, 350);
            this.chaModLabel.Name = "chaModLabel";
            this.chaModLabel.Size = new System.Drawing.Size(30, 31);
            this.chaModLabel.TabIndex = 24;
            this.chaModLabel.Text = "+";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceLabel.ForeColor = System.Drawing.Color.White;
            this.raceLabel.Location = new System.Drawing.Point(43, 134);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(93, 31);
            this.raceLabel.TabIndex = 25;
            this.raceLabel.Text = "Race: ";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newCharacterToolStripMenuItem.Text = "New Character";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // GeneratedCharacterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.chaModLabel);
            this.Controls.Add(this.wisModLabel);
            this.Controls.Add(this.intModLabel);
            this.Controls.Add(this.conModLabel);
            this.Controls.Add(this.dexModLabel);
            this.Controls.Add(this.strModLabel);
            this.Controls.Add(this.chaNum);
            this.Controls.Add(this.wisNum);
            this.Controls.Add(this.intNum);
            this.Controls.Add(this.conNum);
            this.Controls.Add(this.dexNum);
            this.Controls.Add(this.strNum);
            this.Controls.Add(this.chaLabel);
            this.Controls.Add(this.wisLabel);
            this.Controls.Add(this.intLabel);
            this.Controls.Add(this.conLabel);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.proficiencyLabel);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeneratedCharacterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generated Character";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label proficiencyLabel;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.Label conLabel;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Label wisLabel;
        private System.Windows.Forms.Label chaLabel;
        private System.Windows.Forms.NumericUpDown strNum;
        private System.Windows.Forms.NumericUpDown dexNum;
        private System.Windows.Forms.NumericUpDown conNum;
        private System.Windows.Forms.NumericUpDown intNum;
        private System.Windows.Forms.NumericUpDown wisNum;
        private System.Windows.Forms.NumericUpDown chaNum;
        private System.Windows.Forms.Label strModLabel;
        private System.Windows.Forms.Label dexModLabel;
        private System.Windows.Forms.Label conModLabel;
        private System.Windows.Forms.Label intModLabel;
        private System.Windows.Forms.Label wisModLabel;
        private System.Windows.Forms.Label chaModLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}