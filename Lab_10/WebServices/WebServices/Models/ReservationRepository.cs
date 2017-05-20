using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebServices.Models
{
    public class ReservationRepository
    {
        private static ReservationRepository repo = new ReservationRepository();

        public static ReservationRepository Current
        {
            get
            {
                return repo;
            }
        }

        private List<Reservation> data = new List<Reservation> {
            new Reservation { 
                ReservationId = 1, ClientName = "Петр", Location = "Отель"},
            new Reservation { 
                ReservationId = 2, ClientName = "Вася", Location = "Библиотека"},
            new Reservation { 
                ReservationId = 3, ClientName = "Игорь", Location = "Столовая"},
        };

        public IEnumerable<Reservation> GetAll()
        {
            return data;
        }

        public Reservation Get(int id)
        {
            return data.Where(r => r.ReservationId == id).FirstOrDefault();
        }

        public Reservation Add(Reservation item)
        {
            item.ReservationId = data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            Reservation item = Get(id);
            if (item != null)
            {
                data.Remove(item);
            }
        }

        public bool Update(Reservation item)
        {
            Reservation storedItem = Get(item.ReservationId);
            if (storedItem != null)
            {
                storedItem.ClientName = item.ClientName;
                storedItem.Location = item.Location;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}