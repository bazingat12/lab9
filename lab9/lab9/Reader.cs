﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    abstract class Reader: IReader
    {
        private int _ReaderID;
        private string _Surname;
        private string _Name;
        private string _Patronumic;
        private string _Gender;
        private string _Phone;
        private double _st;

        public int ReaderID
        {
            get
            {
                return _ReaderID;
            }
          set
            {
                if (value > 0)
                    _ReaderID = value;
                else
                    Console.WriteLine("Неподустимый код читателя");
            }
        }

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
                if (String.IsNullOrEmpty(_Patronumic))
                    throw new Exception("Отчество не может быть пустым");
                else
                    return _Patronumic;
            }
            set
            {
                _Patronumic = value;
            }
        }

        public string Gender
        {
            get
            {
                if (String.IsNullOrEmpty(_Gender))
                    throw new Exception("Пол не может быть пустым");
                else
                    return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
        public string Phone
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
                _Phone = value;
            }

            get
            {
                if (String.IsNullOrEmpty(_Phone))
                    throw new Exception(" ");
                else
                    return _Phone;
            }
        }
        public virtual double st
        { get; set; }
        public Reader(int ReaderID, string Surname, string Name, string Patronymic, string Gender, string Phone)
        {
            this.ReaderID = ReaderID;
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
                    ReaderID, Surname, Name, Patronymic, Gender, Phone, st * 100);
            }
    }
}
