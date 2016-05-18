using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZoolandiaMVC.Models
{
    public class Habitat
    {
        public int IdHabitat { get; set; }
        public string Name { get; set; }
        public bool CurrentlyOpen { get; set; }
        public int IdHabitatType { get; set; }
        public int IdEmployee { get; set; }
    }
}