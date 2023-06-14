using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
   
        enum TarifType { FREE, BUSY }

    internal class tarif
    {
        public string city1;
        public double cost;
        public string Person;
        private TarifType tariffType;
        public tarif(string city1, double cost)
        {
            this.city1 = city1;
            this.cost = cost;
            tariffType = TarifType.FREE;
        }
        public TarifType TR
        {
            get { return tariffType; }
            set { tariffType = value; }
        }
        public string City1 { get { return city1; } }

        public double Cost { get { return cost; } }

        internal Base Base
        {
            get => default;
            set
            {
            }
        }
    }

}

