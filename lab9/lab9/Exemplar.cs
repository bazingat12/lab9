using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Exemplar 
    {
        private int _ExemplarID;
        private DateTime _Date;
        private string _Publisher;

        public int ExemplarID
        { get
            {
                return _ExemplarID;
            }
                set
            {
                if (value > 0)
                    _ExemplarID = value;
                else
                    Console.WriteLine("Неподустимый код экземпляра");
            }
                }
        public Book Book1
        { get; set; }
        public DateTime Date
        {
            get
            {
                if (_Date == null)
                    throw new Exception("Укажите дату печати");
                else
                    return _Date;
            }
                set
            {
                _Date = value;
            }
                }
        public string Publisher
        {
            get
            {
                if (String.IsNullOrEmpty(_Publisher))
                    throw new Exception("Издатель не может быть пустым");
                else
                    return _Publisher;
            }
                set
            {
                _Publisher = value;
            }
                }
        public Exemplar(int ExemplarID, Book Book1, DateTime Date, string Publisher)
        {
            this.ExemplarID = ExemplarID;
            this.Book1 = Book1;
            this.Date = Date;
            this.Publisher = Publisher;
        }
        public virtual void Info()
        {
            Book1.Info();
            Console.WriteLine("Информация о экземпляре: ");
            Console.WriteLine("    Код экземпляра: {0}\n    Дата печати:    {1}\n    Издательство: {2}",
                ExemplarID, Date, Publisher);
        }
    }
}
