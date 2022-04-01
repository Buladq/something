using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Person
    {
        protected string soname;
        protected string name;
        protected  int day;
        protected int daymec;
        protected int daygod;
        protected char pol;

        public Person()
        {

        }

        public Person(string soname, string name, int day, int daymec, int daygod, char pol)
        {
            this.soname = soname;
            this.name = name;
            this.day = day;
            this.daymec = daymec;
            this.daygod = daygod;
            this.pol = pol;

            if (pol == 'м' || pol == 'ж')
            {
                this.pol = pol;
            }
            else
            {
                throw new Exception("Неверный формат пола!");


            }
        }

        public string Soname
        {
            get { return soname; }
            set { soname = value; }
        }

        public string Name
        {
            get { return name; }
                set { name = value; }

        }

        protected char Pol
        {
            get { return pol; }
            set {
                if (value == 'м' || value == 'ж')
                {
                    pol = value;
                }
                else
                {
                    throw new Exception("Неверный формат пола!");
                }
                }
 }

       public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Daymec
        {
            get { return daymec; }
            set { daymec = value; }
        }

        public int Daygod
        {
            get { return daygod; }
            set { daygod = value; }
        }

       

        public virtual void WriteDannih()
        {
            Console.WriteLine("Введите имя: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите фамилию: ");
            Soname= Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите пол: ");
            Pol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите день рождения: ");
            Day = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения: ");
            Daymec = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите год рождения: ");
            Daygod = Convert.ToInt16(Console.ReadLine());

        }
        protected int Birghday()
        {

            
            DateTime dateTime = DateTime.Now;
            int nowgod = dateTime.Year;
            int nowmonth = dateTime.Month;
            int nowday = dateTime.Day;
            int Pyesr = nowgod - Daygod;
            int p1 = nowmonth - Daymec;
            int p2 = nowday - Day;
            
            if (p2 < 0)
            {
                p1--;
            }
            
            if (p1 < 0)
            {
                Pyesr--;
            }



            return Pyesr;







            //грубая и неверная форма,т.к. имеются високосные  года
            //int[]brth=new int[3];
            //brth[0] = Daygod;
            //brth[1] = Daymec;
            //brth[2]=Day;
            //DateTime dateTime = DateTime.Now;
            //DateTime dateTime1 = new DateTime(Daygod , Daymec, Day);
            //TimeSpan timeSpan = dateTime - dateTime1;

            //return timeSpan.Days / 365; 




        }

        public virtual void WiWodDannix()
        {
            int bb=Birghday();
           
            Console.WriteLine($"имя: {Name}, фамилия:{Soname}, пол:{Pol}, полных лет: {bb}  ");
        }

        
    }
}
