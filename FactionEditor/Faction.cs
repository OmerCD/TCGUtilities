using MongoCRUD.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactionEditor
{
    public class Faction : DbObject
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
