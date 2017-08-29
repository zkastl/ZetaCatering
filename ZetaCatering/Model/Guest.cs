using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZetaCatering.Model
{
    public class Guest
    {
        public int GuestId { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int GuestNumber { get; internal set; }
        public List<int> SameTable { get; internal set; }
        public List<int> NotSameTable { get; internal set; }
        public Table AssignedTable { get; internal set; }
        public int TableNumber { get; internal set; }
        public long EventId { get; internal set; }
        public PartyEvent Party { get; internal set; }
        public string GuestComments { get; internal set; }

        public Guest() {}

        public Guest(int guestNumber, string firstName, string lastName,
            List<int> sameTable, List<int> notSameTable, int tableNumber,
            int eventId, string guestComments)
        {
            FirstName = firstName;
            LastName = lastName;
            GuestNumber = guestNumber;
            SameTable = new List<int>(sameTable);
            NotSameTable = new List<int>(notSameTable);
            TableNumber = tableNumber;
            EventId = eventId;
            GuestComments = guestComments;
        }

        public Guest(int guestNumber, string firstName, string lastName, List<int> sameTable,
            List<int> notSameTable, int tableNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            GuestNumber = guestNumber;
            SameTable = sameTable;
            NotSameTable = notSameTable;
            TableNumber = tableNumber;
            EventId = -1;
            GuestComments = "";
        }

        public string GetName() =>
            FirstName + " " + LastName;

        public List<Message> Validate()
        {
            if (NotSameTable == null)
                NotSameTable = new List<int>();
            if (SameTable == null)
                SameTable = new List<int>();
            if (GuestComments == null)
                GuestComments = string.Empty;
            if (Party == null && EventId > 0)
                return null;
                // EventDAO.findEventById(eventId).addGuest(this)
            return null;
        }

        public bool Update(Guest guest)
        {
            FirstName = guest.FirstName;
            LastName = guest.LastName;
            TableNumber = guest.TableNumber;
            GuestComments = guest.GuestComments;

            return true;
        }
    }
}
