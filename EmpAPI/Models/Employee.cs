using System.ComponentModel.DataAnnotations;

namespace EmpAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Address { get; set; }
    }
}
