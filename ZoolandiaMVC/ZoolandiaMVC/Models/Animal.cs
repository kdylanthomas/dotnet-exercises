using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZoolandiaMVC.Models
{
    public class Animal
    {
        public int IdAnimal { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int IdHabitat { get; set; }
        public int IdGenus { get; set; }
        public int IdSpecies { get; set; }
    }
}