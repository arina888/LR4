using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Base
    {
        private static List<tarif> rooms = new List<tarif>();
        private static List<Subscriber> subscribers = new List<Subscriber>();

        internal static tarif tarif
        {
            get => default;
            set
            {
            }
        }

        internal static Subscriber Subscriber
        {
            get => default;
            set
            {
            }
        }

        internal static Subscriber Subscriber1
        {
            get => default;
            set
            {
            }
        }

        
        
        public static void showTarifs(DataGridView data, int index)
        {
            foreach (Subscriber subscriber in subscribers)
                if (subscriber.room.TR == TarifType.BUSY)
                {
                    data.Rows.Add();
                    data.Rows[index].Cells[0].Value = subscriber.lastname;
                    data.Rows[index].Cells[1].Value = subscriber.room.city1;
                    data.Rows[index].Cells[2].Value = subscriber.cost * subscriber.min;
                    index++;
                }
        }
        public static bool addTariff(tarif room)
        {
            foreach (tarif r in rooms)
            {
                if (r.city1 == room.city1)
                    return false;
            }
            rooms.Add(room);
            return true;

        }
        public static string addSubscriber(string lastName, string city1, double min, double cost)
        {
            foreach (tarif room in rooms)
            {
                if (room.city1 == city1)
                {
                    Subscriber subscriber = new Subscriber(lastName, city1,min,cost);
                    subscriber.lastname = lastName;
                    subscriber.ROOM = room;
                    subscriber.cost = cost;
                    subscribers.Add(subscriber);
                    room.TR = TarifType.BUSY;
                    subscriber = null;
    
                    return "Звонок зарегистрирован";
                }
            }
            return "Такого тарифа нет";
        }
        public static double ats(string last)
        {
            foreach (Subscriber subscriber in subscribers)
                if (subscriber.Lastname.Equals(last) )
                    return subscriber.cost * subscriber.min;
            return -1;
        }
    }
}

