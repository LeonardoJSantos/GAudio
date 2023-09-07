using GAudio.Models;


namespace GAudio.Models
{
    public class Function
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Sector Sector { get; set; }
        public ICollection<Employee> employees { get; set; } = new List<Employee>();

        public Function()
        {
        }
        public Function(string id, string name, Sector sector)
        {
            Id = id;
            Name = name;
            Sector = sector;
        }
        public void AddEmploees(Employee employee)
        {
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }
    }
}