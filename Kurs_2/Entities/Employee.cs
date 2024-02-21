namespace Kurs_2.Entities
{
    public class Employee : EntityBase
    {
        public Employee() 
        {
        
        }
        public Employee(string name)
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName},";


    }
}
