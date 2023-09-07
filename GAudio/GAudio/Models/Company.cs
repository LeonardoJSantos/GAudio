using GAudio.Models.Enums;
using GAudio.Models.ViewModels;
using System.Collections.Generic;
namespace GAudio.Models
{

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cnpj { get; set; }

        public ICollection<Unit> Units { get; set; } = new List<Unit>();


        public Company()
        {
        }

        public Company(int id, string name, int cnpj)
        {
            Id = id;
            Name = name;
            Cnpj = cnpj;
        }

        public void AddUnit(Unit unit)
        {
            Units.Add(unit);
        }
        public void RemoveUnit(Unit unit)
        {
            Units.Remove(unit);
        }

    }
}