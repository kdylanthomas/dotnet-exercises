using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZoolandiaMVC.ViewModels
{
    public class AnimalHabitatViewModel
    {
        public int IdAnimal { get; set; }
        public int IdHabitat { get; set; }
        public string Name { get; set; }
        public string HabitatName { get; set; }
        public int Age { get; set; }
        public List<AnimalDetailViewModel> Animal { get; set; }
    }
}