using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There Traveler, I'm In Dire Need Of Help With The Beast In The Mines.");
            Console.WriteLine("I Believe IT Was A ");

            while (true)
            {
                Random rnd = new Random();
                string[] monster = { "Awakened Shrub","Baboon","Badger","Bat","Cat","Commoner","Crab","Deer","Eagle","Frog","Giant Fire Beetle","Goat","Hawk","Homunculus","Hyena","Jackal","Lemure","Lizard","Octopus","Owl","Quipper","Rat","Raven","Scorpion","Sea Horse","Shrieker","Spider","Vulture","Weasel","Bandit","Blood Hawk","Camel","Cultist","Flying Snake","Giant Crab","Giant Rat","Giant Weasel","Guard","Kobold","Mastiff","Merfolk","Mule","Noble","Poisonous Snake","Pony","Stirge","Tribal Warrior","Acolyte","Axe Beak","Blink Dog","Boar","Constrictor Snake","Draft Horse","Dretch","Elf","Drow","Elk","Flying Sword","Giant Badger","Giant Bat","Giant Centipede","Giant Frog","Giant Lizard","Giant Owl","Giant Poisonous Snake","Giant Wolf Spider","Goblin","Grimlock","Panther","Pseudodragon","Riding Horse","Skeleton","Sprite","Steam Mephit","Swarm of Bats","Swarm of Rats","Swarm of Ravens","Violet Fungus","Wolf","Zombie","Ape","Black bear","Cockatrice","Crocodile","Darkmantle","Dust Mephit","Giant Goat","Giant Sea Horse","Giant Wasp","Gnoll","Gnome","Gray Ooze","Hobgoblin","Ice Mephit","Lizardfolk","Magma Mephit","Magmin","Orc","Reef Shark","Rust Monster","Sahuagin","Satyr","Scout","Shadow","Swarm of Insects","Thug","Warhorse","Warhorse Skeleton","Worg","Animated Armor","Brass Dragon Wyrmling","Brown Bear","Bugbear","Copper Dragon Wyrmling","Death Dog","Dire Wolf","Dryad","Duergar","Ghoul","Giant Eagle","Giant Hyena","Giant Octopus","Giant Spider","Giant Toad","Giant Vulture","Harpy","Hippogriff","Imp","Lion","Quasit","Specter","Spy","Swarm of Quippers","Tiger","Ankheg","Awakened Tree","Azer","Bandit Captain","Berserker","Black Dragon Wyrmling","Bronze Dragon Wyrmling","Centaur","Cult Fanatic","Druid","Ettercap","Gargoyle","Gelatinous Cube","Ghast","Giant Boar","Giant Constrictor Snake","Giant Elk","Gibbering Mouther","Green Dragon Wyrmling","Grick","Griffon","Hunter Shark","Merrow","Mimic","Minotaur Skeleton","Ochre Jelly","Ogre","Ogre Zombie","Pegasus","Plesiosaurus","Polar Bear","Priest","Rhinoceros","Rug of Smothering","Saber-Toothed Tiger","Sea Hag","Silver Dragon Wyrmling","Swarm of Poisonous Snakes","Wererat","White Dragon Wyrmling","Will-o'-Wisp","Basilisk","Bearded Devil","Blue Dragon Wyrmling","Doppelganger","Giant Scorpion","Gold Dragon Wyrmling","Green Hag","Hell Hound","Killer Whale","Knight","Manticore","Minotaur","Mummy","Nightmare","Owlbear","Phase Spider","Veteran","Werewolf","Wight","Winter Wolf","Black Pudding","Chuul","Couatl","Elephant","Ettin","Ghost","Lamia","Red Dragon Wyrmling","Succubus","Incubus","Wereboar","Weretiger","Air Elemental","Barbed Devil","Bulette","Earth Elemental","Fire Elemental","Flesh Golem","Giant Crocodile","Giant Shark","Gladiator","Gorgon","Half-Red Dragon Veteran","Hill Giant","Night Hag","Otyugh","Roper","Salamander","Shambling Mound","Triceratops","Troll","Unicorn","Vampire Spawn","Water Elemental","Werebear","Wraith","Xorn","Chimera","Drider","Invisible Stalker","Mage","Mammoth","Medusa","Vrock","Wyvern","Young Brass Dragon","Young White Dragon","Giant Ape","Oni","Shield Guardian","Stone Giant","Young Black Dragon","Young Copper Dragon","Assassin","Chain Devil","Cloaker","Frost Giant","Hezrou","Hydra","Spirit Naga","Tyrannosaurus Rex","Young Bronze Dragon","Young Green Dragon","Bone Devil","Clay Golem","Cloud Giant","Fire Giant","Glabrezu","Treant","Young Blue Dragon","Young Silver Dragon","Aboleth","Deva","Guardian Naga","Stone Golem","Young Gold Dragon","Young Red Dragon","Behir","Djinni","Efreeti","Gynosphinx","Horned Devil","Remorhaz","Roc","Archmage","Erinyes","Adult Brass Dragon","Adult White Dragon","Nalfeshnee","Rakshasa","Storm Giant","Vampire","Adult Black Dragon","Adult Copper Dragon","Ice Devil","Adult Bronze Dragon","Adult Green Dragon","Mummy Lord","Purple Worm","Adult Blue Dragon","Adult Silver Dragon","Iron Golem","Marilith","Planetar","Adult Gold Dragon","Adult Red Dragon","Androsphinx","Dragon Turtle","Balor","Ancient Brass Dragon","Ancient White Dragon","Pit Fiend","Ancient Black Dragon","Ancient Copper Dragon","Lich","Solar","Ancient Bronze Dragon","Ancient Green Dragon","Ancient Blue Dragon","Ancient Silver Dragon","Kraken","Ancient Gold Dragon","Ancient Red Dragon","Tarrasque"};
                int mIndex = rnd.Next(monster.Length);

                Console.WriteLine(monster[mIndex]);

                while (true)
                {
                    Console.WriteLine("Some Those Killed My Whole Family");
                    Console.WriteLine("Would You Please Defeat Them For Me [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "N")
                        break;
                    if (answer == "Y")
                        return;

                }
            }
        }
    }
}
