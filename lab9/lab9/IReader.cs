using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    interface IReader
    {
         int ID_Reader
        { get;}
         string Surname
        { get;}
         string Name
        { get;}
         string Patronymic
        { get;}
         string Gender
        { get;}
         int Phone
        { get;}
         double st
        { get;}

        void Info();
    }
}
