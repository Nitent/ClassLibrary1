using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flower flower = new Flower("Роза", "Красные лепестки");
            Flower flower1 = new Flower("Ромашка", "Белые лепестки");
            Flower flower2 = new Flower("Рододендрон", "Светло-фиолетовые лепестки");

            Garden garden = new Garden();
            garden.Adress = "г Калыма, ул Севастополь, д 9, кв 71";
            garden.Owner = "Геннадий Альбертович";

            garden.flowers.Add(flower);
            garden.flowers.Add(flower1);
            garden.flowers.Add(flower2);

            garden.ShowAll();
            Console.ReadLine();
        }
    }
}
