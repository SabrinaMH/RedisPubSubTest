namespace EasyRedisMQ.Consumer
{
    public class EventEnvelope
    {
        public string EventType { get; set; }
        public string OccurredAt { get; set; }
        public int EventVersion { get; set; }

        public string Payload { get; set; }

        public EventEnvelope(string eventType, string occurredAt, int eventVersion, string Payload)
        {
            EventType = eventType;
            OccurredAt = occurredAt;
            EventVersion = eventVersion;
            this.Payload = Payload;
        }
    }
}