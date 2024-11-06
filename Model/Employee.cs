using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraAPI.Model
{
    [Table("tbemployer")]
    public class Employee
    {

        public int id { get; private set; }

        public string name { get; private set; }

        public int age { get; private set; }

        public string photo { get; private set; }

        public Employee( int id, string name, int age, string photo )
        {
            this.id = id;
          this.name = name ?? throw new ArgumentNullException(nameof(name));
          this.age = age;
          this.photo = photo;
        }
    }
}
