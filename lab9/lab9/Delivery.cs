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

        public Employee EmployeeDelivery
        { get; set; }
        public IReader ReaderDelivery
        { get; set; }
        public Exemplar ExemplarDelivery
        { get; set; }
        public Delivery(int DeliveryID, Employee EmployeeDelivery, IReader ReaderDelivery, Exemplar ExemplarDelivery)
        {
            this.DeliveryID = DeliveryID;
            this.EmployeeDelivery = EmployeeDelivery;
            this.ReaderDelivery = ReaderDelivery;
            this.ExemplarDelivery = ExemplarDelivery;
        }

        public virtual void Info()
        {
            Console.WriteLine("Код выдачи: {0}\n", DeliveryID);
            EmployeeDelivery.Info();
            ReaderDelivery.Info();
            ExemplarDelivery.Info();
        }
    }
}
