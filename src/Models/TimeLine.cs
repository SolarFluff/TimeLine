namespace Timeline.Models
{
    public class TimeLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeLineEvent Events { get; set; }
    }
}