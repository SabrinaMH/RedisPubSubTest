namespace EasyRedisMQ.Producer
{
    public class ClientDisconnected
    {
        public string ClientId { get; set; }
        public string Reason { get; set; }

        public ClientDisconnected(string clientId, string reason)
        {
            ClientId = clientId;
            Reason = reason;
        }
    }
}