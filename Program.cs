

using AppLista.controllers;
using AppLista.models;

namespace AppLista; // Note: actual namespace depends on the project name.

    public class Program
    {
      public static void Main(string[] args)
      {

        PersonController obj = new();
        int opcion = 0;

        do {
            Console.WriteLine("** menu principal **" +
                "\n 1. Agregar persona" +
                "\n 2. Mostrar la lista " +
                "\n 3. Salir" +
                "\n elige tu opcion :)");

            var data = Console.ReadLine();
            if(data != null)
            {
                opcion = int.Parse(data);
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Escriba el id: ");
                    var inputId = Console.ReadLine();
                    Console.WriteLine("Escriba el nombre: ");
                    var inputName = Console.ReadLine();
                    Console.WriteLine("Escriba la edad: ");
                    var inputAge = Console.ReadLine();

                    if (inputId != null && inputName !=null && inputAge != null)
                    {
                        obj.addPerson(new Person(
                            int.Parse(inputId),
                            inputName.ToString(),
                            int.Parse(inputAge)
                            ));
                    }

                    break;

                    case 2:
                      Console.WriteLine(obj.showList());
                    break;


                case 3:
                    opcion = 3;
                    break;
                    default:
                    Console.WriteLine("elige una opcion del menu");
                    break;
            }

        }while (opcion != 3);
      }
    }
