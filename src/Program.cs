using System;
using System.Collections.Generic;
using System.IO;
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

        class PlanControl
        {
            public Subject[] subjects;



            public void SortPlan()
            {
                subjects = subjects.OrderBy(s => s.term).ThenBy(s => s.name).ToArray();
                
            }

            public void SaveFile(string filePath)
            {
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    foreach (Subject subject in subjects)
                    {
                        file.WriteLine($"Название: {subject.name}, Фамилия преподавателя: {subject.SurnameTeacher}, Семестр: {subject.term}");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите количество значений: ");
                int size = Int32.Parse(Console.ReadLine());
                 if (size==0 || size <0)
                    {
                    Console.WriteLine("Введите число боьше 0");
                }

                PlanControl planControl = new PlanControl();
                planControl.subjects = new Subject[size];

                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"Введите {i + 1} значение:");
                    Console.Write("Название предмета: ");
                    string name = Console.ReadLine();
                    Console.Write("Фамилия преподавателя: ");
                    string SurnameTeacher = Console.ReadLine();
                    try
                    {
                        Console.Write("Семестр: ");
                        int term = Int32.Parse(Console.ReadLine());
                        if (term == 0 || term < 0)
                        {
                            Console.WriteLine("Введите число боьше 0");
                        }
                        planControl.subjects[i] = new Subject 
                        { name = name, SurnameTeacher = SurnameTeacher, term = term };
                    }
                    catch
                    {
                        Console.WriteLine("Введите целое число");
                    }

                }


                planControl.SortPlan();
                planControl.SaveFile("Subject.txt");

                Console.WriteLine("Отсортированный массив сохранен в файл");
            }
            catch
            {

                Console.WriteLine("Введите целое число");
            }
        }
    }
}
