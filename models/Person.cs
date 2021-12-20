
namespace AppLista.models
{
    internal class Person
    {
        public Person(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
