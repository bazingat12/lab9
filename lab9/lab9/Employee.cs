using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Employee 
    {
        private int _EmployeeID;
        private string _Surname;
        private string _Name;
        private string _Patronymic;
        private string _INN;
        private byte _Experience;

        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
                set
            {
                if (value > 0)
                    _EmployeeID = value;
                else
                    Console.WriteLine("Неподустимый код сотрудника");
            }
                }
        public Position EmployeePosition
        { get; set; }

        public string Surname
        {
            get
            {
                if (String.IsNullOrEmpty(_Surname))
                    throw new Exception("Фамилия не может быть пустой");
                else
                    return _Surname;
            }
                set
            {
                _Surname = value;
            }
        }
        public string Name
        {
            get
            {
                if (String.IsNullOrEmpty(_Name))
                    throw new Exception("Имя не может быть пустым");
                else
                    return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string Patronymic
        {
            get
            {
                if (String.IsNullOrEmpty(_Patronymic))
                    throw new Exception("Отчество не может быть пустым");
                else
                    return _Patronymic;
            }
            set
            {
                _Patronymic = value;
            }
        }

        public string INN
        {
            set
            {
                if (value.Count() != 11)
                    return;
                foreach (char ch in value)
                {
                    if (!Char.IsDigit(ch))
                        return;
                }
                _INN = value;
            }

            get
            {
                if (String.IsNullOrEmpty(_INN))
                    throw new Exception(" ");
                else
                    return _INN;
            }
        }

        public byte Experience
        {
            get
            {
                return _Experience;
            }
                set
            {
                if (value >= 0)
                    _Experience = value;
                else
                    Console.WriteLine("Неподустимый стаж работы");
            }
        }

        public Employee (int EmployeeID, Position EmployeePosition, string Surname, string Name, string Patronymic, string INN, byte Experience, string City, string Street, string home1)
        {
            this.EmployeeID = EmployeeID;
            this.EmployeePosition = EmployeePosition;
            this.Surname = Surname;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.INN = INN;
            this.Experience = Experience;
        }
        public virtual void Info()
        {
            Console.WriteLine("Сотрудник: ");
            Console.WriteLine("    Код сотрудника: {0}\n    Фамилия: {1}\n    Имя: {2}\n    Отчество: "
                + "{3}\n    ИНН: {4}\n    Стаж работы: {5}\n",
                EmployeeID, Surname, Name, Patronymic, INN, Experience);
               EmployeePosition.Info();
        }
    }
    
}
