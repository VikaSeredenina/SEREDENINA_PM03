using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        struct Subject //структура
        {
            public string name;
            public string SurnameTeacher;
            public int term;
        }

        class PlanControl //класс
        {
            private Subject[] subjects;

            public void CreatePlan(int size)
            {
               
                
            }


        }



        static void Main(string[] args)
        {
            Console.Write("Введите количество значений: ");
            int size = Int32.Parse(Console.ReadLine());

            PlanControl planControl = new PlanControl();
            
        }
    }
}
