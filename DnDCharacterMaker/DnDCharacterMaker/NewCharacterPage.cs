using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharacterMaker
{
    public partial class NewCharacterPage : Form
    {
        //class objects
        Character createdCharacter;
        GeneratedCharacterPage generatedCharacterPage;

        public NewCharacterPage()
        {
            InitializeComponent();
        }

        private void raceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the race has a subrace option
            if (raceComboBox.SelectedItem.ToString() == "Dwarf" || raceComboBox.SelectedItem.ToString() == "Elf"
                || raceComboBox.SelectedItem.ToString() == "Gnome" || raceComboBox.SelectedItem.ToString() == "Halfling")
            {
                //clear current subrace choices
                subraceComboBox.Items.Clear();

                //fill combo box with subrace options depending on which race chosen
                switch (raceComboBox.SelectedItem.ToString())
                {
                    case "Dwarf":
                        subraceComboBox.Items.Add("Hill Dwarf");
                        subraceComboBox.Items.Add("Mountain Dwarf");
                        subraceComboBox.Items.Add("Duergar");
                        break;
                    case "Elf":
                        subraceComboBox.Items.Add("High Elf");
                        subraceComboBox.Items.Add("Wood Elf");
                        subraceComboBox.Items.Add("Drow");
                        break;
                    case "Gnome":
                        subraceComboBox.Items.Add("Deep Gnome");
                        subraceComboBox.Items.Add("Rock Gnome");
                        subraceComboBox.Items.Add("Forest Gnome");
                        break;
                    case "Halfling":
                        subraceComboBox.Items.Add("Stout Halfling");
                        subraceComboBox.Items.Add("Lightfoot Halfling");
                        break;
                }

                //display subrace options
                subraceLabel.Visible = true;
                subraceComboBox.Visible = true;
            }
            else //hide subrace options
            {
                subraceLabel.Visible = false;
                subraceComboBox.Visible = false;
            }
        }

        //when a class button is clicked
        private void classButton_Click(object sender, EventArgs e)
        {
            //assign the name of the button to a classname variable
            string className = (sender as Button).Text;
            string race;
            string subrace;

            try
            {
                //if a subrace can be selected, track both race and subrace, else just race
                if (subraceComboBox.Visible)
                {
                    race = raceComboBox.SelectedItem.ToString();
                    subrace = subraceComboBox.SelectedItem.ToString();
                }
                else
                {
                    race = raceComboBox.SelectedItem.ToString();
                    subrace = null;
                }
            }
            catch (NullReferenceException) //if no race/subrace is selected assign null to race and subrace variable
            {
                race = null;
                subrace = null;
            }

            int level = Convert.ToInt32(levelNum.Value);

            //as long as race isn't null, go ahead and make a character
            if (race != null)
            {
                createdCharacter = new Character(className, level, race, subrace);
                generatedCharacterPage = new GeneratedCharacterPage(createdCharacter);
                generatedCharacterPage.Show();
                this.Hide();
            }
            else //let them know what they're missing
            {
                if (subraceComboBox.Visible == false)
                {
                    MessageBox.Show("A race needs to be selected!");
                }
                else
                {
                    MessageBox.Show("A subrace needs to be selected!");
                }
            }
        }
    }
}
