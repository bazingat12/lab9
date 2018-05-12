using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    class Position
    {
        private int _PositionID;
        private string _PositionName;

       public int PositionID
        { get
            {
                return _PositionID;
            }
            set
            {
                if (value > 0)
                    _PositionID = value;
                else
                    Console.WriteLine("Неподустимый код должности");
            }
        }

        public string PositionName
        { get
            {
                if (String.IsNullOrEmpty(_PositionName))
                    throw new Exception("Должность не может быть пустой");
                else
                    return _PositionName;
            }
                set
            {
                _PositionName = value;
            }
        }
        public Position(int PositionID, string PositionName)
        {
            this.PositionID = PositionID;
            this.PositionName = PositionName;
        }

        public virtual void Info()
        {
            Console.WriteLine("    Должность: {0}\n ",
                PositionName);
        }
    }
}
