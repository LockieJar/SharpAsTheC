using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monsterButton_Click(object sender, EventArgs e)
        {
            Random rpg = new Random();
            string[] monster = { "Awakened Shrub", "Baboon", "Badger", "Bat", "Cat", "Commoner", "Crab", "Deer", "Eagle", "Frog", "Giant Fire Beetle", "Goat", "Hawk", "Homunculus", "Hyena", "Jackal", "Lemure", "Lizard", "Octopus", "Owl", "Quipper", "Rat", "Raven", "Scorpion", "Sea Horse", "Shrieker", "Spider", "Vulture", "Weasel", "Bandit", "Blood Hawk", "Camel", "Cultist", "Flying Snake", "Giant Crab", "Giant Rat", "Giant Weasel", "Guard", "Kobold", "Mastiff", "Merfolk", "Mule", "Noble", "Poisonous Snake", "Pony", "Stirge", "Tribal Warrior", "Acolyte", "Axe Beak", "Blink Dog", "Boar", "Constrictor Snake", "Draft Horse", "Dretch", "Elf", "Drow", "Elk", "Flying Sword", "Giant Badger", "Giant Bat", "Giant Centipede", "Giant Frog", "Giant Lizard", "Giant Owl", "Giant Poisonous Snake", "Giant Wolf Spider", "Goblin", "Grimlock", "Panther", "Pseudodragon", "Riding Horse", "Skeleton", "Sprite", "Steam Mephit", "Swarm of Bats", "Swarm of Rats", "Swarm of Ravens", "Violet Fungus", "Wolf", "Zombie", "Ape", "Black bear", "Cockatrice", "Crocodile", "Darkmantle", "Dust Mephit", "Giant Goat", "Giant Sea Horse", "Giant Wasp", "Gnoll", "Gnome", "Gray Ooze", "Hobgoblin", "Ice Mephit", "Lizardfolk", "Magma Mephit", "Magmin", "Orc", "Reef Shark", "Rust Monster", "Sahuagin", "Satyr", "Scout", "Shadow", "Swarm of Insects", "Thug", "Warhorse", "Warhorse Skeleton", "Worg", "Animated Armor", "Brass Dragon Wyrmling", "Brown Bear", "Bugbear", "Copper Dragon Wyrmling", "Death Dog", "Dire Wolf", "Dryad", "Duergar", "Ghoul", "Giant Eagle", "Giant Hyena", "Giant Octopus", "Giant Spider", "Giant Toad", "Giant Vulture", "Harpy", "Hippogriff", "Imp", "Lion", "Quasit", "Specter", "Spy", "Swarm of Quippers", "Tiger", "Ankheg", "Awakened Tree", "Azer", "Bandit Captain", "Berserker", "Black Dragon Wyrmling", "Bronze Dragon Wyrmling", "Centaur", "Cult Fanatic", "Druid", "Ettercap", "Gargoyle", "Gelatinous Cube", "Ghast", "Giant Boar", "Giant Constrictor Snake", "Giant Elk", "Gibbering Mouther", "Green Dragon Wyrmling", "Grick", "Griffon", "Hunter Shark", "Merrow", "Mimic", "Minotaur Skeleton", "Ochre Jelly", "Ogre", "Ogre Zombie", "Pegasus", "Plesiosaurus", "Polar Bear", "Priest", "Rhinoceros", "Rug of Smothering", "Saber-Toothed Tiger", "Sea Hag", "Silver Dragon Wyrmling", "Swarm of Poisonous Snakes", "Wererat", "White Dragon Wyrmling", "Will-o'-Wisp", "Basilisk", "Bearded Devil", "Blue Dragon Wyrmling", "Doppelganger", "Giant Scorpion", "Gold Dragon Wyrmling", "Green Hag", "Hell Hound", "Killer Whale", "Knight", "Manticore", "Minotaur", "Mummy", "Nightmare", "Owlbear", "Phase Spider", "Veteran", "Werewolf", "Wight", "Winter Wolf", "Black Pudding", "Chuul", "Couatl", "Elephant", "Ettin", "Ghost", "Lamia", "Red Dragon Wyrmling", "Succubus", "Incubus", "Wereboar", "Weretiger", "Air Elemental", "Barbed Devil", "Bulette", "Earth Elemental", "Fire Elemental", "Flesh Golem", "Giant Crocodile", "Giant Shark", "Gladiator", "Gorgon", "Half-Red Dragon Veteran", "Hill Giant", "Night Hag", "Otyugh", "Roper", "Salamander", "Shambling Mound", "Triceratops", "Troll", "Unicorn", "Vampire Spawn", "Water Elemental", "Werebear", "Wraith", "Xorn", "Chimera", "Drider", "Invisible Stalker", "Mage", "Mammoth", "Medusa", "Vrock", "Wyvern", "Young Brass Dragon", "Young White Dragon", "Giant Ape", "Oni", "Shield Guardian", "Stone Giant", "Young Black Dragon", "Young Copper Dragon", "Assassin", "Chain Devil", "Cloaker", "Frost Giant", "Hezrou", "Hydra", "Spirit Naga", "Tyrannosaurus Rex", "Young Bronze Dragon", "Young Green Dragon", "Bone Devil", "Clay Golem", "Cloud Giant", "Fire Giant", "Glabrezu", "Treant", "Young Blue Dragon", "Young Silver Dragon", "Aboleth", "Deva", "Guardian Naga", "Stone Golem", "Young Gold Dragon", "Young Red Dragon", "Behir", "Djinni", "Efreeti", "Gynosphinx", "Horned Devil", "Remorhaz", "Roc", "Archmage", "Erinyes", "Adult Brass Dragon", "Adult White Dragon", "Nalfeshnee", "Rakshasa", "Storm Giant", "Vampire", "Adult Black Dragon", "Adult Copper Dragon", "Ice Devil", "Adult Bronze Dragon", "Adult Green Dragon", "Mummy Lord", "Purple Worm", "Adult Blue Dragon", "Adult Silver Dragon", "Iron Golem", "Marilith", "Planetar", "Adult Gold Dragon", "Adult Red Dragon", "Androsphinx", "Dragon Turtle", "Balor", "Ancient Brass Dragon", "Ancient White Dragon", "Pit Fiend", "Ancient Black Dragon", "Ancient Copper Dragon", "Lich", "Solar", "Ancient Bronze Dragon", "Ancient Green Dragon", "Ancient Blue Dragon", "Ancient Silver Dragon", "Kraken", "Ancient Gold Dragon", "Ancient Red Dragon", "Tarrasque" };
            int mIndex = rpg.Next(monster.Length);
            string mob = monster[mIndex];
            monsterBox.Text = mob.ToString();
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] enchantments = { "of Minor Alchemy(Fortify Alchemy 1 12%)", "of Alchemy(Fortify Alchemy 2 15%)", "of Major Alchemy(Fortify Alchemy 3 17%)", "of Eminent Alchemy (Fortify Alchemy 4 20%)", "of Extreme Alchemy (Fortify Alchemy 5 22%)", "of Peerless Alchemy (Fortify Alchemy 6 25%)", "of Minor Alteration (Fortify Alteration 1 12%)", "of Alteration (Fortify Alteration 2 15%)", "of Major Alteration (Fortify Alteration 3 17%)", "of Eminent Alteration (Fortify Alteration 4 20%)", "of Extreme Alteration (Fortify Alteration 5 22%)", "of Peerless Alteration (Fortify  Alteration 6 25%)", "of Minor Blocking (Fortify Block 1 15%)", "of Blocking (Fortify Block 2 20%)", "of Major Blocking (Fortify Block 3 25%)", "of Eminent Blocking (Fortify Block 4 30%)", "of Extreme Blocking (Fortify Block 5 35%)", "of Peerless Blocking (Fortify Block 6 40%)", "of Lifting (Fortify Carry Weight 1 +25)", "of Hauling (Fortify Carry Weight 2 +30)", "of Strength (Fortify Carry Weight 3 +35)", "of Brawn (Fortify Carry Weight 4 +40)", "of the Ox (Fortify Carry Weight 5 +45)", "of the Mammoth (Fortify Carry Weight 6 +50)", "of Minor Conjuration (Fortify Conjuration 1 12%)", "of Conjuration (Fortify Conjuration 2 15%)", "of Major Conjuration (Fortify Conjuration 3 17%)", "of Eminent Conjuration (Fortify Conjuration 4 20%)", "of Extreme Conjuration (Fortify Conjuration 5 22%)", "of Peerless Conjuration (Fortify Conjuration 6 25%)", "of Minor Destruction (Fortify Destruction 1 12%)", "of Destruction (Fortify Destruction 2 15%)", "of Major Destruction (Fortify Destruction 3 17%)", "of Eminent Destruction (Fortify Destruction 4 20%)", "of Extreme Destruction (Fortify Destruction 5 22%)", "of Peerless Destruction (Fortify Destruction 6 25%)", "of Remedy (Fortify Healing Rate 3 20%)", "of Mending (Fortify Healing Rate 4 30%)", "of Regeneration (Fortify Healing Rate 5 40%)", "of Revival (Fortify Healing Rate 6 50%)", "of Minor Health (Fortify Health 1 +20)", "of Health (Fortify Health 2 +30)", "of Major Health (Fortify Health 3 +40)", "of Eminent Health (Fortify Health 4 +50)", "of Extreme Health (Fortify Health 5 +60)", "of Peerless Health (Fortify Health 6 +70)", "of the Minor Knight (Fortify Heavy Armor 1 12%)", "of the Knight (Fortify Heavy Armor 2 15%)", "of the Major Knight (Fortify Heavy Armor 3 17%)", "of the Eminent Knight (Fortify Heavy Armor 4 20%)", "of the Extreme Knight (Fortify Heavy Armor 5 22%)", "of the Peerless Knight (Fortify Heavy Armor 6 25%)", "of Minor Illusion (Fortify Illusion 1 12%)", "of Illusion (Fortify Illusion 2 15%)", "of Major Illusion (Fortify Illusion 3 17%)", "of Eminent Illusion (Fortify Illusion 4 20%)", "of Extreme Illusion (Fortify Illusion 5 22%)", "of Peerless Illusion (Fortify Illusion 6 25%)", "of the Minor Squire (Fortify Light Armor 1 12%)", "of the Squire (Fortify Light Armor 2 15%)", "of the Major Squire (Fortify Light Armor 3 17%)", "of the Eminent Squire (Fortify Light Armor 4 20%)", "of the Extreme Squire (Fortify Light Armor 5 22%)", "of the Peerless Squire (Fortify Light Armor 6 25%)", "of Minor Magicka (Fortify Magicka 1 +20)", "of Magicka (Fortify Magicka 2 +30)", "of Major Magicka (Fortify Magicka 3 +40)", "of Eminent Magicka (Fortify Magicka 4 +50)", "of Extreme Magicka (Fortify Magicka 5 +60)", "of Peerless Magicka (Fortify Magicka 6 +70)", "of Recharging (Fortify Magicka Rate 3 40%)", "of Replenishing (Fortify Magicka Rate 4 60%)", "of Resurgence (Fortify Magicka Rate 5 80%)", "of Recovery (Fortify Magicka Rate 6 100%)", "of Minor Wielding (Fortify One-Handed 1 15%)", "of Wielding (Fortify One-Handed 2 20%)", "of Major Wielding (Fortify One-Handed 3 25%)", "of Eminent Wielding (Fortify One-Handed 4 30%)", "of Extreme Wielding (Fortify One-Handed 5 35%)", "of Peerless Wielding (Fortify One-Handed 6 40%)", "of Minor Archery (Fortify Archery 1 15%)", "of Archery (Fortify Archery 2 20%)", "of Major Archery (Fortify Archery 3 25%)", "of Eminent Archery (Fortify Archery 4 30%)", "of Extreme Archery (Fortify Archery 5 35%)", "of Peerless Archery (Fortify Archery 6 40%)", "of Minor Deft Hands (Fortify Pickpocket 1 15%)", "of Deft Hands (Fortify Pickpocket 2 20%)", "of Major Deft Hands (Fortify Pickpocket 3 25%)", "of Eminent Deft Hands (Fortify Pickpocket 4 30%)", "of Extreme Deft Hands (Fortify Pickpocket 5 35%)", "of Peerless Deft Hands (Fortify Pickpocket 6 40%)", "of Minor Smithing (Fortify Smithing 1 12%)", "of Smithing (Fortify Smithing 2 15%)", "of Major Smithing (Fortify Smithing 3 17%)", "of Eminent Smithing (Fortify Smithing 4 20%)", "of Extreme Smithing (Fortify Smithing 5 22%)", "of Peerless Smithing (Fortify Smithing 6 25%)", "of Minor Restoration (Fortify Restoration 1 12%)", "of Restoration (Fortify Restoration 2 15%)", "of Major Restoration (Fortify Restoration 3 17%)", "of Eminent Restoration (Fortify Restoration 4 20%)", "of Extreme Restoration (Fortify Restoration 5 22%)", "of Peerless Restoration (Fortify Restoration 6 25%)", "of Minor Sneaking (Fortify Sneak 1 15%)", "of Sneaking (Fortify Sneak 2 20%)", "of Major Sneaking (Fortify Sneak 3 25%)", "of Eminent Sneaking (Fortify Sneak 4 30%)", "of Extreme Sneaking (Fortify Sneak 5 35%)", "of Peerless Sneaking (Fortify Sneak 6 40%)", "of Minor Lockpicking (Fortify Lockpicking 1 15%)", "of Lockpicking (Fortify Lockpicking 2 20%)", "of Major Lockpicking (Fortify Lockpicking 3 25%)", "of Eminent Lockpicking (Fortify Lockpicking 4 30%)", "of Extreme Lockpicking (Fortify Lockpicking 5 35%)", "of Peerless Lockpicking (Fortify Lockpicking 6 40%)", "of Minor Haggling (Fortify Barter 1 12%)", "of Haggling (Fortify Barter 2 15%)", "of Major Haggling (Fortify Barter 3 17%)", "of Eminent Haggling (Fortify Barter 4 20%)", "of Extreme Haggling (Fortify Barter 5 22%)", "of Peerless Haggling (Fortify Barter 6 25%)", "of Minor Striking (Fortify Two-Handed 1 15%)", "of Striking (Fortify Two-Handed 2 20%)", "of Major Striking (Fortify Two-Handed 3 25%)", "of Extreme Striking (Fortify Two-Handed 5 35%)", "of Peerless Striking (Fortify Two-Handed 6 40%)", "of Disease Resistance (Resist Disease 50%)", "of Disease Immunity (Resist Disease 100%)", "of Waning Fire (Resist Fire 1 30%)", "of Dwindling Flames (Resist Fire 2 40%)", "of Flame Suppression (Resist Fire 3 50%)", "of Fire Abatement (Resist Fire 4 60%)", "of the Firewalker (Resist Fire 5 70%)", "of Waning Frost (Resist Frost 1 30%)", "of Dwindling Frost (Resist Frost 2 40%)", "of Frost Suppression (Resist Frost 3 50%)", "of Frost Abatement (Resist Frost 4 60%)", "of Warmth (Resist Frost 5 70%)", "of Poison Resistance (Resist Poison 50%)", "of Poison Immunity (Resist Poison 100%)", "of Waning Shock (Resist Shock 1 30%)", "of Dwindling Shock (Resist Shock 2 40%)", "of Shock Suppression (Resist Shock 3 50%)", "of Shock Abatement (Resist Shock 4 60%)", "of Grounding (Resist Shock 5 70%)", "of Resist Magic (Resist Magic 1 10%)", "of Dwindling Magic (Resist Magic 2 15%)", "of Magic Suppression (Resist Magic 3 17%)", "of Magic Abatement (Resist Magic 4 20%)", "of Nullification (Resist Magic 5 22%)", "of Waterbreathing", "of Muffling" };
            int eIndex = rnd.Next(enchantments.Length);
            string[] items = { "Amulet", "Abacus", "Arcane Focus", "Backpack", "Bagpipes", "Ball Bearings", "Barding", "Barrel", "Basket", "Bedroll", "Bell", "Ring", "Necklace", "Cloth", "Walking Stick", "Watch", "Potion", "Elixir", "Boots", "Breastplate", "Bottle", "Book", "Bucket", "Candle" };
            int iIndex = rnd.Next(items.Length);
            string loot = items[iIndex] + " " + enchantments[eIndex];
            itemBox.Text = loot.ToString();
        }

        private void npcButton_Click(object sender, EventArgs e)
        {
            Random pc = new Random();
            string[] Firstname = { "Jon", "Jana", "Dragomir", "Wes", "Arron", "Lena", "Flyn", "Granit", "Yanis", "Eva", "Idris", "Gwen", "Devon", "Esemir", "Axel", "Mira", "Darian", "Flo", "Issi", "Dafne", "Hazel", "Roisin", "Ruben", "Seth", "Caelin", "Orla", "Pria", "Rowan", "Olaf", "Trent", "Marek", "Roik", "Bertran", "Tormen", "Zak", "Ganut", "Stron", "Pelin", "Oswin", "Ferlik", "Jasmin", "Drezz", "Coromet", "Grunwila", "Rafina", "Draxon", "Alkon", "Fleck", "Jin", "Dagmar", "Joris", "Lavin", "Tegen", "Larissa", "Lorilee", "Fenwick", "Caradoc", "Toady", "Gea", "Aspen", "Leandra", "Colyn", "Agnes", "Seldon", "Clifton", "Gibon", "Lazar", "Fel", "Gerald", "Ovina", "Vondel", "Gideon", "Drayton", "Owyn", "Brindel", "Una", "Uma", "Benn", "Delryn", "Mia", "Nora", "Pip", "Teia", "Osbalt", "Robyn", "Perritt", "Eggard", "Merit", "Philomena", "Jaysee", "Cameron", "Nikki", "Bryn", "Ida", "Oriel", "Alina", "Odo", "Dezre", "Petronia", "Bilko", "Eva", "Finigan", "Helois", "Loris", "Brigitte", "Theobald", "Wilhelm", "Neferi", "Jilomar", "Botherin", "Larissa", "Dillon", "Remy", "Rex", "Gelda", "Jamila", "Eldon", "Greta", "Lilly", "Hattie", "Clarence", "Gus", "Chester", "Oliver", "Ezra", "Abelia", "Bertie", "Grint", "Cyril", "Alba", "Abner", "Roscoe", "Wilber", "Cornel", "Osgood", "Hector", "Cruilla", "Elric", "Mildred", "Wexton", "Linus", "Wendel", "Clem(ence)", "Percy", "Rufus", "Hal", "Harvey", "Megan", "Jen", "Prunila", "Loretta", "Garret", "Faizel", "Rosalind", "Cyra", "Jasper", "Drusilla", "Carrick", "Roncan", "Titiana", "Tethren", "Berrick", "Mylo", "Elias", "Gael", "Layla", "Nanna", "Hubert", "Avona", "Gray", "Thinden", "Derrian", "Willy", "Timrin", "Elrod", "Jesper", "Berevan", "Grenley", "Solomon", "Axton", "Erel", "Tina", "Bella", "Krag", "Cleris", "Vixen", "Gladwin", "Languedoc", "Beyla", "Ilsa", "Bolo", "Bea", "Roni", "Pippa", "Scarsen", "Yunis", "Quentin", "Phoebe", "Delewin", "Wally", "Otis", "Tigga", "Reece", "Specky", "Peggy", "Hamil", "Bethel", "Aldric" };
            string[] Epithet = { "Black", "White", "Gold", "Silver", "Bronze", "Copper", "Steel", "Iron", "Rock", "Amber", "Red", "Rose", "Green", "Grey", "Shadow", "Dark", "Dusk", "Dawn", "Bright", "Light", "Sun", "Moon", "Star", "Storm", "Cloud", "Dream", "Fire", "Wood", "Oak", "Strong", "Hard", "Stout", "Arrow", "Shield", "Sparrow", "True", "Swift", "Deft", "Nimble", "Quick", "Fleet", "Hawk", "Lion", "Bear", "Tiger", "Griffon", "Dragon", "Snake", "Cobra", "Eagle", "Stag", "Deer", "Ox", "Bison", "Wolf", "Jackal", "Dog", "Rat", "Lynx", "Owl", "Panther", "Crab", "Kraken", "Trout", "River", "Sea", "Swan", "Duck", "Goose", "Sand", "Castle", "Cliff", "Crag", "Bluff", "Beach", "Good", "Fair", "Blade", "Axe", "Hammer", "Wagon", "Leather", "Loom", "Cart", "Bull", "Plough", "Wheel", "Little", "Great", "Dew", "Crow", "Raven", "Ruby", "Jet", "Sky", "Jade", "Gem", "Diamond", "Flame", "Bone", "Teal", "Frost", "Ever", "Right", "Scarlet", "Night", "Day", "Lone", "Ivy", "Smoke", "Sable", "Deep", "Sharp", "Bitter", "Ginger", "Sweet", "Rolling", "Smooth", "Acorn", "Speckle", "Cloven", "Winter", "Spring", "Autumn", "Summer", "Lily", "Beetle", "Brazen", "Slow", "Battle", "Dry", "Cherry", "Wild", "Dune", "Spotted", "Cold", "Death", "Scar", "Mild", "War", "Thunder", "Merry", "Idle", "Cheese", "Rich", "Poor", "Rust", "Mean", "Joy", "Pearl", "Luck(y)", "Long", "Firm", "Rough", "Pale", "Savage", "June", "May", "Gentle", "Tall", "Top", "Bottom", "Mellow", "Short", "Fine", "Fortune", "Grave", "High", "Pink", "Glass", "Thrifty", "Drizzle", "Wool", "Tortoise", "Falcon", "Crown", "Arbour", "Anchor", "Dread", "Cleft", "Emerald", "Twinkle", "Bay", "Harpy", "Common", "Venom", "Coal", "Titan", "Bumble", "God", "Baggy", "Biege", "Ram", "Poppy", "Shatter", "Hound", "Scrawny", "Flea", "Birch", "Chamber", "Hairy", "Troll", "Rumble", "Spruce", "Poison", "Beacon", "Far", "Apple", "Blue", "Noble", "Lightning", "Cat", "Tide", "Ferret", "Skull", "Snow", "Loose", "Craven", "Riddle(s)", "Giant", "Sage", "Gorgon", "Timber", "Lumber", "Cradle", "Heron", "Tinder", "Wet", "Flint", "Needle", "Swallow", "Dire", "Pewter", "Brass", "Hill", "Plain", "Rye", "Wheat", "Soft", "Proud", "Rib", "Free", "Dour", "Opal", "Brandy", "Dandy", "Spirit", "Hoot", "Safe", "Shallow", "Knave", "Spider", "Rage", "Noon", "Boon", "Prime", "Eternal", "Pure", "Beryl", "Middle", "Blaze", "Fen", "Kings", "Quag", "Dung", "Desert", "Forest", "Filly", "Daisy", "Fir", "Willow", "Beech", "Pine", "Fury", "Heaven", "Lime", "Orchid", "Swamp", "Bog", "Aether", "Elm", "Rhyme", "Honey", "Marble", "Candle", "Wicker", "Hoarse", "Silent", "Limp", "Fiery", "Last", "Wheel", "Rabbit", "Wiggle", "Bug", "Cat", "Frog", "Viper", "Hornet", "Church", "Brick", "New", "Old", "Sly", "Razor", "Bold", "Fiery", "Wily", "Shy", "Vile", "Lazy", "Slumber", "Velvet", "Bracken", "Hay", "Stork", "Straw", "Ghost", "Grand", "Butter", "Tender", "Umber", "Frail", "Chestnut", "Glimmer", "Tin", "Pepper", "Salt", "Barley", "Ale", "Plum", "Ripe", "Brush", "Flaxen", "Even", "Lunar", "Coral", "Queens", "Feeble", "Tawny", "Gloom", "Doom", "Grim", "Bleak", "Sombre", "Chalk", "Slate", "Oyster", "Saffron", "Dappled", "Ash", "Lead", "Nettle", "Hoar", "Morn", "Under", "Heather", "Fat", "Broken", "Hell", "Brisk", "Drift", "Ample", "Lame", "Gout", "Yellow", "Throttle", "Damsel", "Adder", "Smelly", "Mink", "Ruin", "Kin", "Omen", "Woe", "Kind", "Slug", "Crystal", "Bristle", "Slip", "Crinkle", "Lavendar", "Lace", "Loyal", "Leal", "Cow", "Bluster", "Galley", "Rum", "Wrinkle", "Fable", "Silent", "Royal", "Dun", "Boar", "Fickle", "Knoll", "Air", "Moor", "Soot", "Roan", "Snug", "Cur", "Harrier", "Siren", "Cabbage", "Bent", "Bile", "Weasel", "Fey", "Spore", "Murky", "Tough", "Falcon", "Mountain", "Demon"};
            string[] Noun = { "hand", "finger", "fist", "tongue", "beard", "hair", "jaw", "glove", "haven", "dawn", "moon", "mount", "gaze", "cloak", "run", "sun", "tripper", "dancer", "soul", "flower", "blossom", "bringer", "dust", "quiver", "seeker", "giver", "strike", "cutter", "heart", "blood", "helm", "anvil", "smith", "bearer", "flash", "stone", "shield", "spear", "foot", "notch", "ford", "wind", "mane", "rider", "rake", "bane", "slayer", "skin", "killer", "born", "walker", "hunt(er)", "tamer", "stalker", "creek", "mouth", "tooth", "tail", "hide", "flight", "claw", "eater", "maid", "nose", "bank", "breeze", "song", "feather", "wing", "shifter", "stormer", "raider", "reaver", "breaker", "comber", "berry", "brook", "forge(r)", "storm", "wind", "chaser", "saddle", "weaver", "swain", "chest", "puller", "wright", "rider", "star", "drop", "caller", "roost", "mine(r)", "tempest", "deck", "tusk", "tree", "farmer", "fork", "field", "feather", "whiskers", "lock", "guard", "mark", "warden", "watcher", "ranger", "bridge", "ridge", "valley", "gorge", "thistle", "thorn", "petal", "meadow", "boulder", "pebble", "bush", "bough", "trunk", "vale", "leaf", "grove", "orchard", "bank", "boots", "belt", "sack", "pack", "fell", "falls", "dove", "fox", "vole", "paw", "maw", "nape", "jape", "song", "clap", "harp", "calm", "bread", "larder", "plate", "bucket", "pouch", "pocket", "locket", "charm", "rope", "law", "scale", "snout", "beak", "bird", "gale", "rush", "reed", "lily", "pond", "lake", "beam", "ray", "well", "gate", "wall", "coat", "shins", "palm", "shears", "shorn", "shell", "dive", "steward", "lark", "bay", "shore", "coast", "hoarder", "toes", "kite", "begotten", "heir", "bride", "groom", "scion", "child", "chosen", "britches", "breetches", "rod", "cock", "brood", "breath", "scribe", "home", "hall", "key", "purse", "spawn", "mage", "scythe", "chalice", "keeper", "flung", "house", "staff", "crest", "catcher", "fetcher", "fighter", "skipper", "pecker", "clasp", "button", "cottage", "worth", "reckon(ing)", "wine", "spell", "trader", "worker", "lit", "loft", "spark", "peg", "flurry", "dart", "drifter", "whisper(er)", "ring", "brace", "shepherd", "sceptre", "grain", "sheaf", "pride", "antler", "tickler", "mason", "bound", "chain", "barn", "buck", "horn", "cryer", "harbour", "port", "trap(per)", "jack", "lust", "riser", "lord", "cut", "glade", "crack", "gift", "camp", "town", "moor", "mire", "nag", "sweeper", "mare", "steed", "whip(per)", "bell(s)", "snapper", "warbler", "craft", "harness", "forge(d)", "sent", "scent", "musk", "shiver", "shudder", "bat", "cudgel", "peddler", "lyre", "limb", "stick", "horse", "throat", "pad", "shoe", "bolt", "arch", "barrow", "burrow", "worm", "stain", "lick", "fetcher", "prey", "nest", "mouse", "temple", "spire", "tower", "hook", "pike", "crook", "bolt", "guise", "kiss(ed)", "wart", "toad", "newt", "fleece", "hearth", "blaze", "sigil", "bale", "mound", "crescent", "cup(s)", "bud", "brow", "gable", "head", "knife", "spoon", "pot", "shaker", "barrel", "dipper", "brew", "vine", "thatch", "cape", "glory", "flood", "rain", "reign", "reins", "bridle", "driver", "sayer", "guts", "blizzard", "fellow", "cheeks", "jacket", "diver", "flume", "plume", "grave", "tomb", "garden", "frost", "singer", "root", "frond", "harvest", "blade", "throne", "bee", "swarm", "flock", "herd", "rot", "belly", "weed", "sting", "bite", "turf", "flayer", "tracker", "seer", "gazer", "wanderer", "voyager", "squisher", "fang", "noose", "knot", "moss", "bark", "gauntlet", "squire", "knight", "halter", "bow", "shank", "runner", "rump", "joust", "destroyer", "lance", "scabbard", "holm", "slippers", "strider", "borne", "jaunt", "cowl", "hood", "hat", "howl", "talons", "conch", "patch", "dirk", "bladder", "creek", "sworn", "sniffer", "moat", "mutton", "flare", "lair", "scorned"};
            int fIndex = pc.Next(Firstname.Length);
            int eIndex = pc.Next(Epithet.Length);
            int nIndex = pc.Next(Noun.Length);
            string npcBaby = Firstname[fIndex] + " " + Epithet[eIndex] + Noun[nIndex];
            npcBox.Text = npcBaby.ToString();
        }

        private void townButton_Click(object sender, EventArgs e)
        {
            Random town = new Random();
            string[] Place = { "Deep Run", "Scunthorpe", "Carmarthen", "Falmouth", "Maiden’s Eye", "Frostmount", "Anglesey", "Goldfleece", "Nas Laed", "Yorel", "Underwent", "Svendborg", "Veritas", "Waterdown", "Silent Stone", "Luxor", "Saltwreath", "Zapatosa", "Aurich", "Nicosa", "Sunfall", "Tuskenvale", "Nox", "Grafburg", "Lingen", "Wolfsburg", "Chambery", "Oakcross", "Greyridge", "Mountbank", "Weakward", "Princeton", "Keyside", "Hackney", "Barking", "Soldaburg", "Kingston", "Blackmont", "Redbridge", "Penrith", "Camden", "Hollowgrave", "Kulungaz", "Gorkazur", "Omura", "Uradun", "Krazurag", "Domadun", "Murkora", "Bashkor", "Hadari", "Ogun-Ur", "Brorudun", "Vorkun", "Ozryn", "Dreck", "Kurpot", "Baki-Da", "Yldstead", "Stenjern", "Aescamyr", "Imyr", "Certare", "Asimi", "Enia", "Aetrom", "Luthyia", "Adruil", "Anngeal", "Diae", "Ennervae", "Soralia", "Calaren", "Syrena", "Saida", "Zenica", "Cometa", "Lorentia", "Padserae", "Zuhause", "Malunbag", "Starky", "Valence", "Almyst", "Zephir" };
            int pIndex = town.Next(Place.Length);
            string camp = Place[pIndex];
            townBox.Text = camp.ToString();
        }

        private void monsterBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void npcBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void townBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
