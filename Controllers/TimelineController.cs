using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Timeline.Models;
using Timeline.Repostiories;

namespace Timeline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimelineController : ControllerBase
    {
        private TimeLineRepo _timeLineRepo = new TimeLineRepo();

        public TimelineController(TimeLineRepo timeLineRepo)
        {
            _timeLineRepo = timeLineRepo;

        }

        [HttpGet]
        public IEnumerable<TimeLine> GetTimeline()
        {
            return new List<TimeLine>(){
                new TimeLine(){
                    Id = 1,
                    Name = "NoResultsSoheresSoBS"
                },
                new TimeLine(){
                    Id = 2,
                    Name = "MoreBS"
                }
            };
        }

        [HttpGet]
        public IEnumerable<TimeLineEvent> GetEvents()
        {
            return _timeLineRepo.GetEvents();
        }

        [HttpPost]
        public void AddEvent([FromBody] TimeLineEvent test)
        {
            _timeLineRepo.AddEvent(test);
        }
    }
}