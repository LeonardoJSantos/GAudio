using GAudio.Models;
using GAudio.Models.ViewModels;
namespace GAudio.Models.Enums
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cnpj { get; set; }
        public int Cnae { get; set; }
        public RiskDegree RiskDegree { get; set; }
        public ICollection<Sector> Sectors { get; set; } = new List<Sector>();
        public Company Company { get; set; }


        public Unit()
        {
        }

        public Unit(int id, string name, int cnpj, int cnae, RiskDegree riskDegree)
        {
            Id = id;
            Name = name;
            Cnpj = cnpj;
            Cnae = cnae;
            RiskDegree = riskDegree;
        }

        public void AddSector(Sector sector)
        {
            Sectors.Add(sector);
        }
        public void RemoveSector(Sector sector)
        {
            Sectors.Remove(sector);
        }
    }
}