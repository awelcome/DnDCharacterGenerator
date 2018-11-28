using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DnDCharacterMaker
{
    public partial class GeneratedCharacterPage : Form
    {
        Character myChar;
        public GeneratedCharacterPage(Character character)
        {
            myChar = character;
            InitializeComponent();
            PopulateData();
        }

        private void conScoreLabel_Click(object sender, EventArgs e)
        {
            //created on accident. Scared to delete for fear of messing up code.
        }

        private void statNum_ValueChanged(object sender, EventArgs e)
        {
            decimal modifier = ((sender as NumericUpDown).Value - 10) / 2;
            int interval = Convert.ToInt32(Math.Floor(modifier));

            switch ((sender as NumericUpDown).Name)
            {
                case "strNum":
                    myChar.Str = Convert.ToInt32(strNum.Value);
                    if (myChar.StrMod != interval)
                    {
                        myChar.StrMod = interval;
                        AssignModifierLabels();
                    }
                    break;
                case "dexNum":
                    myChar.Dex = Convert.ToInt32(dexNum.Value);
                    if (myChar.DexMod != interval)
                    {
                        myChar.DexMod = interval;
                        AssignModifierLabels();
                    }
                    break;
                case "conNum":
                    myChar.Con = Convert.ToInt32(conNum.Value);
                    if (myChar.ConMod != interval)
                    {
                        myChar.ConMod = interval;
                        AssignModifierLabels();
                    }
                    myChar.Hp = myChar.CalculateHP();
                    hpLabel.Text = "HP: " + myChar.Hp.ToString();
                    break;
                case "intNum":
                    myChar.Intel = Convert.ToInt32(intNum.Value);
                    if (myChar.IntMod != interval)
                    {
                        myChar.IntMod = interval;
                        AssignModifierLabels();
                    }
                    break;
                case "wisNum":
                    myChar.Wis = Convert.ToInt32(wisNum.Value);
                    if (myChar.WisMod != interval)
                    {
                        myChar.WisMod = interval;
                        AssignModifierLabels();
                    }
                    break;
                case "chaNum":
                    myChar.Cha = Convert.ToInt32(chaNum.Value);
                    if (myChar.ChaMod != interval)
                    {
                        myChar.ChaMod = interval;
                        AssignModifierLabels();
                    }
                    break;
            }
        }

        private void AssignModifierLabels()
        {
            if (myChar.StrMod < 0)
            {
                strModLabel.Text = myChar.StrMod.ToString();
            }
            else
            {
                strModLabel.Text = "+" + myChar.StrMod.ToString();
            }

            if (myChar.DexMod < 0)
            {
                dexModLabel.Text = myChar.DexMod.ToString();
            }
            else
            {
                dexModLabel.Text = "+" + myChar.DexMod.ToString();
            }

            if (myChar.ConMod < 0)
            {
                conModLabel.Text = myChar.ConMod.ToString();
            }
            else
            {
                conModLabel.Text = "+" + myChar.ConMod.ToString();
            }

            if (myChar.IntMod < 0)
            {
                intModLabel.Text = myChar.IntMod.ToString();
            }
            else
            {
                intModLabel.Text = "+" + myChar.IntMod.ToString();
            }

            if (myChar.WisMod < 0)
            {
                wisModLabel.Text = myChar.WisMod.ToString();
            }
            else
            {
                wisModLabel.Text = "+" + myChar.WisMod.ToString();
            }

            if (myChar.ChaMod < 0)
            {
                chaModLabel.Text = myChar.ChaMod.ToString();
            }
            else
            {
                chaModLabel.Text = "+" + myChar.ChaMod.ToString();
            }
        }

        private void PopulateData()
        {
            //assign proper values to labels
            levelLabel.Text = "Level: " + myChar.Level.ToString();
            classLabel.Text = "Class: " + myChar.ClassName;
            hpLabel.Text = "HP: " + myChar.Hp.ToString();
            nameTextbox.Text = myChar.CharName;

            //if there is no subrace then use race
            if (myChar.Subrace == null)
            {
                raceLabel.Text = "Race: " + myChar.Race;
            }
            else
            {
                raceLabel.Text = "Race: " + myChar.Subrace;
            }


            strNum.Value = myChar.Str;
            dexNum.Value = myChar.Dex;
            conNum.Value = myChar.Con;
            intNum.Value = myChar.Intel;
            wisNum.Value = myChar.Wis;
            chaNum.Value = myChar.Cha;

            AssignModifierLabels();

            proficiencyLabel.Text = "Proficiency Modifier: " + myChar.Prof.ToString();
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCharacterPage newCharacterPage = new NewCharacterPage();
            newCharacterPage.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myChar.CharName = nameTextbox.Text;
            saveFileDialog.FileName = myChar.CharName;
            saveFileDialog.Filter = "Character Data Files (*.char)|*.char|All Files (*.*)|*.*";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, myChar);
                    file.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong. Save not Successful");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = "";
                openFileDialog.Filter = "Character Data Files (*char)|*.char|All Files (*.*)|*.*";
                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    myChar = (Character)bf.Deserialize(file);
                    PopulateData();
                    MessageBox.Show(myChar.CharName + " has been loaded");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong. Character File Load Not Successful");
            }
        }
    }
}
