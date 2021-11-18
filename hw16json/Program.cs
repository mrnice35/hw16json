using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;//добавляем пространство имен Json

namespace hw16json
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = "{\"firstName\":\"Tom\",\"lastName\":\"Jackson\",\"gender\":\"male\",\"age\":29,\"online\":true,\"hobby\":[\"football\",\"reading\",\"swiming\"]}";// слышами экранируем строку
            Person person = JsonSerializer.Deserialize<Person>(jsonString);//экземпляр класса персон и вызываем класс JsonSerializer а затем метод Deserialize для преобразования строки в объект (в треугольных скобках ставим обобщенный тип Персон)
        }
    }
    class Person         //создаем класс с автосвойствамми
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public bool online { get; set; }
        public string[] hobby { get; set; }
    }
}
