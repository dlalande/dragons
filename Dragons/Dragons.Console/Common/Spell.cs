﻿using System.Collections.Generic;

namespace Dragons.Common
{
    public class Spell
    {
        public SpellType Type { get; set; }
        public string Description { get; set; }
        public int ManaCost { get; set; }

        public static List<Spell> AllSpells()
        {
            return new List<Spell>()
            {
                new Spell()
                {
                    Type = SpellType.Meditate, 
                    Description = "Quietly mediate to restore Mana.", 
                    ManaCost = 0
                },
                new Spell()
                {
                    Type = SpellType.Lightning, 
                    Description = "Strike a single cell with your standard lightning attack.", 
                    ManaCost = 5
                },
                new Spell()
                { 
                    Type = SpellType.FireBall, 
                    Description = "Singe a 2x2 region with an explosive charge.",
                    ManaCost =  20
                },
                new Spell()
                {
                    Type = SpellType.FireStorm,
                    Description = "Attacks across the entire column of your choice.",
                    ManaCost =  35
                },
                new Spell()
                { 
                    Type = SpellType.IceStrike, 
                    Description = "Attacks across the entire row of your choice.",
                    ManaCost =  35
                },
                new Spell()
                { 
                    Type = SpellType.DragonFury, 
                    Description = "Remaining alive dragons each lay waste to one randomly chosen 2x2 region.",
                    ManaCost =  60
                }
            };
        }
    }
}
