using MongoCRUD.Interfaces;
using System.Collections.Generic;
using CardCreator.Enum;
using FactionEditor;

namespace CardCreator
{
    public class Card : DbObjectSD
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Keyword> Keywords { get; set; }
        public int HP { get; set; }
        public int STR { get; set; }
        public int Cost { get; set; }
        public int AP { get; set; }
        public Rarity Rarity { get; set; }
        public Faction Faction { get; set; }

        public Card(string name, string description, int hP, int sTR, int cost,int aP, Rarity rarity, Faction faction)
        {
            Name = name;
            Description = description;
            Keywords = new List<Keyword>();
            HP = hP;
            STR = sTR;
            Cost = cost;
            AP = aP;
            Rarity = rarity;
            Faction = faction;
        }
        public Card()
        {
            Keywords = new List<Keyword>();
        }
        public override string ToString()
        {
            return Name;
        }


    }
}
