using AppLista.models;


namespace AppLista.controllers
{
    internal class PersonController
    {
        List<Person> listPerson = new ();

        public void addPerson(Person person)
        {
            if (person != null)
            {
                listPerson.Add (person);
            }
        }

        public string showList()
        {
            string text = "lista \n";
            foreach (Person person in listPerson)
            {
                text += "id: " + person.Id + "\n";
                text += "Nombre: " + person.Name + "\n";
                text += "Edad: " + person.Age + "\n";


            }

            return text;
        }
    }
}
