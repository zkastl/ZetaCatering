using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZetaCatering.Model
{
    public class EventParty
    {
        public long EventId { get; private set; }
        public string Name { get; private set; }
        public DateTime EventDate { get; private set; }
        public string EventLocation { get; private set; }
        public EventPlanner Planner { get; private set; }
        public long EventPlannerId { get; private set; }
        public Client Client { get; private set; }
        private Dictionary<string, Guest> GuestList = new Dictionary<string, Guest>();
        public int TableSize { get; private set; }
        public int EmptySeats { get; private set; }
        public Layout SeatingArrangement { get; private set; }
        public string Status { get; private set; }

        public EventParty() { }

        public EventParty(string name)
        {
            Name = name;
        }

        public EventParty(string name, DateTime dt, string location, EventPlanner planner, 
            Client client, Dictionary<string, Guest> guestList, int tableSize, int emptySeats,
            string status)
        {
            Name = name;
            EventDate = dt;
            EventLocation = location;
            Planner = planner;
            Client = client;
            GuestList = guestList;
            TableSize = tableSize;
            EmptySeats = emptySeats;
            Status = status;
        }

        public void SetEventDate(string dateString) => 
            EventDate = DateTime.Parse(dateString);

        public bool AddGuest(Guest g)
        {
            g.EventId = EventId;
            GuestList.Add(g.GetName(), g);
            // GuestDAO.AddGuest
            throw new NotImplementedException();
        }

        public bool RemoveGuest(Guest g)
        {
            // guestDAO.removeguest
            throw new NotImplementedException();
        }

        public bool SaveEvent()
        {
            // EVENTDAO.SAVEEVENT
            throw new NotImplementedException();
        }

        public int GetNumberOfTables()
        {
            return (SeatingArrangement == null) ? 0 : 0;//SeatingArrangement.TableList.Size();
        }

        public void CalculateSeatingArrangement()
        {
            throw new NotImplementedException();
        }

        public string PrintGuestList()
        {
            throw new NotImplementedException();
        }

        public void ImportGuests(string csvFile)
        {
            throw new NotImplementedException();
        }

        public bool Update(EventParty eventParty)
        {
            throw new NotImplementedException();
        }
    }
}