using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Rab:Person
    {
        protected int oklad;
        protected int procant;

        public Rab()
        {

        }

        public Rab(string soname, string name, int day, int daymec, int daygod, char pol, int oklad,int procent) : base(soname,name,day,daymec,daygod,pol)
        {
            this.oklad = oklad;
            this.procant = procent;

        }
       

        public int Oklad
        {
            get { return oklad; }
            set { oklad = value; }
        }
        public int Procant
        {
            get { return procant; }
            set { procant = value; }
        }

         virtual protected double metforzp()
        {
            return  ((double) (Oklad * Procant) / 100) + Oklad ;
        }

        public override void WriteDannih()
        {
            base.WriteDannih();
            Console.WriteLine("Введите % премии: ");
            Procant = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите оклад: ");
            Oklad = Convert.ToInt32(Console.ReadLine());
        }

        public override void WiWodDannix()
        {
            base.WiWodDannix();
            Console.WriteLine($"зарплата= {metforzp()}");
        }
    }
}
