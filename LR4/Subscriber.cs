using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Subscriber
    {       
        public string lastname, city1;
        public double min,cost;
        public tarif room;
        public Subscriber(string lastname, string city1, double min,double cost)
        {
            
            this.lastname = lastname;
            this.city1 = city1;
            this.min = min;
            this.cost = cost;
        }
       
        public string Lastname { get { return lastname; } }
        public tarif ROOM
        {
            get { return room; }
            set { room = value; }
        }

        internal TarifType TarifType
        {
            get => default;
            set
            {
            }
        }

        internal tarif tarif
        {
            get => default;
            set
            {
            }
        }

        internal Base Base
        {
            get => default;
            set
            {
            }
        }
    }
}

