using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Flower
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Flower (string T, string D)
        { 
            Title = T; Description = D;
        }
        public void Show () 
        {
            Console.WriteLine($"Цветочек: Название: {Title}, Описание: {Description}");
        }
    }
    public class Garden
    {
        public string Adress { get; set; }
        public string Owner { get; set; }
        public List<Flower> flowers = new List<Flower>();

        public void ShowAll() 
        {
            Console.WriteLine($"Сад: Адрес: {Adress}, Владелец: {Owner}, Цветы: ");
            foreach (var flower in flowers)
            {
                flower.Show();
            }
        }
    }
}
