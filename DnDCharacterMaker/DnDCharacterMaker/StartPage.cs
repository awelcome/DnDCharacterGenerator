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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void NewCharacterButton_Click(object sender, EventArgs e)
        {
            NewCharacterPage newCharacterPage = new NewCharacterPage();
            newCharacterPage.Show();
            this.Hide();
        }

        private void LoadCharacterButton_Click(object sender, EventArgs e)
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
                    Character myChar = (Character)bf.Deserialize(file);
                    GeneratedCharacterPage generatedCharacterPage = new GeneratedCharacterPage(myChar);
                    generatedCharacterPage.Show();
                    this.Hide();
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
