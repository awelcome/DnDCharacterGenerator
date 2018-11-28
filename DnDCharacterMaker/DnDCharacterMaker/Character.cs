using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterMaker
{
    [Serializable]
    public class Character
    {
        List<int> standardStatArray;
        private string charName;
        private int level;
        private int hp;
        private int str;
        private int strMod;
        private int dex;
        private int dexMod;
        private int con;
        private int conMod;
        private int intel;
        private int intMod;
        private int wis;
        private int wisMod;
        private int cha;
        private int chaMod;
        private int prof;
        private string className;
        private string race;
        private string subrace;
        private string priorityStat;
        private string dumpStat;

        public int Level { get => level; set => level = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Str { get => str; set => str = value; }
        public int StrMod { get => strMod; set => strMod = value; }
        public int Dex { get => dex; set => dex = value; }
        public int DexMod { get => dexMod; set => dexMod = value; }
        public int Con { get => con; set => con = value; }
        public int ConMod { get => conMod; set => conMod = value; }
        public int Intel { get => intel; set => intel = value; }
        public int IntMod { get => intMod; set => intMod = value; }
        public int Wis { get => wis; set => wis = value; }
        public int WisMod { get => wisMod; set => wisMod = value; }
        public int Cha { get => cha; set => cha = value; }
        public int ChaMod { get => chaMod; set => chaMod = value; }
        public int Prof { get => prof; set => prof = value; }
        public string ClassName { get => className; set => className = value; }
        public string Race { get => race; set => race = value; }
        public string Subrace { get => subrace; set => subrace = value; }
        public string CharName { get => charName; set => charName = value; }
        public string PriorityStat { get => priorityStat; set => priorityStat = value; }
        public string DumpStat { get => dumpStat; set => dumpStat = value; }
        

        public Character(string className, int level, string race, string subrace = "")
        {
            //take in variables from instatiation
            this.ClassName = className;
            this.Level = level;
            this.Race = race;
            this.Subrace = subrace;
            CharName = RandomName(race);

            //make list of standard array, add numbers
            standardStatArray = new List<int>();
            standardStatArray.Add(15);
            standardStatArray.Add(14);
            standardStatArray.Add(13);
            standardStatArray.Add(12);
            standardStatArray.Add(12);
            standardStatArray.Add(8);

            //for now, randomly assign base stats
            //TODO: make stat assignment class specific
            PriorityAndDump();
            AssignStats();

            //calculate proficiency score
            if (level >= 1 && level <= 4)
                Prof = 2;
            else if (level >= 5 && level <= 8)
                Prof = 3;
            else if (level >= 9 && level <= 12)
                Prof = 4;
            else if (level >= 13 && level <= 16)
                Prof = 5;
            else if (level >= 17 && level <= 20)
                Prof = 6;

            //calculate HP
            Hp = CalculateHP();
        }

        public int CalculateHP()
        {
            int hitDie;
            switch (className)
            {
                case "Barbarian":
                    hitDie = 12;
                    break;
                case "Paladin":
                case "Ranger":
                case "Fighter":
                    hitDie = 10;
                    break;
                case "Bard":
                case "Cleric":
                case "Druid":
                case "Monk":
                case "Rogue":
                case "Warlock":
                    hitDie = 8;
                    break;
                case "Sorcerer":
                case "Wizard":
                    hitDie = 6;
                    break;
                default:
                    hitDie = 8;
                    break;
            }
            int hpIncrease = (hitDie / 2) + 1 + ConMod;

            return (hitDie + ConMod) + (hpIncrease * (level - 1));
        }

        public int RandomAssignment()
        {
            int index;
            int stat;

            Random rnd = new Random();
            index = rnd.Next(0, standardStatArray.Count);
            stat = standardStatArray[index];
            standardStatArray.RemoveAt(index);
            return stat;
        }

        public int DetermineModifier(int stat)
        {
            double modifier = (stat - 10) / 2;
            int interval = Convert.ToInt32(Math.Floor(modifier));
            return interval;
        }

        public void AssignStats()
        {
            switch (PriorityStat)
            {
                case "Str":
                    Str = standardStatArray.Max();
                    standardStatArray.Remove(standardStatArray.Max());
                    break;
                case "Dex":
                    Dex = standardStatArray.Max();
                    standardStatArray.Remove(standardStatArray.Max());
                    break;
                case "Con":
                    Con = standardStatArray.Max();
                    standardStatArray.Remove(standardStatArray.Max());
                    break;
                case "Intel":
                    Intel = standardStatArray.Max();
                    standardStatArray.Remove(standardStatArray.Max());
                    break;
                case "Wis":
                    Wis = standardStatArray.Max();
                    standardStatArray.Remove(standardStatArray.Max());
                    break;
                case "Cha":
                    Cha = standardStatArray.Max();
                    standardStatArray.Remove(standardStatArray.Max());
                    break;
            }

            switch (DumpStat)
            {
                case "Str":
                    Str = standardStatArray.Min();
                    standardStatArray.Remove(standardStatArray.Min());
                    break;
                case "Dex":
                    Dex = standardStatArray.Min();
                    standardStatArray.Remove(standardStatArray.Min());
                    break;
                case "Con":
                    Con = standardStatArray.Min();
                    standardStatArray.Remove(standardStatArray.Min());
                    break;
                case "Intel":
                    Intel = standardStatArray.Min();
                    standardStatArray.Remove(standardStatArray.Min());
                    break;
                case "Wis":
                    Wis = standardStatArray.Min();
                    standardStatArray.Remove(standardStatArray.Min());
                    break;
                case "Cha":
                    Cha = standardStatArray.Min();
                    standardStatArray.Remove(standardStatArray.Min());
                    break;
            }

            if (Str == 0)
            {
                Str = RandomAssignment();
            }

            if (Dex == 0)
            {
                Dex = RandomAssignment();
            }

            if (Con == 0)
            {
                Con = RandomAssignment();
            }

            if (Wis == 0)
            {
                Wis = RandomAssignment();
            }

            if (Intel == 0)
            {
                Intel = RandomAssignment();
            }

            if (Cha == 0)
            {
                Cha = RandomAssignment();
            }

            RacialBonus();
            AbilityScoreIncreases();

            StrMod = DetermineModifier(Str);
            DexMod = DetermineModifier(Dex);
            ConMod = DetermineModifier(Con);
            IntMod = DetermineModifier(Intel);
            WisMod = DetermineModifier(Wis);
            ChaMod = DetermineModifier(Cha);
        }

        public string RandomName(string race)
        {
            int index;
            string name;
            List<string> names = new List<string>();

            switch (race.ToUpper())
            {
                case "DRAGONBORN":
                    names.Add("Durmorn Druccundron");
                    names.Add("Baxiros Inkad");
                    names.Add("Fenzita Terdostad");
                    names.Add("Oxiris Naathtash");
                    names.Add("Nicol Bolas");
                    break;
                case "DWARF":
                    names.Add("Bronznik Dragonheart");
                    names.Add("Magmond Flintpike");
                    names.Add("Thorkohm Chainmane");
                    names.Add("Bonria Boulderbender");
                    names.Add("Runnar Noblebraid");
                    break;
                case "ELF":
                    names.Add("Elfir Milnelune");
                    names.Add("Addan Venthyra");
                    names.Add("Venwynn Sarceran");
                    names.Add("Felaern Yesfir");
                    names.Add("Keenor Daqen");
                    break;
                case "GNOME":
                    names.Add("Clampep Meednut");
                    names.Add("Flisensmep Finklentoog");
                    names.Add("Donjum Dofobbnog");
                    names.Add("Freensmanust Leddlis");
                    names.Add("Milwela Blunuddie");
                    break;
                case "HALF-ELF":
                    names.Add("Clerrel Morrie");
                    names.Add("Leothin Xilrieth");
                    names.Add("Mirthara Rodi");
                    names.Add("Restora Gildove");
                    names.Add("Alnik Miradan");
                    break;
                case "HALFLING":
                    names.Add("Hincmar Lothran");
                    names.Add("Allowin Maggot");
                    names.Add("Bernard Burrows");
                    names.Add("Sydney Goold");
                    names.Add("Myrna Gamwich");
                    break;
                case "HALF-ORC":
                    names.Add("Kralroll Grumabur");
                    names.Add("Garuuk Goretusk");
                    names.Add("Draurgin Katonur");
                    names.Add("Okrag Kurodak");
                    names.Add("Devra Rashash");
                    break;
                case "HUMAN":
                    names.Add("George Baker");
                    names.Add("Hobart Rocksteam");
                    names.Add("Delmore Flatsong");
                    names.Add("Matthias Windsor");
                    names.Add("Jed Bartlet");
                    break;
                case "TIEFLING":
                    names.Add("Shaichar");
                    names.Add("Flawed");
                    names.Add("Terror");
                    names.Add("Thynexes");
                    names.Add("Sly");
                    break;
            }

            Random rnd = new Random();
            index = rnd.Next(0, names.Count);
            name = names[index];

            return name;
        }

        public void RacialBonus()
        {
            if (subrace == null)
            {
                switch (race)
                {
                    case "Dragonborn":
                        Str += 2;
                        Cha += 1;
                        break;
                    case "Half-Elf":
                        Cha += 2;
                        Con += 1;
                        PriorityStat += 1;
                        break;
                    case "Half-Orc":
                        Str += 2;
                        Con += 1;
                        break;
                    case "Human":
                        Str += 1;
                        Dex += 1;
                        Con += 1;
                        Intel += 1;
                        Wis += 1;
                        Cha += 1;
                        break;
                    case "Tiefling":
                        Cha += 2;
                        Intel += 1;
                        break;
                }
            }
            else
            {
                switch (subrace)
                {
                    case "Mountain Dwarf":
                        Con += 2;
                        Str += 2;
                        break;
                    case "Duergar":
                        Con += 2;
                        Str += 1;
                        break;
                    case "Hill Dwarf":
                        Con += 2;
                        Wis += 1;
                        Hp += level;
                        break;
                    case "High Elf":
                        Dex += 2;
                        Intel += 1;
                        break;
                    case "Wood Elf":
                        Dex += 2;
                        Wis += 1;
                        break;
                    case "Drow":
                        Dex += 2;
                        Cha += 1;
                        break;
                    case "Deep Gnome":
                        Intel += 2;
                        Dex += 1;
                        break;
                    case "Rock Gnome":
                        Intel += 2;
                        Con += 1;
                        break;
                    case "Forest Gnome":
                        Intel += 2;
                        Dex += 1;
                        break;
                    case "Stout Halfling":
                        Dex += 2;
                        Con += 1;
                        break;
                    case "Lightfoot Halfling":
                        Dex += 2;
                        Cha += 1;
                        break;
                }
            }
        }

        public void PriorityAndDump()
        {
            switch (ClassName)
            {
                case "Barbarian":
                    PriorityStat = "Str";
                    DumpStat = "Intel";
                    break;
                case "Bard":
                    PriorityStat = "Cha";
                    DumpStat = "Str";
                    break;
                case "Cleric":
                    PriorityStat = "Wis";
                    DumpStat = "Cha";
                    break;
                case "Druid":
                    PriorityStat = "Wis";
                    DumpStat = "Str";
                    break;
                case "Fighter":
                    PriorityStat = "Str";
                    DumpStat = "Intel";
                    break;
                case "Monk":
                    PriorityStat = "Dex";
                    DumpStat = "Str";
                    break;
                case "Paladin":
                    PriorityStat = "Str";
                    DumpStat = "Intel";
                    break;
                case "Ranger":
                    PriorityStat = "Dex";
                    DumpStat = "Str";
                    break;
                case "Rogue":
                    PriorityStat = "Dex";
                    DumpStat = "Str";
                    break;
                case "Sorcerer":
                    PriorityStat = "Cha";
                    DumpStat = "Str";
                    break;
                case "Warlock":
                    PriorityStat = "Cha";
                    DumpStat = "Str";
                    break;
                case "Wizard":
                    PriorityStat = "Intel";
                    DumpStat = "Str";
                    break;
            }
        }

        public void AbilityScoreIncreases()
        {
            int numOfIncreases;

            switch (ClassName)
            {
                case "Barbarian":
                case "Bard":
                case "Cleric":
                case "Druid":
                case "Monk":
                case "Ranger":
                case "Paladin":
                case "Sorcerer":
                case "Warlock":
                case "Wizard":
                    switch (Level)
                    {
                        case 4:
                            numOfIncreases = 1;
                            break;
                        case 8:
                            numOfIncreases = 2;
                            break;
                        case 12:
                            numOfIncreases = 3;
                            break;
                        case 16:
                            numOfIncreases = 4;
                            break;
                        case 19:
                            numOfIncreases = 5;
                            break;
                        default:
                            numOfIncreases = 0;
                            break;
                    }
                    break;
                case "Fighter":
                    switch (Level)
                    {
                        case 4:
                            numOfIncreases = 1;
                            break;
                        case 6:
                            numOfIncreases = 2;
                            break;
                        case 8:
                            numOfIncreases = 3;
                            break;
                        case 12:
                            numOfIncreases = 4;
                            break;
                        case 14:
                            numOfIncreases = 5;
                            break;
                        case 16:
                            numOfIncreases = 6;
                            break;
                        case 19:
                            numOfIncreases = 7;
                            break;
                        default:
                            numOfIncreases = 0;
                            break;
                    }
                    break;
                case "Rogue":
                    switch (Level)
                    {
                        case 4:
                            numOfIncreases = 1;
                            break;
                        case 8:
                            numOfIncreases = 2;
                            break;
                        case 10:
                            numOfIncreases = 3;
                            break;
                        case 12:
                            numOfIncreases = 4;
                            break;
                        case 16:
                            numOfIncreases = 5;
                            break;
                        case 19:
                            numOfIncreases = 6;
                            break;
                        default:
                            numOfIncreases = 0;
                            break;
                    }
                    break;
                default:
                    numOfIncreases = 0;
                    break;

            }

            for (int i = 0; i < numOfIncreases; i++)
            {
                if (Convert.ToInt32(PriorityStat) <= 18)
                {
                    //increase priority stat by 2
                }
                else if (Convert.ToInt32(PriorityStat) == 19)
                {
                    //increase priority stat by 1, and a random stat besides dump stat by 1
                }
                else
                {
                    //increase 2 random stats besides priority and dump by 2
                }
            }
        }
    }
}
