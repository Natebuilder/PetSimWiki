using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSimWiki.Data
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EggId { get; set; }
        public Egg Egg { get; set; }
    }
}
