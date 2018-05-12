using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class ReaderSimple : Reader
    {
        private string _Status;
        public string Status
        {
            get
            {
                if (String.IsNullOrEmpty(_Status))
                    throw new Exception("Статус не может быть пустым");
                else
                    return _Status;
            }
            set
            {
                _Status = value;
            }
        }

        public ReaderSimple(string Status, int ReaderID, string Surname, string Name, string Patronymic, string Gender, int Phone)  : base(ReaderID, Surname, Name, Patronymic, Gender, Phone)
        {
            this.Status = Status;
            st = 1.5;
        }

        public virtual void Info1()
        {
            Console.WriteLine("Информация об обычном читателе: ");
            base.Info();
            Console.WriteLine("    Код Читателя: {0}\n    Фамилия: {1}\n    Имя: {2}\n    Отчество: {3}\n    Пол: {4}\n    Телефон: {5}\n    Статус: {6}\n    Штраф: {7}%\n",
                ReaderID, Surname, Name, Patronymic, Gender, Phone, Status, st*100);
        }
    }
}
    

