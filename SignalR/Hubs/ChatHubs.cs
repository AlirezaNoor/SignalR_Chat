using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs;

public class ChatHubs:Hub
{
    public async Task Sendmessage(string username, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", username, message);
    }
}