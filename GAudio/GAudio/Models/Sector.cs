using System.Collections.Generic;
using GAudio.Models.ViewModels;
namespace GAudio.Models
{
    public class Sector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Function> functions { get; set; } = new List<Function>();
        public Ghe Ghe { get; set; }
        public Sector()
        {

        }



        public void AddFunction(Function function)
        {
            functions.Add(function);
        }
        public void RemoveFunction(Function function)
        {
            functions.Remove(function);
        }
    }
}