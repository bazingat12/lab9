using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    abstract class Reader: IReader
    {
        public int ID_Reader
        { get; set; }
        public string Surname
        { get; set; }
        public string Name
        { get; set; }
        public string Patronymic
        { get; set; }
        public string Gender
        { get; set; }
        public int Phone
        { get; set; }
        public virtual double st
        { get; set; }
        public Reader(int ID_Reader, string Surname, string Name, string Patronymic, string Gender, int Phone)
        {
            this.ID_Reader = ID_Reader;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Gender = Gender;
            this.Phone = Phone;
        }
        public virtual void Info()
        {
            Console.WriteLine("Информация о читателе: ");
            Console.WriteLine("    Код Читателя: {0}\n    Фамилия: {1}\n    Имя: {2} \n    Отчество: {3}\n    Пол: {4}\n    Телефон: {5}\n    Штраф: {6}%\n",
                ID_Reader, Surname, Name, Patronymic, Gender, Phone,st*100);
        }
    }
}
