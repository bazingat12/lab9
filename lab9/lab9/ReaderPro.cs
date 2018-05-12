﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class ReaderPro : Reader
    {
        public string status { get; set; }

        public ReaderPro(string status, int ID_Reader, string Surname, string Name, string Patronymic, string Gender, int Phone)  : base (ID_Reader, Surname, Name, Patronymic, Gender, Phone)
        {
            this.status = status;
            st = 1;
        }

        public virtual void Info1()
        {
            Console.WriteLine("Информация о 'вип' читателе: ");
            Console.WriteLine("    Код Читателя: {0}\n    Фамилия: {1}\n    Имя: {2} \n    Отчество: {3}\n    Пол: {4}\n    Телефон: {5}\n    Статус: {6}\n    Штраф: {7}%\n",
                ID_Reader, Surname, Name, Patronymic, Gender, Phone, status, st*100);
        }
    }
}