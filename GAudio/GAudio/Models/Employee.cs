using GAudio.Models.ViewModels;
namespace GAudio.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birdhday { get; set; } = DateTime.Now;
        public DateTime Admission { get; set; } = new DateTime();
        public Function Function { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, DateTime birdhday, DateTime admission, Function function)
        {
            Id = id;
            Name = name;
            Birdhday = birdhday;
            Admission = admission;
            Function = function;
        }
    }
}
