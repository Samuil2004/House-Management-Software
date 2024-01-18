using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Management_Software
{
    public class EventManager
    {
        SqlDatabase sqlDatabase;

        public EventManager()
        {
            sqlDatabase = new SqlDatabase();
        }

        public void CreateEvent(string title,string description, DateTime dateTime, User loggedInUser)
        {
            Event newEvent = new Event(sqlDatabase.GetTheHighestIdForEvent()+1,title, description, dateTime, loggedInUser);
            sqlDatabase.InsertEventIntoSQL(newEvent);
        }

        public List<Event> GetEvents(User loggedInUser)
        {
            return sqlDatabase.AllEventsFromSQL(loggedInUser);
        }

        public void CancelEvent(Event selectedEvent)
        {
            sqlDatabase.CancelEvent(selectedEvent);
        }
        public string GetInfo()
        {
            return "Event has been sucessfully added";
        }

        public List<Event> GetEventsForAdmin()
        {
            return sqlDatabase.AllEventsFromSQLForAdmin();
        }
    }
}
