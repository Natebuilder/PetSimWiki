using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSimWiki.Data
{
    public class Egg
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
