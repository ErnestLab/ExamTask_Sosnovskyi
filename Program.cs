using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstateExam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ListPerson lp = new ListPerson();
                /*Person p1 = new Person("Пупкин", 22, "сентябрь", 1971);
                Person p2 = new Person("Павлов", 2, "июль", 1984);
                Person p3 = new Person("Ковалев", 13, "январь", 1949);
                Person p4 = new Person("Сухачев", 8, "август", 1969);
                Person p5 = new Person("Петров", 31, "май", 1977);
                Person p6 = new Person("Козаков", 15, "декабрь", 1972);
                Person p7 = new Person("Леонидов", 4, "июль", 1978);
                Person p8 = new Person("Невзоров", 35, "декабрь", 1965);
                Person p9 = new Person("Носов", 10, "провандарь", 1970);
                Person p10 = new Person("Волков", 28, "апрель", 1974);*/

                lp.AddPerson(new Person() { Name = "Пупкин", Number = 22, Month = "сентябрь", Year = 1971 });
                lp.AddPerson(new Person() { Name = "Павлов", Number = 2, Month = "июль", Year = 1984 });
                lp.AddPerson(new Person() { Name = "Ковалев", Number = 13, Month = "январь", Year = 1949 });
                lp.AddPerson(new Person() { Name = "Сухачев", Number = 8, Month = "август", Year = 1969 });
                lp.AddPerson(new Person() { Name = "Петров", Number = 31, Month = "май", Year = 1977 });
                lp.AddPerson(new Person() { Name = "Козаков", Number = 15, Month = "декабрь", Year = 1972 });
                lp.AddPerson(new Person() { Name = "Леонидов", Number = 4, Month = "июль", Year = 1978 });
                lp.AddPerson(new Person() { Name = "Невзоров", Number = 35, Month = "декабрь", Year = 1965 });
                lp.AddPerson(new Person() { Name = "Носов", Number = 10, Month = "провандарь", Year = 1970 });
                lp.AddPerson(new Person() { Name = "Волков", Number = 28, Month = "апрель", Year = 1974 });

                lp.Display();
                Console.WriteLine("============================================================");

                lp.DisplayPersonForName("Леонидов");
                lp.DisplayPersonForName("Соколов");

                lp.DelPerson("Петров");
                lp.DelPerson("Уваров");

                Console.WriteLine();
                lp.FindPersonForZodiac("Павлов");
                lp.FindPersonForZodiac("Козаков");
                lp.FindPersonForZodiac("Носов");
                lp.FindPersonForZodiac("Невзоров");
                lp.FindPersonForZodiac("Резников");

                Console.WriteLine("\n\nFinish");
            }
            catch(SystemException se)
            {
                Console.WriteLine($"Системная ошибка: {se.Message}");
            }
            catch (Exception err)
            {
                Console.WriteLine($"Oшибка: {err.Message}");
            }
            catch
            {
                Console.WriteLine("Неизвестная ошибка");
            }
        }
    }
}
