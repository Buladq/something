using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(soname: "Зас", name: "Виктор", day: 01, daymec: 04, daygod: 2001, pol: 'м');
            person.WiWodDannix();
            Console.WriteLine("Введите кол-во пользователей");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Rab [] rabochii= new Rab[x];
            for (int i = 0; i <rabochii.Length; i++)
            {
                rabochii[i] = new Rab();
                rabochii[i].WriteDannih();
                
            }

            foreach (var item in rabochii)
            {
                item.WiWodDannix();
            }

          














        }
        
    }
}
