using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstateExam
{
    class ListPerson
    {
        public string Name { get; set; }
        public List<Person> Persons = new List<Person>();

        public void Display()
        {
            Console.WriteLine("\nКартотека:");
            Console.WriteLine("----------------------");
            if (Persons.Count == 0)
                Console.WriteLine("\n> В данной картотеке нету карточек!");
            else
            {
                foreach (Person p in Persons)
                    Console.WriteLine(p);
            }                
        }

        public void AddPerson(Person p)
        {
            Persons.Add(p);
        }

        public void DelPerson(string name)
        {
            bool success = false;
            foreach(Person p in Persons)
            {
                if(p.Name == name)
                {
                    success = true;
                    Persons.Remove(p);
                    Console.WriteLine("Удаление успешно завершено!");
                    break;
                }
            }
            if (!success)
                Console.WriteLine("\n> Фамилия не найдена!");
        }

        public void DisplayPersonForName(string name)
        {
            bool success = false;
            foreach (Person p in Persons)
            {
                if (p.Name == name)
                {
                    success = true;
                    Console.WriteLine("\nПерсона обнаружена:");
                    Console.WriteLine(p);
                    break;
                }
            }
            if (!success)
                Console.WriteLine("\n> Фамилия не найдена!");
        }

        public void FindPersonForZodiac(string name)
        {
            bool success = false;
            foreach (Person p in Persons)
            {
                if (p.Name == name)
                {
                    success = true;
                    if ((p.Month == "март" && p.Number > 20 && p.Number < 32) || (p.Month == "апрель" && p.Number < 21))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Овен}");
                    }
                    else if ((p.Month == "апрель" && p.Number > 20 && p.Number < 31) || (p.Month == "май" && p.Number < 21))
                    {
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Телец}");
                    }
                    else if ((p.Month == "май" && p.Number > 20 && p.Number < 32) || (p.Month == "июнь" && p.Number < 21))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Близнецы}");
                    }
                    else if ((p.Month == "июнь" && p.Number > 20 && p.Number < 31) || (p.Month == "июль" && p.Number < 23))
                    {
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Рак}");
                    }                    
                    else if ((p.Month == "июль" && p.Number > 22 && p.Number < 32) || (p.Month == "август" && p.Number < 23))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Лев}");
                    }
                    else if ((p.Month == "август" && p.Number > 22 && p.Number < 32) || (p.Month == "сентябрь" && p.Number < 24))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Дева}");
                    }
                    else if ((p.Month == "сентябрь" && p.Number > 23 && p.Number < 31) || (p.Month == "октябрь" && p.Number < 24))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Весы}");
                    }
                    else if ((p.Month == "октябрь" && p.Number > 23 && p.Number < 32) || (p.Month == "ноябрь" && p.Number < 22))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Скорпион}");
                    }
                    else if ((p.Month == "ноябрь" && p.Number > 21 && p.Number < 31) || (p.Month == "декабрь" && p.Number < 22))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Стрелец}");
                    }
                    else if ((p.Month == "декабрь" && p.Number > 21 && p.Number < 32) || (p.Month == "январь" && p.Number < 20))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Козерог}");
                    }
                    else if ((p.Month == "январь" && p.Number > 19 && p.Number < 32) || (p.Month == "февраль" && p.Number < 19))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Водолей}");
                    }
                    else if ((p.Month == "февраль" && p.Number > 18 && p.Number < 29) || (p.Month == "март" && p.Number < 21))
                    {                        
                        Console.WriteLine($"Знак зодиака персоны с фамилией {name}: {Zod.Рыбы}");
                    }
                    else
                    {
                        Console.WriteLine($"\n> В картотеке персоны с фамилией {name} некорректная информация о дате рождения!");
                    }
                }
            }
            if(!success)
            {
                Console.WriteLine($"\n> Фамилия {name} отсутствует в картотеке!");
            }
        }
    }
}
