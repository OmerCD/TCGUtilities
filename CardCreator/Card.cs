﻿using MongoCRUD.Interfaces;
using System.Collections.Generic;
using System.Text;
using CardCreator.Enum;
using FactionEditor;
using MongoCRUD;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace CardCreator
{
    public class Card : DbObjectSD
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HP { get; set; }
        public int STR { get; set; }
        public int Cost { get; set; }
        public int AP { get; set; }
        public Rarity Rarity { get; set; }
        public string FactionId { get; set; }
        public List<string> KeywordIds { get; set; }

        public Card(string name, string description, int hP, int sTR, int cost,int aP, Rarity rarity, string factionId)
        {
            Name = name;
            Description = description;
            KeywordIds = new List<string>();
            HP = hP;
            STR = sTR;
            Cost = cost;
            AP = aP;
            Rarity = rarity;
            FactionId = factionId;
        }
        public Card()
        {
            KeywordIds = new List<string>();
        }

        public List<Keyword> GetKeywords(Crud<Keyword> crudKeyword)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("{$or: [");


            foreach (var keywordId in KeywordIds)
            {
                var filterString = "{_id:\"" + keywordId + "\"},";
                stringBuilder.Append(filterString);
            }

            FilterDefinition<BsonDocument> filter = stringBuilder.ToString();
            return crudKeyword.GetAll(filter.ToBsonDocument());
        }
        public override string ToString()
        {
            return Name;
        }


    }
}
