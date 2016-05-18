using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZoolandiaMVC.ViewModels
{
    public class AnimalDetailViewModel
    {
        public int IdAnimal { get; set; }
        public int IdHabitat { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string HabitatName { get; set; }
    }
}