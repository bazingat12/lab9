using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Delivery
    {
        public int ID_Delivery
        { get; set; }
        public DateTime Data
        { get; set; }
        public Employee EmployeeDelivery
        { get; set; }
        public IReader Reader1
        { get; set; }
        public Exemplar Exemplar1
        { get; set; }
        public Delivery(int ID_Delivery, DateTime Data, Employee EmployeeDelivery, IReader Reader1, Exemplar Exemplar1)
        {
            this.ID_Delivery = ID_Delivery;
            this.Data = Data;
            this.EmployeeDelivery = EmployeeDelivery;
            this.Reader1 = Reader1;
            this.Exemplar1 = Exemplar1;
        }

        public virtual void Info()
        {
            Console.WriteLine("Код выдачи: {0} , Дата:\n", ID_Delivery, Data);
            EmployeeDelivery.Info();
            Reader1.Info();
            Exemplar1.Info();
        }
    }
}
