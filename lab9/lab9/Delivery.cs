using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Delivery
    {
        private int _DeliveryID;
        private DateTime _Date;

        public int DeliveryID
        {
            get
            {
                return _DeliveryID;
            }
            set
            {
                if (value > 0)
                    _DeliveryID = value;
                else
                    Console.WriteLine("Неподустимый код выдачи");
            }
        }
        public DateTime Date
        {
            get
            {
                if (_Date == null)
                    throw new Exception("Укажите дату выдачи");
                else
                    return _Date;
            }
            set
            {
                _Date = value;
            }
        }
        public Employee EmployeeDelivery
        { get; set; }
        public IReader Reader1
        { get; set; }
        public Exemplar Exemplar1
        { get; set; }
        public Delivery(int DeliveryID, DateTime Date, Employee EmployeeDelivery, IReader Reader1, Exemplar Exemplar1)
        {
            this.DeliveryID = DeliveryID;
            this.Date = Date;
            this.EmployeeDelivery = EmployeeDelivery;
            this.Reader1 = Reader1;
            this.Exemplar1 = Exemplar1;
        }

        public virtual void Info()
        {
            Console.WriteLine("Код выдачи: {0} , Дата:\n", DeliveryID, Date);
            EmployeeDelivery.Info();
            Reader1.Info();
            Exemplar1.Info();
        }
    }
}
