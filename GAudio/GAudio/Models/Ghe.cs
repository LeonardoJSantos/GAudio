using System.Collections.Generic;
using GAudio.Models;
using GAudio.Models.Enums;

namespace GAudio.Models
{
    public class Ghe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Sector> sectors { get; set; } = new List<Sector>();
        public Unit Unit { get; set; }
        public Ghe() { }





        public void AddSector(Sector sector)
        {
            sectors.Add(sector);
        }
        public void RemoveSector(Sector sector)
        {
            sectors.Remove(sector);
        }
    }
}