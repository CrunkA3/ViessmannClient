using System.Collections.Generic;

namespace ViessmannClient.Model.Features
{
    public class ScheduleOrMessage
    {
        public Schedule? Schedule { get; set; }
        public List<Message>? Messages { get; set; }
    }
}