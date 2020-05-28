using System;
using System.Collections.Generic;
using Timeline.Models;

namespace Timeline.Repostiories
{
    public class TimeLineRepo
    {
        private List<TimeLineEvent> sessionEvents = new List<TimeLineEvent>();
        public TimeLineRepo()
        {
        }

        public IEnumerable<TimeLineEvent> GetEvents(){
            return sessionEvents;
        }

        public void AddEvent(TimeLineEvent timeLineEvent)
        {
            sessionEvents.Add(timeLineEvent);
        }
    }
}