using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class DateDelivery : Delivery
    {
        private DateTime _StartOfDelivery;
        private DateTime _EndOfDelivery;


        public DateTime StartOfDelivery
        {
            get
            {
                if (_StartOfDelivery == null)
                    throw new Exception("Укажите дату выдачи");
                else
                    return _StartOfDelivery;
            }
                set
            {
                _StartOfDelivery = value;
            }
                }

        public DateTime EndOfDelivery
        {
            get
            {
                if (_EndOfDelivery == null)
                    throw new Exception("Укажите дату возврата");
                else
                    return _EndOfDelivery;
            }
            set
            {
                _EndOfDelivery = value;
            }
        }

        public DateDelivery(int ID_Delivery, DateTime Data, Employee EmployeeDelivery, Reader Reader1, Exemplar Exemplar1, DateTime StartofDelivery, DateTime EndofDelivery) :
            base(ID_Delivery, Data, EmployeeDelivery, Reader1, Exemplar1)
        {
            this.StartOfDelivery = StartOfDelivery;
            this.EndOfDelivery = EndOfDelivery;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine("\n Дата выдачи: {0}", StartOfDelivery);
            Console.WriteLine(" Дата возврата: {0}", EndOfDelivery);
        }
    }
}
