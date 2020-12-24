using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstateExam
{
    enum Zod { Овен, Телец, Близнецы, Рак, Лев, Дева, Весы, Скорпион, Стрелец, Козерог, Водолей, Рыбы}

    class Person : Date
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"\nФамилия:{Name}\nДата рождения:\nЧисло: {Number}\nМесяц: {Month}\nГод: {Year}";
        }
    }
}
